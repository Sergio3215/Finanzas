using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financias
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (System.IO.File.Exists("Key")&& System.IO.File.Exists("key2"))
            {
                ComprobarFecha c = new ComprobarFecha();
                c.ComproFecha();
                if (c.correcto == true && c.inco == false)
                {
                    if (System.IO.File.Exists(Application.LocalUserAppDataPath + @"\nomedia.dat")&&
                        System.IO.File.Exists(Application.UserAppDataPath + @"\nomedia.dat"))
                    {
                        c.correcto = false;
                        c.inco = false;
                        c.Licencia();
                        if (c.correcto == true && c.inco == false)
                        {
                            if (!System.IO.File.Exists("Financias_Process"))
                            {
                                if (System.IO.File.Exists(Application.StartupPath + @"\Config\IO.dat"))
                                {
                                    Application.Run(new frmCorroborarContra1());
                                }
                                else
                                    Application.Run(new Form1());
                            }
                            else
                                MessageBox.Show("El programa ya esta iniciado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MessageBox.Show("Su licencia Expiró ¿Desea ingresar alguna licencia?",
                                 "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                                 == DialogResult.Yes)
                            {
                                Application.Run(new frmLicencia());
                            }
                            else
                                Application.Exit();

                        }
                    }
                    else
                    {
                        c.Trial();
                        MessageBox.Show("Tendrá una versión de prueba de 2 meses");
                        Application.Run(new Form1());
                    }

                }
                else
                {
                    Application.Run(new frmHora());
                }
                c.correcto = false;
                c.inco = false;
            }
            else
                Application.Run(new frmError());

            if(System.IO.File.Exists("Financias_Process"))
            {
                System.IO.File.Delete("Financias_Process");
            }
        }
    }
}
