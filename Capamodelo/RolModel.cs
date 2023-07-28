using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace BtnPrinterExcel.Capamodelo
{
    class RolModel
    {
        public string rolid { get; set; }

        public string descripcion { get; set; }


        public bool activo { get; set; }

        public static DataTable GetRol { get; set; }

        public RolModel() { }

    }
}
