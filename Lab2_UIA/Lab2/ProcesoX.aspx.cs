using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    delegate double ProcesoMulti(double X);

    public partial class ProcesoX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName.Text = Session["NombreUser"].ToString();
        }

        protected void btncalct_Click(object sender, EventArgs e)
        {
                ProcesoMulti mult = Datos.multiplicacion;
                double num1 = Convert.ToDouble(txtb1.Text);
                double result = mult(num1);
                box2.Text = result.ToString();
        
        Action<string> ProcesoMulti = Datos.escribirBitacora;
        string guardar = String.Format("La multiplicación los numero {0} por 2 y da como resultado: {1}", num1, result);
        ProcesoMulti(guardar);
        }
    }
}