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
    public partial class Modificar : System.Web.UI.Page
    {
        Negocio_v1 neg = new Negocio_v1();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        private void combobox() {

            DropDownList1.AppendDataBoundItems = true;
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("------------------Seleccione--------------------");
            DropDownList1.DataSource = neg.ejecutar_listado();
            DropDownList1.DataTextField = "desc_producto";
            DropDownList1.DataBind();
        }

        private void listadatos(string campo1) {

            ds = neg.ejecutar_v4(campo1);
            TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            TextBox2.Text = ds.Tables[0].Rows[0][2].ToString();

        }

        private void actualizardatos(string campo1, string campo2, string campo3)
        {
            ds1 = neg.ejecutar_v5(campo1, campo2, campo3);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Felicitaciones!!', 'Registros Actualizados!', 'success')  </script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                combobox();
                ds.Tables.Clear();
                ds.Tables.Add(dt);
                ds = neg.ejecutar_listado();
              }
            //dt.Rows.ToString();
          }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" &&  DropDownList1.Text != "------------------Seleccione--------------------" )
            {
                actualizardatos(TextBox1.Text, TextBox2.Text, DropDownList1.Text);
                combobox();
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Alerta!!', 'Debe completar los campos y Seleccionar un producto!', 'warning')  </script>");
            }
          }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listadatos(DropDownList1.Text);  
          }
        }
      }