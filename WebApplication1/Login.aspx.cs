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
    public partial class Login : System.Web.UI.Page
    {
        Negocio_v1 neg = new Negocio_v1();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        public void validacion_usuario(string campo1, string campo2) {

            ds = neg.ejecutar_v7(campo1, campo2);

            if(ds.Tables[0].Rows.Count > 0) { 

            if (ds.Tables[0].Rows[0][1].ToString() == inputEmailAddress.Text && ds.Tables[0].Rows[0][2].ToString() == inputPassword.Text)
            {

                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Aprobado!!', 'Ingreso a Sistema!', 'success')  </script>");
                    rol_usuario();
                    inputEmailAddress.Text = "";
                    inputPassword.Text = "";
                    Response.Redirect("Index.aspx");
            }

                
            }
            else {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Rechazado!!', 'Error!!....Usuario y/o contraseña', 'error')  </script>");
                inputEmailAddress.Text = "";
                inputPassword.Text = "";
            }

            //rol_usuario();
        }

    public string rol_usuario() {

       string var = "0";
       Session["UserName"] = "";

       if (ds.Tables[0].Rows[0][3].ToString() == "negocio   ") {

                Session["UserName"] = "negocio";
            }
            return var;  
         }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            validacion_usuario(inputEmailAddress.Text, inputPassword.Text);
            //rol_usuario();
        }
    }
}