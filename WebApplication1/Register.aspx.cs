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
    public partial class Register : System.Web.UI.Page
    {
        Negocio_v1 neg = new Negocio_v1();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void crear_producto( string campo1, string campo2, string campo3)
        {
            //ds.Tables.Clear();
            //string var = "0";
            //ds.Tables.Add(dt);
            ds = neg.ejecutar_v3(campo1, campo2 , campo3);

            if (ds.Tables[0].Rows[0][0].ToString() == "1")
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Felicitaciones!!', 'Producto Registrado!', 'success')  </script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
            }

            if (ds.Tables[0].Rows[0][0].ToString() == "0")
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Rechazado!!', 'El producto existe en el catalogo!', 'error')  </script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text !="" && TextBox2.Text != "" ){
           
                crear_producto("0", TextBox1.Text, TextBox2.Text);
            }
            else{
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Alerta!!', 'Debe completar los campos!', 'warning')  </script>");
            }
        }
    }
}