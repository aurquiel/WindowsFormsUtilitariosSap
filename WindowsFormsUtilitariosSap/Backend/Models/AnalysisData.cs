using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsUtilitariosSap.Backend.DTOs;

namespace WindowsFormsUtilitariosSap.Backend.Models
{
    public class AnalysisData
    {
        /*Order 
         * "image", 
         * "Código de articulo",
         * "Descripción de articulo", 
         * "Fecha contabilización", 
         * "Stock Almacen", 
         * "Entrada", 
         * "Salida", 
         * "Ajustes", 
         * "Stock Cierre", 
         * "Porcentaje Venta", 
         * "Porcentaje Existencia", 
         * "Ultima Entrada", 
         * "Costo Ultima Entrada", 
         * "Precio Dolar"*/

        //"Image"
        public Image IMAGE_SET { get; set; }

        //"Código de articulo"
        public string MATNR { get; set; }

        //"Descripción de articulo"
        public string MAKTX { get; set; }

        //"Fecha contabilización"
        public string BUDAT { get; set; }

        //"Stock Almacen"
        public decimal LABST { get; set; }

        //Entrada
        public decimal MENGE_1 { get; set; }

        //Salida
        public decimal MENGE_2 { get; set; }

        //"Ajustes"
        public decimal MENGE_4 { get; set; }

        //"Stock Cierre"
        public decimal MENGE_3 { get; set; }

        //"Porcentaje Venta"
        public decimal VENTA { get; set; }

        //"Porcentaje Existencia"
        public decimal EXIST { get; set; }

        //"Ultima Entrada"
        public decimal MENGE_I { get; set; }

        //"Costo Ultima Entrada"
        //public decimal COENTR { get; set; }

        //"Precio Dolar"
        public decimal KBETR_A { get; set; }

        public static IList<AnalysisData> ParseFromFull(IList<AnalysisDataFull> analysisDataFullList)
        {
            return analysisDataFullList.Select(item => new AnalysisData
            {
                IMAGE_SET = item.IMAGE_SMALL_SIZE,
                MATNR = item.MATNR,
                MAKTX = item.MAKTX,
                BUDAT = item.BUDAT,
                LABST = item.LABST,
                MENGE_1 = item.MENGE_1,
                MENGE_2 = item.MENGE_2,
                MENGE_4 = item.MENGE_4,
                MENGE_3 = item.MENGE_3,
                VENTA = item.VENTA,
                EXIST = item.EXIST,
                MENGE_I =item.MENGE_I,
                //COENTR = item.COENTR,
                KBETR_A = item.KBETR_A
            }).ToList();
        }


    }
}
