using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["NombreUser"] = "Maikel Zamora";
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Datos MXM = new Datos();
            if (box1.Text==MXM.vuser && box2.Text==MXM.vpassword)
            {
                Response.Redirect("ProcesoX.aspx");
            }
            else
            {
               
            }
        }
    }
}