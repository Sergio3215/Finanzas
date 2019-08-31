using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financias
{
    class ComprobarFecha
    {
        public bool correcto = false, inco = false;

        public void ComproFecha()
        {
            File.WriteAllText("fecha1", DateTime.Now.ToString("dd/MM/yyyy"));
            Desencriptar("Key2");
            byte[] descencrypt = Convert.FromBase64String(File.ReadAllText("Key2"));
            string[] corte = Encoding.Unicode.GetString(descencrypt).Split('/');
            string[] corte1 = File.ReadAllText("fecha1").Split('/');
            File.Delete("fecha1");

            double dia=0, mes=0, año=0, dia1=0, mes1=0, año1=0;

            dia = int.Parse(corte[0]);
            mes = int.Parse(corte[1]);
            año = int.Parse(corte[2]);

            dia1 = int.Parse(corte1[0]);
            mes1 = int.Parse(corte1[1]);
            año1 = int.Parse(corte1[2]);

            if(año1 >= año)
            {
                if(mes1 == mes)
                {
                    if(dia1 >= dia)
                    {
                        correcto = true;
                    }
                    else
                        inco = true;
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
            }
            else
            {
                inco = true;
            }
            Encriptar("Key2");
        }
        
        public void Licencia()
        {
            Desencriptar("Key");
            byte[] descencrypt = Convert.FromBase64String(File.ReadAllText("Key"));
            string licencia = Encoding.Unicode.GetString(descencrypt);
            
            if(licencia == "Administrador Modo")
            {
                correcto = true;
            }
            else
            {
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
                    if(mes1==mes)
                    {
                        if(dia1<=dia)
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
                    if(mes1 < mes)
                    {
                        inco = false;
                        correcto = true;
                    }
                    if (mes1 > mes)
                    {
                        if (año1 <= año)
                        {
                            if (dia1 <= dia)
                            {
                                inco = false;
                                correcto = true;
                            }
                            else
                            {
                                inco = true;
                            }
                        }
                    }
                }
                else
                    inco = true;
            }
            Encriptar("Key");
        }

        public void Trial()
        {
            DateTime tiempo = DateTime.Now;

            string limite = tiempo.AddDays(60).ToString("dd/MM/yyyy");

            Byte[] ecrypt = Encoding.Unicode.GetBytes(limite);
            File.WriteAllText("Key", Convert.ToBase64String(ecrypt), Encoding.Unicode);

            File.WriteAllText("Tiempo de Licencia.txt", 2.ToString() + " Meses");

            if (!File.Exists(Application.LocalUserAppDataPath + @"\nomedia.dat"))
            {
                File.WriteAllText(Application.LocalUserAppDataPath + @"\nomedia.dat", "");
                File.SetAttributes(Application.LocalUserAppDataPath + @"\nomedia.dat", FileAttributes.Hidden);
            }

            if (!File.Exists(Application.UserAppDataPath + @"\nomedia.dat"))
            {
                File.WriteAllText(Application.UserAppDataPath + @"\nomedia.dat", "");
                File.SetAttributes(Application.UserAppDataPath + @"\nomedia.dat", FileAttributes.Hidden);
            }
            Encriptar("Key");
        }

        string key = "ABCDEFG54669525PQRSTUVWXYZabcdef852846opqrstuvwxyz";
        public void Encriptar(string filename)
        {
            byte[] plano = Encoding.UTF8.GetBytes(File.ReadAllText(filename));

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] code = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                md5.Clear();
                using (var des = new TripleDESCryptoServiceProvider())
                {
                    des.Key = code;
                    des.Mode = CipherMode.ECB;
                    des.Padding = PaddingMode.PKCS7;

                    using (var memo = new MemoryStream())
                    {
                        ICryptoTransform crypt = des.CreateEncryptor();
                        byte[] encrypt = crypt.TransformFinalBlock(plano, 0, plano.Length);
                        des.Clear();
                        File.WriteAllBytes(filename, encrypt.ToArray());
                    }
                }
            }

        }

        public void Desencriptar(string filename)
        {
            string text = Convert.ToBase64String(File.ReadAllBytes(filename), 0, File.ReadAllBytes(filename).Length);
            byte[] plano = Convert.FromBase64String(text);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] code = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                md5.Clear();
                using (var des = new TripleDESCryptoServiceProvider())
                {
                    des.Key = code;
                    des.Mode = CipherMode.ECB;
                    des.Padding = PaddingMode.PKCS7;

                    using (var memo = new MemoryStream())
                    {
                        ICryptoTransform crypt = des.CreateDecryptor();
                        try
                        {
                            byte[] array = crypt.TransformFinalBlock(plano, 0, plano.Length);
                            des.Clear();
                            File.WriteAllText(filename, UTF8Encoding.UTF8.GetString(array));
                        }
                        catch
                        {
                            Encriptar(filename);
                            byte[] array = crypt.TransformFinalBlock(plano, 0, plano.Length);
                            des.Clear();
                            File.WriteAllText(filename, UTF8Encoding.UTF8.GetString(array));
                        }
                    }
                }
            }

        }

    }
}
