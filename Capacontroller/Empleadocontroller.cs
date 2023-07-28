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
    class Empleadocontroller
    {
        public bool delusuario(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDDConexion"))
                {
                    Con.Open();

                    string sql = "execute delusuario '" + Modelo.idusuario + "' ";

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



        public bool CrearEmpleado(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDDConexion"))
                {
                    Con.Open();

                    string sql = "execute agregarusuario '" + Modelo.NombreUsuario + "' , '" + Modelo.ApelldoUsuario +
                        "' , '" + Modelo.RolUsuario + "' , '" + Modelo.clave + "' , " + Modelo.intentoLogueos +" ";

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



        public DataTable getempleados()
        {
            SqlConnection Con = new Conexion().GetConexion("BDDConexion");
            Con.Open();



            /*
            DataTable dataTable = new DataTable();
            string query = " select CodigoEmpleado,  NombreEmpleado , ApellidoEmpleado ,FechaIngreso  ,Antiguedad  , Salario   from empleado ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.CommandTimeout = 99999;
            new SqlDataAdapter(cmd).Fill(dataTable);
            */


            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showusuario", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;



        }


    }
}

    

