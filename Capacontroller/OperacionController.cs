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
    class OperacionController
    {

        public bool Crear(OperacionModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDDConexion"))
                {
                    Con.Open();

                    string sql = "execute addoperacion '" + Modelo.nombre + "' , '" + Modelo.indicador + "' ";

                    //string sql = "insert into Usuarios(IdUsuario,NombreUsuario,)"

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


        public bool delOperacion(OperacionModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDDConexion"))
                {
                    Con.Open();

                    string sql = "execute deloperacion '" + Modelo.id + "' ";

                    //string sql = "insert into Usuarios(IdUsuario,NombreUsuario,)"

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se borro exitosamente");

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

        public DataTable getOperacion()
        {
            SqlConnection Con = new Conexion().GetConexion("BDDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("getOperacion", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;


        }

    }
}
