using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionWeb
{
    public partial class Contabilidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            
            string nombre = this.txtNombre.Text;
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();
            this.lblMensaje.Text = conta.Saludos(nombre);

            double sueldi = double.Parse(this.txtSueldo.Text);
            this.lblSueldo.Text = conta.getSaldos(sueldi).ToString();

            
            int mes = int.Parse(this.txtNumMes.Text);
            this.lblMes.Text = CapaLogica.Utilidades.getNombreDelMes(mes);

            int a = int.Parse(this.txtDia.Text);
            int b = int.Parse(this.txtMes.Text);
            int c = int.Parse(this.txtAn.Text);
            this.lblFecha.Text = CapaLogica.Fecha.GetFecha(a,b,c);
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}