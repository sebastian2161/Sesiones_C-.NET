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
    public partial class Eliminar : System.Web.UI.Page
    {
        Negocio_v1 neg = new Negocio_v1();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        private void combobox()
        {

            DropDownList1.AppendDataBoundItems = true;
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("------------------Seleccione--------------------");
            DropDownList1.DataSource = neg.ejecutar_listado();
            DropDownList1.DataTextField = "desc_producto";
            DropDownList1.DataBind();
        }

        private void eliminar(string campo1)
        {
            ds = neg.ejecutar_v6(campo1);
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Felicitaciones!!', 'Registro Eliminado!', 'success')  </script>");
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                combobox();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text != "------------------Seleccione--------------------")
            {
                eliminar(DropDownList1.Text);
                combobox();
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Alerta!!', 'Debe Seleccionar un Producto!', 'warning')  </script>");
            }
        }
    }
}