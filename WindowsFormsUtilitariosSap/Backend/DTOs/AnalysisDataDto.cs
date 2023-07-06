using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsUtilitariosSap.Backend.DTOs
{
    public class AnalysisDataDto
    {
        public List<AnalysisDataDto> AnalysisDataDtoList = new List<AnalysisDataDto>();

        public string MATNR { get; set; }

        public string MAKTX { get; set; }

        public string BUDAT { get; set; }

        public decimal MENGE_1 { get; set; }

        public decimal MENGE_2 { get; set; }

        public decimal MENGE_3 { get; set; }

        public decimal VENTA { get; set; }

        public decimal EXIST { get; set; }

        public decimal MENGE_I { get; set; }

        public decimal COENTR { get; set; }

        public decimal MENGE_4 { get; set; }

        public decimal KBETR_A { get; set; }

        public decimal LABST { get; set; }

        public Image IMAGE_SMALL_SIZE { get; set; }

        public Image IMAGE_REAL_SIZE { get; set; }

        public bool IMAGE_SET_VALUE { get; set; } = false; //False para imagen pequeña

        public Image IMAGE_SET { get; set; }

    }
}
