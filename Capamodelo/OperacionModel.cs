using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BtnPrinterExcel.Capamodelo
{
    class OperacionModel
    {

        public string id { get; set; }

        public string nombre { get; set; }


        public string estado { get; set; }
        public string indicador { get; set; }


        public static DataTable GetOperacion { get; set; }

        public OperacionModel() { }

    }
}
