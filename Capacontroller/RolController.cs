using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BtnPrinterExcel.Capamodelo;


namespace BtnPrinterExcel.Capacontroller
{
    class RolController
    {

        public RolController() { }

        public bool Crear(RolModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute addrol '" + Modelo.descripcion + "' ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se agrego exitosamente");

                    Con.Close();
                }

                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public DataTable GetRol()
        {
            SqlConnection Con = new Conexion().GetConexion("BDDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showrol", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;


        }

        public bool eliminar(RolModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDDConexion"))
                {
                    Con.Open();

                    string sql = "execute deleterol '" + Modelo.rolid + "' ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se elimino exitosamente");

                    Con.Close();
                }

                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

    }
}
