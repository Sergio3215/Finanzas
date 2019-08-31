using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financias
{
    public partial class frmPrefencias : Form
    {
        public bool cambporc = false;
        public frmPrefencias()
        {
            InitializeComponent();
            LoadOption();
        }

        private void LoadOption()
        {
            if(File.Exists(Application.StartupPath+@"\Config\Option"))
            {
                string[] corte = File.ReadAllText(Application.StartupPath+@"\Config\Option").Split(';');
                cbPedidosMon.Text = corte[0];
                if(cbPedidosMon.Text == "Dolar USA")
                {
                    txtValorMonPedido.Text = corte[1];
                }
                cbPedidosMon.Focus();
            }
            if(File.Exists(Application.StartupPath+@"\Config\Option_01"))
            {
                txtPorcentaje.Text = File.ReadAllText(Application.StartupPath+@"\Config\Option_01");
            }
        }

        private void cbPedidosMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPedidosMon.Text == "Dolar USA")
            {
                txtValorMonPedido.Enabled = true;
            }
            else
            {
                txtValorMonPedido.Enabled = false;
                txtValorMonPedido.Text = "";
            }
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            int v1 = 0;
            v1 = f.Pregunta(v1);
            if (v1 !=0)
            {
                if (File.Exists(Application.StartupPath + @"\Config\Option"))
                {
                    string[] corte = File.ReadAllText(Application.StartupPath + @"\Config\Option").Split(';');
                    if (cbPedidosMon.Text != corte[0] ||
                        cbPedidosMon.Text == "Dolar USA" && corte[0] == "Dolar USA"
                        && corte[1] != txtValorMonPedido.Text)
                    {
                        if (cbPedidosMon.Text == "Dolar USA" && corte[0] == "Dolar USA"
                        && corte[1] != txtValorMonPedido.Text)
                        {
                            double valorviejo = double.Parse(corte[1]), valornuevo = double.Parse(txtValorMonPedido.Text);
                            f.ValorMone(valorviejo, valornuevo);
                        }
                        else
                        {
                            f.CambioMonetizacion(cbPedidosMon.Text, txtValorMonPedido.Text);
                        }
                        cambporc = true;
                    }
                }
            }
            if (int.Parse(txtPorcentaje.Text) > 0 && int.Parse(txtPorcentaje.Text) <= 100
                || txtPorcentaje.Text != null)
            {

                if (cbPedidosMon.Text == "Seleccione la Moneda")
                {
                    cbPedidosMon.Text = "Moneda Local";
                }

                if (cbPedidosMon.Text == "Dolar USA")
                {
                    File.WriteAllText(Application.StartupPath+@"\Config\Option", cbPedidosMon.Text + ";" + txtValorMonPedido.Text);
                }
                else
                {
                    File.WriteAllText(Application.StartupPath+@"\Config\Option", cbPedidosMon.Text);
                }

                if (v1 !=0)
                {
                    if (File.Exists(Application.StartupPath + @"\Config\Option_01"))
                    {
                        if (txtPorcentaje.Text != File.ReadAllText(Application.StartupPath + @"\Config\Option_01").ToString() && txtPorcentaje.Text != "0")
                        {
                            f.CambioPorcentaje(double.Parse(txtPorcentaje.Text));
                            File.WriteAllText(Application.StartupPath + @"\Config\Option_01", txtPorcentaje.Text);
                            cambporc = true;
                        }
                    }
                }
                else
                    File.WriteAllText(Application.StartupPath + @"\Config\Option_01", txtPorcentaje.Text);
            }
            else
                MessageBox.Show("El rango de porcentaje seleccionado no esta admitido");

                Close();

            if (cambporc == true)
            {
                if (MessageBox.Show(@"Se ha modificado exitosamente, para terminar la aplicación necesita reiniciar.
               (Si elige 'No' la aplicación se cerrará)

                             ¿Deseas reiniciar el programa?",
                    "información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
                cambporc = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
