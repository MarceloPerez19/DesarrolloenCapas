using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionForm
{
    public partial class txtDia : Form
    {
        public txtDia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();
            string nombre = this.txtNombre.Text;
            this.txtMensaje.Text = conta.Saludos(nombre);

            double x = double.Parse( this.txtSaldoInicial.Text);
            this.txtResultado.Text = conta.getSaldos(x).ToString();

            // llamando a Utilidades
            CapaLogica.Utilidades mes = new CapaLogica.Utilidades();
            int num = int.Parse(this.txtNumMes.Text);
            this.txtNombreMes.Text = mes.getNombreDelMes(num);

            CapaLogica.Fecha fe = new CapaLogica.Fecha();
            int a = int.Parse(this.txtDiaFecha.Text);
            int b = int.Parse(this.txtMes.Text);
            int c = int.Parse(this.txtAn.Text);
            this.txtFecha.Text = fe.GetFecha(a, b, c);

          
            
        }
    }
}
