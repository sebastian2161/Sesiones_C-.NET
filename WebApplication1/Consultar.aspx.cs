using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.ComponentModel;
using System;
using Negocio;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Negocio_v1 neg = new Negocio_v1();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        public string getWhileLoopData()
        {
            string htmlStr = "";
            int i= 0;

            while  (i < 70)
            {
                string ciudad = "London" + Convert.ToString(i);
                int edad = 20 + Convert.ToInt32(i);
                string salario = "$320,80" + Convert.ToString(i);

                htmlStr += "<tr><td>" + "TigerNixon" + "</td><td>" + "System Architect" + "</td><td>" + ciudad + "</td><td>" + edad + "</td><td>" + "2011 / 04 / 25" + "</td><td>" + salario + "</td></tr>";

                i = i + 1;
            }
            return htmlStr;
        }

        public string getWhileLoopData1()
        {
            string htmlStr = "";
            int i = 0;

            ds = neg.ejecutar_listado1();

            for(i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //string ciudad = "London" + Convert.ToString(i);
                int edad = 20 + Convert.ToInt32(i);
                string salario = "$320,80" + Convert.ToString(i);

                string id = ds.Tables[0].Rows[i][0].ToString();
                string producto = ds.Tables[0].Rows[i][1].ToString();
                string valor = ds.Tables[0].Rows[i][2].ToString();


                htmlStr += "<tr><td>" + id + "</td><td>" + producto + "</td><td>" + valor + "</td><td>" + edad + "</td><td>" + "1990 / 01 / 01" + "</td><td>" + "0" + "</td></tr>";

                
            }
            return htmlStr;
        }

        //public string datos01() {

        //    string var = "1";
        //    return var;
        //}

        public Int32 CargaData() {

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cargo");

            DataRow row = dt.NewRow();
            row["Id"] = 1;
            row["Nombre"] = "Andres";
            row["Cargo"] = "Developer";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 2;
            row["Nombre"] = "Federico";
            row["Cargo"] = "PM";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 3;
            row["Nombre"] = "Leonardo";
            row["Cargo"] = "Developer";
            dt.Rows.Add(row);

            Int32 var = dt.Rows.Count;

            return var;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}