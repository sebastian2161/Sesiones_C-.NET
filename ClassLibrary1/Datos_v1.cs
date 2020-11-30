using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Datos
{
    public class datos_v1
    {

        // El DataTable lo necesitamos para llenar la tabla productos - Guardar en memoria la data
        private DataTable dt;

        // El adapatador para obtener los datos sp
        private SqlDataAdapter da;

        // String de conexion 
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-4K08665; Initial Catalog=VentasDW;Integrated Security=True");
        private string configurationmanager;


        

        public DataSet Ejecutar(string cmd)
        {
            //SqlConnection Con = new SqlConnection("Data Source=DESKTOP-4K08665; Initial Catalog=VentasDW;Integrated Security=True");
            string strconexion = ConfigurationManager.ConnectionStrings["conexion_total"].ConnectionString;

            SqlConnection Con = new SqlConnection(strconexion);

            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;
        }


        public DataTable Ejecutar_v1(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-4K08665; Initial Catalog=VentasDW;Integrated Security=True");
            Con.Open();

            DataTable DS = new DataTable();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;
        }

        public DataSet Ejecutar_v2(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-4K08665; Initial Catalog=VentasDW;Integrated Security=True");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;
        }

        public DataSet ListarDatos()
        {
            string cadena;
            // cadena = String.Format("select * from [dbo].[Productos] Where id_producto='{0}'", TextBox1.Text.Trim())
            cadena = string.Format("select desc_producto from [dbo].[Productos] group by desc_producto");

            DataSet ds = Ejecutar_v2(cadena);
            return ds;
        }

        public DataSet ListarDatos1()
        {
            string cadena;
            // cadena = String.Format("select * from [dbo].[Productos] Where id_producto='{0}'", TextBox1.Text.Trim())
            cadena = string.Format("select * from [dbo].[Productos] order by id_producto");

            DataSet ds = Ejecutar_v2(cadena);
            return ds;
        }

        public DataSet insertarDatos(string cmd1, string cmd2, string cmd3)
        {
            string cadena;
            // cadena = String.Format("select * from [dbo].[Productos] Where id_producto='{0}'", TextBox1.Text.Trim())
            cadena = string.Format("EXEC [dbo].[pa_insertar_producto] @id_producto='{0}',@desc_producto='{1}',@valor_unitario='{2}'", cmd1, cmd2, cmd3);

            DataSet ds = Ejecutar_v2(cadena);
            return ds;
        }

        public DataSet listarActualizacionDatos(string cmd1)
        {
            
            string cadena;
            cadena = string.Format("select * from [dbo].[Productos] where desc_producto='{0}'", cmd1);

            DataSet ds = Ejecutar_v2(cadena);
            return ds;

        }

        public DataSet ActualizacionDatos(string cmd1,string cmd2, string cmd3)
        {
        
            string cadena;
            cadena = string.Format("update [dbo].[Productos] set desc_producto='{0}', valor_unitario='{1}' where desc_producto='{2}'", cmd1,cmd2, cmd3);

            DataSet ds = Ejecutar_v2(cadena);
            return ds;

        }

        public DataSet EliminarDatos(string cmd1) {

            string cadena;
            cadena = string.Format("delete [dbo].[Productos] where desc_producto='{0}'", cmd1);

            DataSet ds = Ejecutar_v2(cadena);
            return ds;
        }

        public DataSet ValidacionUsuario(string cmd1, string cmd2)
        {
            string cadena;
            // cadena = String.Format("select * from [dbo].[Productos] Where id_producto='{0}'", TextBox1.Text.Trim())
            cadena = string.Format("select * from [dbo].[Usuario] where email='{0}'  and contrasena='{1}'", cmd1, cmd2);

            DataSet ds = Ejecutar_v2(cadena);
            return ds;
        }


        //  public DataTable ListarDatos_v1(string cmd1)
        //  {
        //      string cadena;
        // cadena = String.Format("select * from [dbo].[Productos] Where id_producto='{0}'", TextBox1.Text.Trim())
        //cadena = string.Format("EXEC [dbo].[pa_busqueda_producto_v1] @id_producto='{0}'", cmd1);

        //    DataTable ds = Ejecutar_v1(cadena);
        //     return ds;
        //}
    }
    }