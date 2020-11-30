using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;


namespace Negocio
{
    public class Negocio_v1
    {
        private datos_v1 bd = new datos_v1();
        protected string _Id;
        protected string _Valor_Producto;
        protected string _Nombre_producto;
        private string _campo4;

        // La Propiedad Id
        public string Id
        {
            // Esta parte será la que devuelva el nombre
            get
            {
                // devuelve el contenido de la variable del nombre
                return _Id;
            }
            // Esta parte es la que asigna el valor a la variable del nombre
            set
            {
                _Id = value;
            }
        }

        // La Propiedad Nombre del producto
        public string Nombre_producto
        {
            // Esta parte será la que devuelva el nombre
            get
            {
                // devuelve el contenido de la variable del nombre
                return _Nombre_producto;
            }
            // Esta parte es la que asigna el valor a la variable del nombre
            set
            {
                _Nombre_producto = value;
            }
        }

        // La Propiedad valor del producto
        public string Valor_Producto
        {
            // Esta parte será la que devuelva el nombre
            get
            {
                // devuelve el contenido de la variable del nombre
                return _Valor_Producto;
            }
            // Esta parte es la que asigna el valor a la variable del nombre
            set
            {
                _Valor_Producto = value;
            }
        }

        //public Negocio_v1(string id, string nombre_producto, string valor_producto){
        //    this.Id = id;
        //    this.Nombre_producto = nombre_producto;
        //    this.Valor_Producto = valor_producto;
        //}



        public DataSet ejecutar_listado()
        {
            return bd.ListarDatos();
        }

        public DataSet ejecutar_listado1()
        {
            return bd.ListarDatos1();
        }

        public DataSet ejecutar_v3(string cmd1, string cmd2, string cmd3)
        {
            return bd.insertarDatos(cmd1, cmd2, cmd3);
        }

        public DataSet ejecutar_v4(string cmd1)
        {
            return bd.listarActualizacionDatos(cmd1);
        }

        public DataSet ejecutar_v5(string cmd1, string cmd2, string cmd3)
        {
            return bd.ActualizacionDatos(cmd1, cmd2, cmd3);
        }

        public DataSet ejecutar_v6(string cmd1)
        {
            return bd.EliminarDatos(cmd1);
        }

        public DataSet ejecutar_v7(string cmd1, string cmd2) {

            return bd.ValidacionUsuario(cmd1, cmd2);
        }

    }
   }