using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WindowsFormsUtilitariosSap.Backend.Models;

namespace WindowsFormsUtilitariosSap.Backend.Excel
{
    public static class ManageExcel
    {
        public static async Task<Tuple<bool, string>> Create(IList<AnalysisData> listData, string path)
        {
            return await Task.Run(() => ShellCreate(listData , path));
        }

        private static Tuple<bool, string> ShellCreate(IList<AnalysisData> listData, string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelPackage excel = new ExcelPackage();

            // name of the sheet
            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

            // setting the properties
            // of the work sheet 
            workSheet.TabColor = System.Drawing.Color.Black;
            workSheet.DefaultRowHeight = 12;

            // Setting the properties
            // of the first row
            workSheet.Row(1).Height = 20;
            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;

            try
            {
                workSheet.Cells[1, 1].Value = "Imagen";
                workSheet.Cells[1, 2].Value = "Código de articulo";
                workSheet.Cells[1, 3].Value = "Descripción de articulo";
                workSheet.Cells[1, 4].Value = "Fecha contabilización";
                workSheet.Cells[1, 5].Value = "Stock Almacen";
                workSheet.Cells[1, 6].Value = "Entrada";
                workSheet.Cells[1, 7].Value = "Salida";
                workSheet.Cells[1, 8].Value = "Ajustes";
                workSheet.Cells[1, 9].Value = "Stock Cierre";
                workSheet.Cells[1, 10].Value = "Porcentaje Venta";
                workSheet.Cells[1, 11].Value = "Porcentaje Existencia";
                workSheet.Cells[1, 12].Value = "Ultima Entrada";
                workSheet.Cells[1, 13].Value = "Precio Dolar";

                int col = 1;
                int row  = 2;

                foreach(var item in listData)
                {
                    AddImage(workSheet, row, col, item);
                    workSheet.Row(row).Height = item.IMAGE_SET.Height * 0.80; //Transformacion a Height de Excel
                    col++;
                    workSheet.Cells[row, col].Value = item.MATNR;
                    col++;
                    workSheet.Cells[row, col].Value = item.MAKTX;
                    col++;
                    workSheet.Cells[row, col].Value = item.BUDAT;
                    col++;
                    workSheet.Cells[row, col].Value = item.LABST;
                    col++;
                    workSheet.Cells[row, col].Value = item.MENGE_1;
                    col++;
                    workSheet.Cells[row, col].Value = item.MENGE_2;
                    col++;
                    workSheet.Cells[row, col].Value = item.MENGE_4;
                    col++;
                    workSheet.Cells[row, col].Value = item.MENGE_3;
                    col++;
                    workSheet.Cells[row, col].Value = item.VENTA;
                    col++;
                    workSheet.Cells[row, col].Value = item.EXIST;
                    col++;
                    workSheet.Cells[row, col].Value = item.MENGE_I;
                    col++;
                    workSheet.Cells[row, col].Value = item.KBETR_A;

                    col = 1;
                    row++;
                }

                workSheet.Column(1).Width = Math.Truncate((double)listData.Max(item => item.IMAGE_SET.Width) / 7 * 256) / 256;  //Transformacion a Width de Excel
                for (int i = 2; i<= 13; i++)
                {
                    workSheet.Column(i).AutoFit();
                }

                if (File.Exists(path))
                    File.Delete(path);

                // Create excel file on physical disk 
                FileStream objFileStrm = File.Create(path);
                objFileStrm.Close();

                // Write content to excel file 
                File.WriteAllBytes(path, excel.GetAsByteArray());
                //Close Excel package
                excel.Dispose();

                return new Tuple<bool, string>(true, "Archivo guardado con exito.");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, "Error, Excepcion: " + ex.Message.ToLower());
            }
        }

        private static void AddImage(ExcelWorksheet oSheet, int rowIndex, int colIndex, AnalysisData item)
        {
            var ms = new MemoryStream();
            item.IMAGE_SET.Save(ms, ImageFormat.Png);
            ms.Position = 0;
            ExcelPicture excelImage = null;
            if (item.IMAGE_SET != null)
            {
                excelImage = oSheet.Drawings.AddPicture(item.MATNR, ms);
                excelImage.From.Column = colIndex - 1;
                excelImage.From.Row = rowIndex - 1;
                excelImage.SetSize(item.IMAGE_SET.Width, item.IMAGE_SET.Height);
                 //2x2 px space for better alignment
                excelImage.From.ColumnOff = Pixel2MTU(2);
                excelImage.From.RowOff = Pixel2MTU(2);
            }
        }

        public static int Pixel2MTU(int pixels)
        {
            int mtus = pixels * 9525;
            return mtus;
        }
    }
}
