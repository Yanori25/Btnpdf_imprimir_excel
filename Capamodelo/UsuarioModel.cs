using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BtnPrinterExcel.Capamodelo
{
    class UsuarioModel
    {
        public string idusuario { get; set; }
        public int CodigoEmpleado { get; set; }

        public string NombreUsuario { get; set; }
        public string ApelldoUsuario { get; set; }

        public string RolUsuario { get; set; }

        public string clave { get; set; }

        public int intentoLogueos { get; set; }
        public Double RAP { get; set; }

        public Double IHSS { get; set; }

        public Double ISR { get; set; }

        public Double TotalAPagar { get; set; }


        public static DataTable ListarUsuario { get; set; }

        public UsuarioModel() { }
    }
}
