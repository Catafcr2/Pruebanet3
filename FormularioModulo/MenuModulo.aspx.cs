using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormularioModulo
{
    public partial class MenuModulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void _btnCalcularMod_Click(object sender, EventArgs e)
        {
            RefServicioModulo.IServicioModulo sm = new RefServicioModulo.ServicioModuloClient();
            int p1Num = 0;
            int seg2Num = 0;
            bool p1NumVal = Int32.TryParse(_txbxPrimNum.Text, out p1Num);
            bool seg2NumVal = Int32.TryParse(_txbxSegNum.Text, out seg2Num);

            if(p1NumVal && seg2NumVal)
            {
                int resultado = sm.calcularModulo(p1Num, seg2Num);
                if(resultado == -1)
                {
                    Response.Write("<script>alert('El divisor no puede ser cero.')</script>");
                    _lblRes.Text = "";
                }
                else
                {
                    _lblRes.Text = string.Format("El módulo de sus dos números es: {0}", resultado.ToString());
                }
            }
                else
            {
                Response.Write("<script>alert('Los números ingresados no están en formato de número válido.')</script>");
                _lblRes.Text = "";
            }  
            
        }
    }
}