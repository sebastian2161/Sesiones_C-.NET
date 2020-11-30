using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;


namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string getWhileLoopData()
        {
            string var;
            var = (string) Session["UserName"];
            //System.Windows.Forms.MessageBox.Show(var);
            return var;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            //string var;
            //var = (string) Session["UserName"];
            //System.Windows.Forms.MessageBox.Show(var);
        }
    }
}