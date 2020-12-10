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

            /*double x = double.Parse(this.txtsaldo.Text);
            this.txtresultado.Text = conta.getSaldos(x).ToString();

            // llamando a Utilidades
            int nummes = int.Parse(this.txtNumMes.Text);
            this.txtNombreMes.Text = CapaLogica.Utilidades.getNombreDelMes(nummes);*/
        }
    }
}