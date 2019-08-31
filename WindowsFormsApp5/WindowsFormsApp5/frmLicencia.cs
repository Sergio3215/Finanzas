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
    public partial class frmLicencia : Form
    {
        public frmLicencia()
        {
            InitializeComponent();
        }

        private void ComprobarLicencia()
        {
            try
            {
                if (txtLicencia.Text != "")
                {
                    byte[] descencrypt = Convert.FromBase64String(txtLicencia.Text);
                    string licencia = Encoding.Unicode.GetString(descencrypt);

                    bool inco = false, correcto = false;
                    string lic1 = DateTime.Now.ToString("dd/MM/yyyy");

                    string[] corte = licencia.Split('/'),
                        corte1 = lic1.Split('/');

                    int dia, mes, año, dia1, mes1, año1;

                    dia = int.Parse(corte[0]);
                    mes = int.Parse(corte[1]);
                    año = int.Parse(corte[2]);

                    dia1 = int.Parse(corte1[0]);
                    mes1 = int.Parse(corte1[1]);
                    año1 = int.Parse(corte1[2]);

                    if (año1 >= año)
                    {
                        if (mes1 == mes)
                        {
                            if (dia1 >= dia)
                            {
                                correcto = true;
                            }
                            else
                            {
                                inco = true;
                            }
                        }
                        else
                        {
                            inco = true;
                        }
                        if (mes1 > mes)
                        {
                            inco = false;
                            correcto = true;
                        }
                        if (mes1 < mes)
                        {
                            if (año1 >= año)
                            {
                                inco = false;
                                correcto = true;
                            }
                        }
                    }
                    else
                        inco = true;

                    if (inco == false && correcto == true)
                    {
                        File.WriteAllText("Key", txtLicencia.Text, Encoding.Unicode);
                        Form1 f = new Form1();
                        if (f.lic == false)
                        {
                            lblMensaje.ForeColor = Color.Green;
                            lblMensaje.Text = "El codigo proporcionado ha sido correcto. Pulse Reiniciar";
                            btnIngresar.Text = "Reiniciar";
                        }
                        else
                        {
                            lblMensaje.ForeColor = Color.Green;
                            lblMensaje.Text = "El codigo proporcionado ha sido correcto. Pulse Cerrar";
                            btnIngresar.Text = "Cerrar";
                        }
                    }
                    else
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "El codigo proporcionado ha sido incorrecto. Revise si lo ha escrito bien";
                    }
                }
                else
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "El codigo proporcionado ha sido incorrecto. Revise si lo ha escrito bien";
                }
            }
            catch
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "El codigo proporcionado ha sido incorrecto. Revise si lo ha escrito bien";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            switch (btnIngresar.Text)
            {
                case "Ingresar":
                    ComprobarLicencia();
                    break;
                case "Reiniciar":
                    Application.Restart();
                    break;
                case "Cerrar":
                    Close();
                    break;
            }
       
        }
    }
}
