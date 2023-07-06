using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WindowsFormsUtilitariosSap.Backend.DTOs;

namespace WindowsFormsUtilitariosSap.Backend.Services.SQL
{
    internal class AnalysisSQL : Database
    {
        public async Task<Tuple<bool, string, List<AnalysisDataDto>>> GetSalesAnalysis(string stores, string products)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GetSettingsConenction()))
            {
                try
                {
                    await sqlConnection.OpenAsync();
                    SqlCommand sqlCommand = new SqlCommand("GT99_Analisis_Ventas_RN", sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@WERKS_I", SqlDbType.NVarChar).Value = stores;
                    sqlCommand.Parameters.Add("@MATNR_I", SqlDbType.NVarChar).Value = products;
                    sqlCommand.CommandTimeout = SQL_TIMEOUT_EXECUTION_COMMAND;

                    SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

                    List<AnalysisDataDto> analysisDataDto = new List<AnalysisDataDto>();

                    while (await reader.ReadAsync())
                    {
                        analysisDataDto.Add(new AnalysisDataDto
                        {
                            MATNR = reader["MATNR"].ToString(),
                            MAKTX = reader["MAKTX"].ToString(),
                            BUDAT = reader["BUDAT"].ToString(),
                            MENGE_1 = decimal.Parse(reader["MENGE_1"].ToString()),
                            MENGE_2 = decimal.Parse(reader["MENGE_2"].ToString()),
                            MENGE_3 = decimal.Parse(reader["MENGE_3"].ToString()),
                            VENTA = decimal.Parse(reader["VENTA"].ToString()),
                            EXIST = decimal.Parse(reader["EXIST"].ToString()),
                            MENGE_I = decimal.Parse(reader["MENGE_I"].ToString()),
                            COENTR = decimal.Parse(reader["COENTR"].ToString()),
                            MENGE_4 = decimal.Parse(reader["MENGE_4"].ToString()),
                            KBETR_A = decimal.Parse(reader["KBETR_A"].ToString()),
                            LABST = 0,
                            IMAGE_SMALL_SIZE = null,
                            IMAGE_REAL_SIZE = null,
                            IMAGE_SET_VALUE = false
                        });
                    }

                    reader.Close();

                    var productsSplit = products.Split(',');
                    var productsQuotes = string.Empty;

                    foreach(var product in productsSplit)
                    {
                        productsQuotes += "'" + product + "',";
                    }

                    productsQuotes = productsQuotes.TrimEnd(',');

                    string queryLastColumn = String.Format("Select ISNULL(SUM(a.LABST), 0) as CANTIDAD, MATNR as MATNR FROM p01.MARD AS a WHERE MANDT = '400' And a.MATNR in ({0}) And a.WERKS IN ('1000','2000') And a.LGORT IN ('0000' , '2000') And a.LABST > 0 group by a.MATNR", productsQuotes);
                    sqlCommand = new SqlCommand(queryLastColumn, sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    reader = await sqlCommand.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        AnalysisDataDto objectToInsert = analysisDataDto.Where(item => item.MATNR == reader["MATNR"].ToString()).FirstOrDefault();
                        if(objectToInsert != null)
                        {
                            analysisDataDto[analysisDataDto.FindIndex(item => item.MATNR == objectToInsert.MATNR)].LABST = decimal.Parse(reader["CANTIDAD"].ToString());
                        }
                    }

                    sqlConnection.Close();
                    return new Tuple<bool, string, List<AnalysisDataDto>>(true, "Operacion Exitosa", analysisDataDto);
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    return new Tuple<bool, string, List<AnalysisDataDto>>(false, "Operacion Fallida, Excepcion: " + ex.Message.ToLower(), new List<AnalysisDataDto>());
                }
            }
        }
    }
}
