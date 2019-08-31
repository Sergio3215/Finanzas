using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financias
{
    public partial class Form1 : Form
    {

        bool Edicion = false, MesNuevo = false, EdicionServicio = false, 
             EdicionMisServicios = false;
        public Image img1;
        int row = 0, rowservicio = 0,rowMiServicio = 0;

        public Form1()
        {
            InitializeComponent();
            FileCarpeta();
            CargarLogo();
            NomPerfCarga();
            LoadCells();
            LoadCellsRecibido();
            LoadCellsStock();
            LoadCellsServicio();
            LoadCellsMisServicio();
            LoadNombreEmpleado();
            CapturarFecha();
            Trace.TraceInformation("Init Application");
        }

        //perfil trabajo

        public void LoadNombreEmpleado()
        {
            if (File.Exists(Application.StartupPath + @"\File\Data_2"))
            {
                if (img1 != null)
                    img1.Dispose();
                if (cbNombreTrabajador.Items.Count == 0)
                {
                    string[] linea = File.ReadAllLines(Application.StartupPath + @"\File\Data_2");
                    for (int i = 0; linea.Count() > i; i++)
                    {
                        string[] corte = linea[i].Split(';');
                        cbNombreTrabajador.Items.Add($"{corte[0]} {corte[1]}-{corte[5]}");
                    }
                    cbNombreTrabajador.Enabled = true;
                }
                else
                {
                    string[] linea = File.ReadAllLines(Application.StartupPath + @"\File\Data_2");
                    for (int i = 0; linea.Count() > i; i++)
                    {
                        string[] corte = linea[i].Split(';');
                        cbNombreTrabajador.Items.Add($"{corte[0]} {corte[1]}-{corte[5]}");
                    }
                }
            }
            else
                cbNombreTrabajador.Enabled = false;
        }
        private void ImageNombreEmpleado()
        {
            if (File.Exists(Application.StartupPath + $@"\File\Empleado\temp.tmp"))
            {
                if (img1 != null)
                    img1.Dispose();
                pbEmpleFoto.Image.Dispose();
                File.Delete(Application.StartupPath + $@"\File\Empleado\temp.tmp");
            }

            string[] corte = cbNombreTrabajador.Text.Split('-');
            string contenedor = corte[0];
            string valor = "";
            if (contenedor != "")
            {
                valor = contenedor.Substring(0, 2);
                if (valor == "\r\n")
                    valor = contenedor.Substring(2);
                else
                    valor = contenedor;
                img1 = Image.FromFile(Application.StartupPath + $@"\File\Empleado\{valor}\Perfil.jpg");
                img1.Save(Application.StartupPath + $@"\File\Empleado\temp.tmp");
                img1.Dispose();
                img1 = Image.FromFile(Application.StartupPath + $@"\File\Empleado\temp.tmp");
            }
            else
            {
                img1 = Image.FromFile(Application.StartupPath + @"\File\Empleado\usuario perfil oculto.jpg");
                img1.Save(Application.StartupPath + $@"\File\Empleado\temp.tmp");
                img1.Dispose();
                img1 = Image.FromFile(Application.StartupPath + $@"\File\Empleado\temp.tmp");
            }

            pbEmpleFoto.Image = img1;
        }

        //perfil Negocio

        private void AceptNomPerf()
        {
            lblNomPerfil.Text = txtNomPerfil.Text;
            lblNomPerfil.Visible = true;
            txtNomPerfil.Visible = false;
            btnNomPerfilCance.Visible = false;
            btnNomPerfilAcep.Visible = false;
            File.WriteAllText(Application.StartupPath+@"\File\Data_1", lblNomPerfil.Text+";"+lblNomPerfil.Location.X.ToString());
        }
        private void NomPerfCarga()
        {
            if(File.Exists(Application.StartupPath + @"\File\Data_1"))
            {
                string[] corte = File.ReadAllText(Application.StartupPath + @"\File\Data_1").Split(';');
                lblNomPerfil.Text = corte[0];
                lblNomPerfil.Location = new Point(int.Parse(corte[1]), lblNomPerfil.Location.Y);
            }
        }

        //imagen logo

        private void CargarLogo()
        {
            if (File.Exists(Application.StartupPath + @"\image\logo.jpg"))
            {
                ConversorFoto c = new ConversorFoto();
                pbePerfil.Image = c.CambiarTamañoImagen(Image.FromFile(Application.StartupPath + @"\image\logo.jpg"),200);
            }
            else
            {
              pbePerfil.Image.Save(Application.StartupPath + @"\image\logo.jpg");
            }
        }

        private void ImageEclipseBox()
        {
            Image img;
            if (File.Exists(Application.StartupPath + @"\File\Data"))
            {
                ofdBuscarPerfil.InitialDirectory = File.ReadAllText(Application.StartupPath + @"\File\Data");

                ofdBuscarPerfil.FileName = "";

                if (ofdBuscarPerfil.ShowDialog() == DialogResult.OK)
                {
                    ConversorFoto c = new ConversorFoto();
                    img = c.CambiarTamañoImagen(Image.FromFile(ofdBuscarPerfil.FileName),200);
                    pbePerfil.Image.Dispose();
                    File.Delete("logo.`jpg");
                    img.Save(Application.StartupPath + @"\image\logo.jpg");
                    img.Dispose();
                    pbePerfil.Image = Image.FromFile(Application.StartupPath + @"\image\logo.jpg");
                    File.WriteAllText(Application.StartupPath + @"\File\Data", ofdBuscarPerfil.FileName);
                }

            }
            else
            {
                ofdBuscarPerfil.InitialDirectory = Application.StartupPath;
                if (ofdBuscarPerfil.ShowDialog() == DialogResult.OK)
                {
                    ConversorFoto c = new ConversorFoto();
                    img = c.CambiarTamañoImagen(Image.FromFile(ofdBuscarPerfil.FileName), 200);
                    pbePerfil.Image.Dispose();
                    File.Delete("logo.`jpg");
                    img.Save(Application.StartupPath + @"\image\logo.jpg");
                    img.Dispose();
                    pbePerfil.Image = Image.FromFile(Application.StartupPath + @"\image\logo.jpg");
                    File.WriteAllText(Application.StartupPath + @"\File\Data", ofdBuscarPerfil.FileName);
                }
            }
        }

        //preguntas de stock en preferencias

        public int Pregunta(int v1)
        {
            v1 = dgvStock.Rows.Count - 1;
            return v1;
        }

        //Metodo para cambiar la monetización
        public void CambioMonetizacion(string cambio, string cash)
        {
            string moneda = cambio, mone = cash;
            double porc = double.Parse(File.ReadAllText(Application.StartupPath + @"\Config\Option_01")), num1=0;

            if (mone != "")
            {
               num1 = double.Parse(mone);
            }

            if (moneda== "Dolar USA")
            {
                for(int i=0; dgvStock.Rows.Count-1 > i ; i++)
                {
                    double num = Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value);
                    double suma = 0;
                    
                    suma = num * num1;
                    dgvStock.Rows[i].Cells[4].Value = suma.ToString("n2");
                }
            }
            else
            {
                string[] corte = File.ReadAllText(Application.StartupPath + @"\Config\Option").Split(';');
                mone = corte[1];
                num1 = double.Parse(mone);
                for (int i = 0; dgvStock.Rows.Count - 1 > i; i++)
                {
                    double num = Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value);
                    double suma = 0;
                    
                    suma = num / num1;
                    dgvStock.Rows[i].Cells[4].Value = suma.ToString("n2");
                }
            }
            SaveCellsStock();
        }
        public void ValorMone(double viejo, double nuevo)
        {
            double v1 = viejo, v2 = nuevo;

            string corte = File.ReadAllText(Application.StartupPath + @"\Config\Option_01");
            double num1 = double.Parse(corte);
            for (int i = 0; dgvStock.Rows.Count - 1 > i; i++)
            {
                double num = Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value);
                double suma = 0;
                
                suma = num / v1;
                suma = suma * v2;
                dgvStock.Rows[i].Cells[4].Value = suma.ToString("n2");
            }
            SaveCellsStock();
        }
        
        //Metodo para cambiar de porcentaje de ganancia

        public void CambioPorcentaje(double nuevo)
        {
            double viejo = int.Parse(File.ReadAllText(Application.StartupPath + @"\Config\Option_01"));
            double actual = nuevo;
            CambioPorcentaje(viejo,nuevo);
        }
        
        private void CambioPorcentaje(double viejo, double nuevo)
        {
            double porc = viejo, porc1 = nuevo;
            for (int i = 0; dgvStock.Rows.Count - 1 > i; i++)
            {
                double suma = 0, porcentaje = 0;
                string num = "";

                suma = (Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value) * 100) / (100 + porc);
                porcentaje = ((suma * porc1) / 100) + suma;
                num = porcentaje.ToString("n2");
                dgvStock.Rows[i].Cells[4].Value = num;
            }
            SaveCellsStock();
        }

        //capturar fecha del dia

        private void CapturarFecha()
        {
            Byte[] encry = Encoding.Unicode.GetBytes(DateTime.Now.ToString("dd/MM/yyyy"));
            string fecha = Convert.ToBase64String(encry);
            File.WriteAllText("Key2", fecha);
            ComprobarFecha c = new ComprobarFecha();
            c.Encriptar("Key2");
        }

        //Botones


        //botones del menú
        private void MenuPanel()
        {
            if (pnMenu.Visible == false)
            {
                pnMenu.Visible = true;
            }
            else
            {
                pnMenu.Visible = false;
            }
        }

        //Boton Aceptar/Guardar
        private void Aceptar()
        {
            if (chkUnidad.Checked && txtCantidad.Text != "" && txtPrecioUnidad.Text != "")
            {
                double x = double.Parse(txtCantidad.Text), y = double.Parse(txtPrecioUnidad.Text);
                double multiplo = x * y;
                txtPrecio.Text = multiplo.ToString();
            }
            if (txtNombreProducto.Text != "" && txtUnidMedPedido.Text != "" &&
                txtCantidad.Text != "" && txtPrecio.Text != "" && txtFechaPedido.Text != ""
                && txtFechaRecepcion.Text != "" && txtNombreProveedor.Text != "" && Edicion == false)
            {

                if (txtTelProveedor.Text == "")
                    txtTelProveedor.Text = "-";

                if (txtDirProveedor.Text == "")
                    txtDirProveedor.Text = "-";

                if (txtCodProv.Text == "")
                    txtCodProv.Text = "-";


                dgvPedido.Rows.Add(txtNombreProducto.Text, txtUnidMedPedido.Text,
                    txtCantidad.Text, txtPrecio.Text, txtFechaPedido.Text, txtFechaRecepcion.Text,
                    txtNombreProveedor.Text, txtDirProveedor.Text, txtTelProveedor.Text, txtCodProv.Text);

                SaveCells();
                Cancelar();
                txtNombreProducto.Focus();
            }
            else
            {
                if (Edicion == false)
                    MessageBox.Show("Complete los campos requeridos con un \" * \" ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txtTelProveedor.Text == "")
                        txtTelProveedor.Text = "-";

                    if (txtDirProveedor.Text == "")
                        txtDirProveedor.Text = "-";

                    if (txtCodProv.Text == "")
                        txtCodProv.Text = "-";

                    dgvPedido.Rows[row].Cells[0].Value = txtNombreProducto.Text;
                    dgvPedido.Rows[row].Cells[1].Value = txtUnidMedPedido.Text;
                    dgvPedido.Rows[row].Cells[2].Value = txtCantidad.Text;
                    dgvPedido.Rows[row].Cells[3].Value = txtPrecio.Text;
                    dgvPedido.Rows[row].Cells[4].Value = txtFechaPedido.Text;
                    dgvPedido.Rows[row].Cells[5].Value = txtFechaRecepcion.Text;
                    dgvPedido.Rows[row].Cells[6].Value = txtNombreProveedor.Text;
                    dgvPedido.Rows[row].Cells[7].Value = txtTelProveedor.Text;
                    dgvPedido.Rows[row].Cells[8].Value = txtDirProveedor.Text;
                    dgvPedido.Rows[row].Cells[9].Value = txtCodProv.Text;
                    SaveCells();
                    Cancelar();
                    txtNombreProducto.Focus();
                }
            }
        }

        //Boton Cancelar
        private void Cancelar()
        {
            txtNombreProducto.Text = "";
            txtUnidMedPedido.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtFechaPedido.Text = "";
            txtFechaRecepcion.Text = "";
            txtNombreProveedor.Text = "";
            txtTelProveedor.Text = "";
            txtDirProveedor.Text = "";
            txtCodProv.Text = "";
            btnAceptar.Text = "Aceptar";
            Edicion = false;
            txtPrecioUnidad.Text = "";
            chkUnidad.Checked = false;
            row = 0;
        }


        private void AceptarServicio()
        {
            if (txtNombreServicio.Text != "" && txtAbonarServicio.Text != "" &&
                txtfechaVencimiento.Text != "" && EdicionServicio == false)
            {
                dgvServicios.Rows.Add(txtNombreServicio.Text,
                    txtAbonarServicio.Text,
                    txtfechaVencimiento.Text);
                CancelarServicio();
                SaveCellsServicios();
                txtNombreServicio.Focus();
            }
            else
            {
                if (EdicionServicio == false)
                    MessageBox.Show("Complete los campos requeridos con un \" * \" ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (EdicionServicio == true)
                {
                    dgvServicios.Rows[rowservicio].Cells[0].Value = txtNombreServicio.Text;
                    dgvServicios.Rows[rowservicio].Cells[1].Value = txtAbonarServicio.Text;
                    dgvServicios.Rows[rowservicio].Cells[2].Value = txtfechaVencimiento.Text;
                    CancelarServicio();
                }
            }
        }

        private void CancelarServicio()
        {
            txtNombreServicio.Text = "";
            txtAbonarServicio.Text = "";
            txtfechaVencimiento.Text = "";
            btnAceptarServicio.Text = "Aceptar";
            EdicionServicio = false;
            rowservicio = 0;
        }

        private void AceptarMisServicio()
        {
            if (txtValorMisServicios.Text != "" && txtNombreMisServicios.Text != ""
                && EdicionMisServicios == false)
            {
                dgvMisServicios.Rows.Add(txtNombreMisServicios.Text, txtValorMisServicios.Text,
                    "0", "0", "0");

                SaveCellsMisServicios();
                CancelarMisServicios();
            }
            else
            {
                if (EdicionMisServicios == false)
                    MessageBox.Show("Error hay espacios en blanco", "Alerta");
                else
                {
                    dgvMisServicios.Rows[rowMiServicio].Cells[0].Value = txtNombreMisServicios.Text;
                    dgvMisServicios.Rows[rowMiServicio].Cells[1].Value = txtValorMisServicios.Text;

                    SaveCellsMisServicios();
                    CancelarMisServicios();
                }
            }
        }

        private void CancelarMisServicios()
        {
            txtNombreMisServicios.Text = "";
            txtValorMisServicios.Text = "";
            btnAceptarMisServis.Text = "Aceptar";
            EdicionMisServicios = false;
            rowMiServicio = 0;
        }

//fecha
        private void FechaForm()
        {
            txtFechaPedido.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

 //CLose y Load Form
        private void Close_form()
        {
            File.Delete("Financias_Process");
            File.WriteAllText(Application.StartupPath+@"\Config\Config", lblPedido.Text + ";" + lblServicio.Text + ";" 
                + gbPedido.Visible.ToString() + ";" + gbServicios.Visible.ToString()+
                ";"+lblServicio.Location.Y+";"+gbServicios.Location.X+";"+
                gbServicios.Location.Y);

            File.WriteAllText(Application.StartupPath+@"\Config\Config1", tabControl1.Location.X + ";"+ 
                tabControl1.Location.Y +";"+tabControl1.Size.Height+";"+
                tabControl1.Size.Width);

            File.WriteAllText(Application.StartupPath+@"\Config\Config2", btnLimpiarRecepcion.Location.X + ";" +
                btnLimpiarRecepcion.Location.Y );

            File.WriteAllText(Application.StartupPath+@"\Config\Config3", btnNuevoDia.Location.X + ";" +
                btnNuevoDia.Location.Y);

            File.WriteAllText(Application.StartupPath+@"\Config\Config4", btnNuevoMes.Location.X + ";" +
                btnNuevoMes.Location.Y);
            

            if (this.Location.X != -32000 && this.Location.Y != -32000)
            {
                File.WriteAllText(Application.StartupPath+@"\Config\Config6", this.Location.X.ToString() + ";" + this.Location.Y.ToString());
                File.WriteAllText(Application.StartupPath+@"\Config\Config5", this.Size.Height.ToString() + ";" + this.Size.Width.ToString());

                File.WriteAllText(Application.StartupPath+@"\Config\Config7", tabControl1.Location.X.ToString() + ";" + tabControl1.Location.Y.ToString());
                File.WriteAllText(Application.StartupPath+@"\Config\Config8", tabControl1.Size.Width.ToString() + ";" + tabControl1.Size.Height.ToString());
            }
            else
            {
                File.Delete(Application.StartupPath+@"\Config\Config");
            }
            

            File.WriteAllText(Application.StartupPath+@"\Config\Config9", gbMisServicios.Location.X.ToString() + ";" + gbMisServicios.Location.Y.ToString());

            File.WriteAllText(Application.StartupPath+@"\Config\Config10", gbMisServicios.Visible.ToString());

            Application.Exit();
        }
        private void LoadClose()
        {
            if (File.Exists(Application.StartupPath+@"\Config\Config"))
            {
                string[] corte = File.ReadAllText(Application.StartupPath+@"\Config\Config").Split(';');
                string[] corte1 = File.ReadAllText(Application.StartupPath+@"\Config\Config1").Split(';');
                string[] corte2 = File.ReadAllText(Application.StartupPath+@"\Config\Config2").Split(';');
                string[] corte3 = File.ReadAllText(Application.StartupPath+@"\Config\Config3").Split(';');
                string[] corte4 = File.ReadAllText(Application.StartupPath+@"\Config\Config4").Split(';');
                string[] corte5 = File.ReadAllText(Application.StartupPath+@"\Config\Config5").Split(';');
                string[] corte6 = File.ReadAllText(Application.StartupPath+@"\Config\Config6").Split(';');
                string[] corte7 = File.ReadAllText(Application.StartupPath+@"\Config\Config7").Split(';');
                string[] corte8 = File.ReadAllText(Application.StartupPath+@"\Config\Config8").Split(';');
                string[] corte9 = File.ReadAllText(Application.StartupPath+@"\Config\Config9").Split(';');

                lblPedido.Text = corte[0].ToString();
                lblServicio.Text = corte[1].ToString();
                lblServicio.Location = new Point(0, int.Parse(corte[4]));
                gbPedido.Visible = bool.Parse(corte[2]);

                gbServicios.Visible = bool.Parse(corte[3]);
                gbServicios.Location = new Point(int.Parse(corte[5]), int.Parse(corte[6]));

                tabControl1.Location = new Point(int.Parse(corte1[0]), int.Parse(corte1[1]));
                tabControl1.Size = new Size(int.Parse(corte1[3]), int.Parse(corte1[2]));

                btnLimpiarRecepcion.Location = new Point(int.Parse(corte2[0]), int.Parse(corte2[1]));

                btnNuevoDia.Location = new Point(int.Parse(corte3[0]), int.Parse(corte3[1]));

                btnNuevoMes.Location = new Point(int.Parse(corte4[0]), int.Parse(corte4[1]));

                this.Size = new Size(int.Parse(corte5[1]), int.Parse(corte5[0]));
                this.Location = new Point(int.Parse(corte6[0]), int.Parse(corte6[1]));

                tabControl1.Location = new Point(int.Parse(corte7[0]), int.Parse(corte7[1]));
                tabControl1.Size = new Size(int.Parse(corte8[0]), int.Parse(corte8[1]));

                gbMisServicios.Location = new Point(int.Parse(corte9[0]), int.Parse(corte9[1]));
                gbMisServicios.Visible = bool.Parse(File.ReadAllText(Application.StartupPath+@"\Config\Config10"));

            }
        }

//carpeta file
        private void FileCarpeta()
        {
            if (!Directory.Exists(Application.StartupPath + @"\File"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\File");
            }
            if (!Directory.Exists(Application.StartupPath + @"\Config"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Config");
            }
            if (!Directory.Exists(Application.StartupPath + @"\image"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\image");
            }
            if(!Directory.Exists(Application.StartupPath + @"\File\Empleado"))
            {
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + @"\File\Empleado");
                dir.Create();
                dir.Attributes = FileAttributes.Hidden;
                pbEmpleFoto.Image.Save(Application.StartupPath+ @"\File\Empleado\usuario perfil oculto.jpg");
            }
        }

//Carga de Pedido Grilla
        private void LoadCells()
        {
            if (File.Exists(Application.StartupPath+@"\File\File"))
            {
                ComprobarFecha c = new ComprobarFecha();
                c.Desencriptar(Application.StartupPath + @"\File\File");
                string[] lineas = File.ReadAllLines(Application.StartupPath+@"\File\File");
                for (int i = 0; i < lineas.Count(); i++)
                {
                    string[] corte = lineas[i].Split(';');
                    dgvPedido.Rows.Add(corte[0], corte[1], corte[2], corte[3], corte[4], corte[5], corte[6], corte[7], corte[8], corte[9]);
                }
                c.Encriptar(Application.StartupPath + @"\File\File");
            }
        }

//Carga de Recibir Grilla
        private void LoadCellsRecibido()
        {
            if (File.Exists(Application.StartupPath+@"\File\File1"))
            {
                ComprobarFecha c = new ComprobarFecha();
                c.Desencriptar(Application.StartupPath + @"\File\File1");
                string[] lineas = File.ReadAllLines(Application.StartupPath+@"\File\File1");
                for (int i = 0; i < lineas.Count(); i++)
                {
                    string[] corte = lineas[i].Split(';');
                    dgvRecepcion.Rows.Add(corte[0], corte[1], corte[2], corte[3], corte[4], corte[5], corte[6], corte[7], corte[8], corte[9]);
                }
                c.Encriptar(Application.StartupPath + @"\File\File1");
            }
        }

//Carga de Stock Grilla
        private void LoadCellsStock()
        {
            if (File.Exists(Application.StartupPath+@"\File\File2"))
            {
               ComprobarFecha c = new ComprobarFecha();
               c.Desencriptar(Application.StartupPath + @"\File\File2");
                string[] lineas = File.ReadAllLines(Application.StartupPath+@"\File\File2");
                for (int i = 0; i < lineas.Count(); i++)
                {
                    string[] corte = lineas[i].Split(';');
                    dgvStock.Rows.Add(corte[0], corte[1], corte[2], corte[3],corte[4],corte[5],corte[6],corte[7],corte[8]);
                }
                c.Encriptar(Application.StartupPath + @"\File\File2");
            }
        }


//Carga de Servicio Grilla
        private void LoadCellsServicio()
        {
            if (File.Exists(Application.StartupPath+@"\File\File3"))
            {
               ComprobarFecha c = new ComprobarFecha();
               c.Desencriptar(Application.StartupPath + @"\File\File3");
                string[] lineas = File.ReadAllLines(Application.StartupPath+@"\File\File3");
                for (int i = 0; i < lineas.Count(); i++)
                {
                    string[] corte = lineas[i].Split(';');
                    dgvServicios.Rows.Add(corte[0], corte[1], corte[2]);
                }
                c.Encriptar(Application.StartupPath + @"\File\File3");
            }
        }

//Carga de Servicio Grilla
        private void LoadCellsMisServicio()
        {
            if (File.Exists(Application.StartupPath+@"\File\File4"))
            {
               ComprobarFecha c = new ComprobarFecha();
               c.Desencriptar(Application.StartupPath + @"\File\File4");
                string[] lineas = File.ReadAllLines(Application.StartupPath+@"\File\File4");
                for (int i = 0; i < lineas.Count(); i++)
                {
                    string[] corte = lineas[i].Split(';');
                    dgvMisServicios.Rows.Add(corte[0], corte[1], corte[2], corte[3],corte[4]);
                }
                c.Encriptar(Application.StartupPath + @"\File\File4");
            }
        }


//Salvar Grilla Pedido
        private void SaveCells()
        {
            List<string> lstFilas = new List<string>();
            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                string contenedor = "";
                //Ultima fila la descartamos
                if (row.Index == dgvPedido.Rows.Count - 1)
                    break;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        contenedor += " ";
                    else
                        contenedor += cell.Value.ToString();
                    contenedor += ";";
                }
                lstFilas.Add(contenedor.TrimEnd(';'));
                //Borramos el fichero para olver a empezar
                if (File.Exists(Application.StartupPath+@"\File\File")) File.Delete(Application.StartupPath+@"\File\File");
                File.WriteAllLines(Application.StartupPath+@"\File\File", lstFilas);
                ComprobarFecha c = new ComprobarFecha();
                c.Encriptar(Application.StartupPath + @"\File\File");
            }
        }

//Salvar Grilla Recibir
        private void SaveCellsReception()
        {
            List<string> lstFilas = new List<string>();
            foreach (DataGridViewRow row in dgvRecepcion.Rows)
            {
                string contenedor = "";
                //Ultima fila la descartamos
                if (row.Index == dgvRecepcion.Rows.Count - 1)
                    break;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        contenedor += " ";
                    else
                        contenedor += cell.Value.ToString();
                    contenedor += ";";
                }
                lstFilas.Add(contenedor.TrimEnd(';'));
                //Borramos el fichero para olver a empezar
                if (File.Exists(Application.StartupPath+@"\File\File1")) File.Delete(Application.StartupPath+@"\File\File1");
                File.WriteAllLines(Application.StartupPath+@"\File\File1", lstFilas);
                ComprobarFecha c = new ComprobarFecha();
                c.Encriptar(Application.StartupPath + @"\File\File1");
            }
        }

//Salvar Grilla Stock
        private void SaveCellsStock()
        {
            List<string> lstFilas = new List<string>();
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                string contenedor = "";
                //Ultima fila la descartamos
                if (row.Index == dgvStock.Rows.Count - 1)
                    break;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        contenedor += " ";
                    else
                        contenedor += cell.Value.ToString();
                    contenedor += ";";
                }
                lstFilas.Add(contenedor.TrimEnd(';'));
                //Borramos el fichero para olver a empezar
                if (File.Exists(Application.StartupPath+@"\File\File2")) File.Delete(Application.StartupPath+@"\File\File2");
                File.WriteAllLines(Application.StartupPath+@"\File\File2", lstFilas);
                ComprobarFecha c = new ComprobarFecha();
                c.Encriptar(Application.StartupPath + @"\File\File2");
            }
            if (dgvStock.Rows.Count - 1 == 0)
            {
                btnNuevoDia.Enabled = false;
                btnNuevoMes.Enabled = false;
            }
            else
            {
                btnNuevoDia.Enabled = true;
                btnNuevoMes.Enabled = true;
            }
        }


//Salvar Grilla Servicios
        private void SaveCellsServicios()
        {
            List<string> lstFilas = new List<string>();
            foreach (DataGridViewRow row in dgvServicios.Rows)
            {
                string contenedor = "";
                //Ultima fila la descartamos
                if (row.Index == dgvServicios.Rows.Count - 1)
                    break;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        contenedor += " ";
                    else
                        contenedor += cell.Value.ToString();
                    contenedor += ";";
                }
                lstFilas.Add(contenedor.TrimEnd(';'));
                //Borramos el fichero para volver a empezar
                if (File.Exists(Application.StartupPath+@"\File\File3")) File.Delete(Application.StartupPath+@"\File\File3");
                File.WriteAllLines(Application.StartupPath+@"\File\File3", lstFilas);
                ComprobarFecha c = new ComprobarFecha();
                c.Encriptar(Application.StartupPath + @"\File\File3");
            }
        } 
        
//Salvar Grilla Mis Servicios
        private void SaveCellsMisServicios()
        {
            List<string> lstFilas = new List<string>();
            foreach (DataGridViewRow row in dgvMisServicios.Rows)
            {
                string contenedor = "";
                //Ultima fila la descartamos
                if (row.Index == dgvMisServicios.Rows.Count - 1)
                    break;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        contenedor += " ";
                    else
                        contenedor += cell.Value.ToString();
                    contenedor += ";";
                }
                lstFilas.Add(contenedor.TrimEnd(';'));
                //Borramos el fichero para volver a empezar
                if (File.Exists(Application.StartupPath+@"\File\File4")) File.Delete(Application.StartupPath+@"\File\File4");
                File.WriteAllLines(Application.StartupPath+@"\File\File4", lstFilas);
                ComprobarFecha c = new ComprobarFecha();
                c.Encriptar(Application.StartupPath + @"\File\File4");
            }

            if (dgvMisServicios.Rows.Count - 1 == 0)
            {
                btnNuevoDia.Enabled = false;
                btnNuevoMes.Enabled = false;
            }
            else
            {
                btnNuevoDia.Enabled = true;
                btnNuevoMes.Enabled = true;
            }
        }



//Comprueba si hay Rows(Filas) en las Grillas
        private void Counts()
        {
            if (dgvPedido.Rows.Count -1 == 0 && File.Exists(Application.StartupPath+@"\File\File"))
                File.Delete(Application.StartupPath+@"\File\File");

            if (dgvRecepcion.Rows.Count - 1 == 0 && File.Exists(Application.StartupPath+@"\File\File1"))
            {
                File.Delete(Application.StartupPath+@"\File\File1");
                btnLimpiarRecepcion.Enabled = false;
            }

            if (dgvStock.Rows.Count - 1 == 0 && File.Exists(Application.StartupPath+@"\File\File2"))
            {
                File.Delete(Application.StartupPath+@"\File\File2");
                btnNuevoDia.Enabled = false;
            }
                

            if (dgvServicios.Rows.Count - 1 == 0 && File.Exists(Application.StartupPath+@"\File\File3"))
                File.Delete(Application.StartupPath+@"\File\File3");

            if (dgvMisServicios.Rows.Count - 1 == 0 && File.Exists(Application.StartupPath+@"\File\File4"))
                File.Delete(Application.StartupPath+@"\File\File4");

            if (cbNombreTrabajador.Items.Count - 1 == 0)
            {
                cbNombreTrabajador.Enabled = false;
                File.Delete(Application.StartupPath + @"\File\Data_2");
            }
                
        }

//Comprobar items en stock y ssegun su cantidad poner un color
        private void ColorCellsStock()
        {
            for(int i = 0; dgvStock.Rows.Count-1 > i; i++)
            {
                if (Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) >= 0 && Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) <= 5)
                {
                    dgvStock.Rows[i].Cells[0].Style.BackColor = Color.OrangeRed;
                    dgvStock.Rows[i].Cells[0].Style.ForeColor = Color.White;

                    dgvStock.Rows[i].Cells[1].Style.BackColor = Color.OrangeRed;
                    dgvStock.Rows[i].Cells[1].Style.ForeColor = Color.White;

                    dgvStock.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed;
                    dgvStock.Rows[i].Cells[2].Style.ForeColor = Color.White;
                }
                else if (Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) > 5 && Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) <= 15)
                {
                    dgvStock.Rows[i].Cells[0].Style.BackColor = Color.Orange;
                    dgvStock.Rows[i].Cells[0].Style.ForeColor = Color.Black;

                    dgvStock.Rows[i].Cells[1].Style.BackColor = Color.Orange;
                    dgvStock.Rows[i].Cells[1].Style.ForeColor = Color.Black;

                    dgvStock.Rows[i].Cells[2].Style.BackColor = Color.Orange;
                    dgvStock.Rows[i].Cells[2].Style.ForeColor = Color.Black;
                }
                else if (Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) > 15 && Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) <= 20)
                {
                    dgvStock.Rows[i].Cells[0].Style.BackColor = Color.GreenYellow;
                    dgvStock.Rows[i].Cells[0].Style.ForeColor = Color.Black;

                    dgvStock.Rows[i].Cells[1].Style.BackColor = Color.GreenYellow;
                    dgvStock.Rows[i].Cells[1].Style.ForeColor = Color.Black;

                    dgvStock.Rows[i].Cells[2].Style.BackColor = Color.GreenYellow;
                    dgvStock.Rows[i].Cells[2].Style.ForeColor = Color.Black;
                }
                else if (Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) > 20)
                {
                    dgvStock.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    dgvStock.Rows[i].Cells[0].Style.ForeColor = Color.White;

                    dgvStock.Rows[i].Cells[1].Style.BackColor = Color.Green;
                    dgvStock.Rows[i].Cells[1].Style.ForeColor = Color.White;

                    dgvStock.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    dgvStock.Rows[i].Cells[2].Style.ForeColor = Color.White;
                }
            }
        }


//habilitar Boton limpiar campos de Recepcion / reporte
        private void ComprobarLimpiarRecepcion()
        {
            //Limpiar txtBuscador
            if (tabControl1.SelectedIndex == 0)
                EliminarBuscador();
            if (tabControl1.SelectedIndex == 1)
                EliminarBuscador();
            if (tabControl1.SelectedIndex == 2)
                EliminarBuscador();
            if (tabControl1.SelectedIndex == 3)
                EliminarBuscador();
            if (tabControl1.SelectedIndex == 4)
                EliminarBuscador();

            //habilitar boton limpiar recepcion
            if (tabControl1.SelectedIndex == 1 && dgvRecepcion.Rows.Count - 1 != 0)
                btnLimpiarRecepcion.Enabled = true;
            else
                btnLimpiarRecepcion.Enabled = false;

            //Stock y Mis Servicios
            if (tabControl1.SelectedIndex == 2 && dgvStock.Rows.Count - 1 != 0
                || tabControl1.SelectedIndex == 4 && dgvMisServicios.Rows.Count - 1 != 0)
            {
                btnNuevoDia.Enabled = true;
                btnNuevoMes.Enabled = true;
            }
            else
            {
                btnNuevoDia.Enabled = false;
                btnNuevoMes.Enabled = false;
            }


            //Reporte
            if (tabControl1.SelectedIndex == 5 || MesNuevo == true)
            {
                if(dgvStock.Rows.Count -1 != 0 || dgvMisServicios.Rows.Count -1 !=0)
                {
                    double sumar = 0;

                    //Articulos
                    for(int i = 0; dgvStock.Rows.Count > i; i++)
                    {
                        sumar = Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) + sumar;
                    }
                    lblArtCant.Text = "Hay "+(dgvStock.Rows.Count -1).ToString()+" artículos, todo juntos son "+sumar.ToString()+" artículos";

                    //Gastos
                    sumar = 0;
                    for (int i = 0; dgvStock.Rows.Count > i; i++)
                    {
                        sumar = Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value) + sumar;
                    }

                    if (dgvServicios.Rows.Count - 1 != 0)
                    {
                        //si hay Option
                        if (File.Exists(Application.StartupPath+@"\Config\Option"))
                        {
                            string[] corte = File.ReadAllText(Application.StartupPath+@"\Config\Option").Split(';');

                            if (corte[0] == "Dolar USA")
                            {
                                for (int i = 0; dgvServicios.Rows.Count > i; i++)
                                {
                                    sumar = (Convert.ToDouble(dgvServicios.Rows[i].Cells[1].Value) * double.Parse(corte[1])) + sumar;
                                }
                            }
                            else
                            {
                                for (int i = 0; dgvServicios.Rows.Count > i; i++)
                                {
                                    sumar = Convert.ToDouble(dgvServicios.Rows[i].Cells[1].Value) + sumar;
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; dgvServicios.Rows.Count > i; i++)
                            {
                                sumar = Convert.ToDouble(dgvServicios.Rows[i].Cells[1].Value) + sumar;
                            }
                        }

                        lblGast.Text = sumar.ToString();
                    }
                    else
                    {
                        lblGast.Text = sumar.ToString();
                    }

                    //Ganancias del Día
                    sumar = 0;

                    for (int i = 0; dgvStock.Rows.Count > i; i++)
                    {
                        sumar = Convert.ToDouble(dgvStock.Rows[i].Cells[7].Value) + sumar;
                    }

                    if (dgvMisServicios.Rows.Count - 1 != 0)
                    {
                        for (int i = 0; dgvMisServicios.Rows.Count > i; i++)
                        {
                            sumar = Convert.ToInt32(dgvMisServicios.Rows[i].Cells[3].Value) + sumar;
                        }
                    }

                    lblGananciaDía.Text = sumar.ToString();

                    //Ganancias
                    sumar = 0;

                    for (int i = 0; dgvStock.Rows.Count > i; i++)
                    {
                        sumar = Convert.ToDouble(dgvStock.Rows[i].Cells[8].Value) + sumar;
                    }

                    if (dgvMisServicios.Rows.Count - 1 != 0)
                    {
                        for (int i = 0; dgvMisServicios.Rows.Count > i; i++)
                        {
                            sumar = Convert.ToInt32(dgvMisServicios.Rows[i].Cells[4].Value) + sumar;
                        }
                    }

                    lblGan.Text = sumar.ToString();

                    //Capital
                    sumar = 0;
                    sumar = double.Parse(lblGan.Text) - double.Parse(lblGast.Text);
                    lblCap.Text = sumar.ToString();

                    //Promedio Ganancia
                    sumar = 0;
                    for (int i = 0; dgvStock.Rows.Count > i; i++)
                    {
                        double sumar1 = Convert.ToDouble(dgvStock.Rows[i].Cells[6].Value) + Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value);
                        sumar = (sumar1 * Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value)) + sumar;
                    }

                    if (dgvMisServicios.Rows.Count - 1 != 0)
                    {
                        for (int i = 0; dgvMisServicios.Rows.Count > i; i++)
                        {
                            sumar = Convert.ToInt32(dgvMisServicios.Rows[i].Cells[4].Value) + sumar;
                        }
                    }

                    lblPromGan.Text = sumar.ToString();

                    //Promedio Capital
                    sumar = 0;
                    sumar = double.Parse(lblPromGan.Text) - double.Parse(lblGast.Text);
                    lblPromCap.Text = sumar.ToString();
                }
                else
                {
                    lblArtCant.Text = "0";
                    lblGan.Text = "0";

                    if (dgvServicios.Rows.Count - 1 != 0)
                    {
                        double sumar = 0;
                        for (int i = 0; dgvServicios.Rows.Count > i; i++)
                        {
                            sumar = Convert.ToDouble(dgvServicios.Rows[i].Cells[1].Value) + sumar;
                        }
                        lblGast.Text = sumar.ToString();
                    }
                    else
                    {
                        lblGast.Text = "0";
                    }
                    lblCap.Text = "0";
                    lblPromCap.Text = "0";
                    lblPromGan.Text = "0";
                }
            }
        }
        private void LimpiarRecepcion()
        {
            for (int i = dgvRecepcion.Rows.Count -2 ; i != -1; i--)
            {
                dgvRecepcion.Rows.RemoveAt(dgvRecepcion.Rows[i].Index);
            }
            Counts();
            SaveCellsReception();
        }
//Boton Nuevo Mes        
        private void NuevoMes()
        {
            MesNuevo = true;
            ComprobarLimpiarRecepcion();
            MesNuevo = false;
            string tiempo = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string filename = $"VentasDelMes_{tiempo}.txt";
            string load = "";
            string stg1 = "";
            load = "------------INVENTARIO------------";
            for (int i = 0; dgvStock.Rows.Count - 1 > i; i++)
            {
                if (Convert.ToDouble(dgvStock.Rows[i].Cells[6].Value) > 0)
                {
                        load += Environment.NewLine;
                        stg1 = $@"{dgvStock.Rows[i].Cells[0].Value.ToString()} - {dgvStock.Rows[i].Cells[1].Value.ToString()} ({dgvStock.Rows[i].Cells[6].Value.ToString()}) :";
                        if (stg1.Length <= 22)
                        {
                            load += stg1 + "\t\t\t\t\t" + $"${Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value)}";
                            
                        }
                        else
                        {
                            load += stg1 + "\t\t\t\t" + $"${Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value)}";
                            
                        }
                }
                else
                {
                    if (dgvStock.Rows[i].Cells[0].Value.ToString().Length <= 22)
                    {
                        load += Environment.NewLine;
                        load += $"{dgvStock.Rows[i].Cells[0].Value}" + "\t\t\t" + "-";

                    }
                    else
                    {
                        load += Environment.NewLine;
                        load += $"{dgvStock.Rows[i].Cells[0].Value}" + "\t\t" + "-";

                    }
                }
            }

            //sumar Mis Servicios
            double sumar = 0;
            for (int i = 0; dgvMisServicios.Rows.Count > i; i++)
            {
                if (Convert.ToDouble(dgvMisServicios.Rows[i].Cells[4].Value) > 0)
                {
                    double unid = Convert.ToDouble(dgvMisServicios.Rows[i].Cells[4].Value);
                    sumar = unid + sumar;
                }
            }


            //sumar Stock
            double sumar1 = 0;
            for (int i = 0; dgvStock.Rows.Count > i; i++)
            {
                if (Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value) > 0)
                {
                    double unid = Convert.ToDouble(dgvStock.Rows[i].Cells[8].Value);
                    sumar1 = unid + sumar1;
                }
            }

            //total stock
            load += Environment.NewLine;
            load += Environment.NewLine;
            load += "Total:" + "\t\t\t\t" + $"${sumar1}";



            load += Environment.NewLine;
            load += "------------Mis Servicios------------";
            

            for (int i = 0; dgvMisServicios.Rows.Count-1 > i; i++)
            {
                if (Convert.ToDouble(dgvMisServicios.Rows[i].Cells[4].Value) > 0)
                {
                        load += Environment.NewLine;
                        stg1 = $@"{dgvMisServicios.Rows[i].Cells[0].Value.ToString()}({dgvMisServicios.Rows[i].Cells[2].Value}):";
                        if (stg1.Length <= 22)
                        {
                            load += stg1 + "\t\t\t" + $"${Convert.ToDouble(dgvMisServicios.Rows[i].Cells[1].Value)}";
                            
                        }
                        else
                        {
                            load += stg1 + "\t\t" + $"${Convert.ToDouble(dgvMisServicios.Rows[i].Cells[1].Value)}";
                            
                        }
                }
                else
                {
                    if (dgvMisServicios.Rows[i].Cells[0].Value.ToString().Length <= 22)
                    {
                        load += Environment.NewLine;
                        load += $"{dgvMisServicios.Rows[i].Cells[0].Value}" + "\t\t\t" + "-";

                    }
                    else
                    {
                        load += Environment.NewLine;
                        load += $"{dgvMisServicios.Rows[i].Cells[0].Value}" + "\t\t" + "-";
                    }
                }
            }

            //Mis Servicios
                load += Environment.NewLine;
                load += Environment.NewLine;
                load += "Total:" + "\t\t\t\t" + $"${sumar}";

            for (int i = dgvMisServicios.Rows.Count - 2; i != -1; i--)
            {
                dgvMisServicios.Rows[i].Cells[2].Value = "0";
                dgvMisServicios.Rows[i].Cells[3].Value = "0";
                dgvMisServicios.Rows[i].Cells[4].Value = "0";
            }
                SaveCellsMisServicios();

            
            load += Environment.NewLine;
            load += "------------Resumen del Mes------------";

            load += Environment.NewLine;
            load += Environment.NewLine;
            load += "Gasto Mensual:" + "\t\t\t" + "$" + lblGast.Text;

            load += Environment.NewLine;
            load += Environment.NewLine;
            load += "Ganancia Mensual:" + "\t\t\t" + "$" + lblGan.Text;

            load += Environment.NewLine;
            load += Environment.NewLine;
            load += "Capital Mensual:" + "\t\t\t" + "$" + lblCap.Text;
            File.WriteAllText(filename, load);

            //Limpiar precio de compra, ventas del dia, y ventas general
            for(int i = 0; dgvStock.Rows.Count -1 > i; i++)
            {
                dgvStock.Rows[i].Cells[3].Value = "0";
                dgvStock.Rows[i].Cells[5].Value = "0";
                dgvStock.Rows[i].Cells[6].Value = "0";
            }


            //Limpiar Mis servicios
            for (int i = 0; dgvMisServicios.Rows.Count - 1 > i; i++)
            {
                dgvMisServicios.Rows[i].Cells[2].Value = "0";
                dgvMisServicios.Rows[i].Cells[3].Value = "0";
                dgvMisServicios.Rows[i].Cells[4].Value = "0";
            }

            //limpiar recepción

            for (int i = 0; dgvRecepcion.Rows.Count-1 > i; i++)
            {
                dgvRecepcion.Rows.RemoveAt(i);
            }

            Counts();

            //Limpiar Servicios

            for(int i = 0; dgvServicios.Rows.Count-1 > i; i++)
            {
                dgvServicios.Rows[i].Cells[1].Value = "0";
                dgvServicios.Rows[i].Cells[2].Value = "dd/mm/yyyy";
            }

            SaveCellsReception();
            SaveCellsServicios();
            SaveCellsStock();
            SaveCellsMisServicios();
        }

        private void NuevoDia()
        {
            string tiempo = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string filename = $"VentasDelDía_{tiempo}.txt";
            string load = "";
            string stg = "";
            double subt = 0, subt1 = 0;

            load = "------------INVENTARIO------------";
            for (int i = 0; dgvStock.Rows.Count - 1 > i; i++)
            {
                if (Convert.ToDouble(dgvStock.Rows[i].Cells[5].Value) > 0)
                {
                    load += Environment.NewLine;
                    stg = $@"{dgvStock.Rows[i].Cells[0].Value.ToString()} - {dgvStock.Rows[i].Cells[1].Value.ToString()} ({dgvStock.Rows[i].Cells[5].Value.ToString()}) :";
                    if (stg.Length <= 22)
                    {
                        load += stg + "\t\t\t" + $"${Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value)}";
                        
                    }
                    else
                    {
                        load += stg + "\t\t" + $"${Convert.ToDouble(dgvStock.Rows[i].Cells[4].Value)}";
                        
                    }
                }
                else
                {
                    if (dgvStock.Rows[i].Cells[0].Value.ToString().Length <= 22)
                    {
                        load += Environment.NewLine;
                        load += $"{dgvStock.Rows[i].Cells[0].Value}" + "\t\t\t" + "-";

                    }
                    else
                    {
                        load += Environment.NewLine;
                        load += $"{dgvStock.Rows[i].Cells[0].Value}" + "\t\t" + "-";

                    }
                }

            }
            double sumar = 0;
            for (int i = 0; dgvStock.Rows.Count > i; i++)
            {
                if (Convert.ToDouble(dgvStock.Rows[i].Cells[5].Value) > 0)
                {
                    sumar = Convert.ToDouble(dgvStock.Rows[i].Cells[7].Value) + sumar;
                }
            }
            subt = sumar;
            load += Environment.NewLine;
            load += Environment.NewLine;
            load += "Subtotal:" + "\t\t\t\t" + $"${sumar}";

            for (int i = dgvStock.Rows.Count - 2; i != -1; i--)
            {
                dgvStock.Rows[i].Cells[5].Value = "0";
            }
            SaveCellsStock();

            //Mis Servicios

            load += Environment.NewLine;
            load += "------------Mis Servicios------------";

            for (int i = 0; dgvMisServicios.Rows.Count -1 > i; i++)
            {
                if (Convert.ToDouble(dgvMisServicios.Rows[i].Cells[3].Value) > 0)
                {
                    load += Environment.NewLine;
                    stg = $@"{dgvMisServicios.Rows[i].Cells[0].Value.ToString()}:";
                    if (stg.Length <= 22)
                    {
                        load += stg + "\t\t\t" + $"${Convert.ToDouble(dgvMisServicios.Rows[i].Cells[1].Value)}";

                    }
                    else
                    {
                        load += stg + "\t\t" + $"${Convert.ToDouble(dgvMisServicios.Rows[i].Cells[1].Value)}";

                    }
                }
                else
                {
                    load += Environment.NewLine;
                    if (dgvMisServicios.Rows[i].Cells[0].Value.ToString().Length <= 22)
                    {
                        load += $"{dgvMisServicios.Rows[i].Cells[0].Value}" + "\t\t\t" + "-";

                    }
                    else
                    {
                        load += $"{dgvMisServicios.Rows[i].Cells[0].Value}" + "\t\t" + "-";
                    }
                }
            }

            sumar = 0;
            for (int i = 0; dgvMisServicios.Rows.Count > i; i++)
            {
                if (Convert.ToDouble(dgvMisServicios.Rows[i].Cells[3].Value) > 0)
                {
                    sumar = Convert.ToDouble(dgvMisServicios.Rows[i].Cells[3].Value) + sumar;
                }
            }
            subt1 = sumar;
            load += Environment.NewLine;
            load += Environment.NewLine;
            load += "Subtotal:" + "\t\t\t\t" + $"${sumar}";
            
            load += Environment.NewLine;
            load += Environment.NewLine;
            load += "Total:"+"\t\t\t\t"+$"${subt+subt1}";

            File.WriteAllText(filename, load);

            for (int i = dgvMisServicios.Rows.Count - 2; i != -1; i--)
            {
                dgvMisServicios.Rows[i].Cells[3].Value = "0";
            }
            SaveCellsMisServicios();
        }

//Menus de pantalla

       public int tabx, taby, tabh, tabw,limpx,limpy;

        private void SubMenuPedido()
        {
            if (lblServicio.Text == "▼ Servicios")
            {
                //capturar tamaño boton limpiar recepcion
                limpx = btnLimpiarRecepcion.Location.X;
                limpy = btnLimpiarRecepcion.Location.Y;

                //captura tabcontrol de las columnas
                tabx = tabControl1.Location.X;
                taby = tabControl1.Location.Y;
                tabh = tabControl1.Size.Height;
                tabw = tabControl1.Size.Width;
                if (lblPedido.Text == "▼ Pedido")
                {
                    lblPedido.Text = "► Pedido";
                    gbPedido.Visible = false;
                    lblServicio.Location = new Point(this.lblServicio.Location.X, 35);
                    gbServicios.Location = new Point(gbServicios.Location.X, 58);
                    gbMisServicios.Location = new Point(gbMisServicios.Location.X, 58);
                    
                    btnLimpiarRecepcion.Location = new Point(btnLimpiarRecepcion.Location.X, tabControl1.Location.Y - 225);
                    btnNuevoDia.Location = new Point(btnNuevoDia.Location.X, tabControl1.Location.Y - 225);
                    btnNuevoMes.Location = new Point(btnNuevoMes.Location.X, tabControl1.Location.Y - 225);

                    tabControl1.Location = new Point(0, taby - 225);
                    tabControl1.Size = new Size(tabw, tabh + 225);
                }
                else
                {
                    lblPedido.Text = "▼ Pedido";
                    gbPedido.Visible = true;

                    lblServicio.Location = new Point(lblServicio.Location.X, 261);
                    gbServicios.Location = new Point(gbServicios.Location.X, 284);
                    gbMisServicios.Location = new Point(gbMisServicios.Location.X, 284);
                    
                    btnLimpiarRecepcion.Location = new Point(btnLimpiarRecepcion.Location.X, tabControl1.Location.Y + 225);
                    btnNuevoDia.Location = new Point(btnNuevoDia.Location.X, tabControl1.Location.Y + 225);
                    btnNuevoMes.Location = new Point(btnNuevoMes.Location.X, tabControl1.Location.Y + 225);

                    tabControl1.Location = new Point(tabControl1.Location.X, taby+225);
                    tabh = tabControl1.Size.Height;
                    tabControl1.Size = new Size(tabControl1.Size.Width, tabh - 225);
                    
                }
            }
            else
            {
                //capturar tamaño boton limpiar recepcion
                limpx = btnLimpiarRecepcion.Location.X;
                limpy = btnLimpiarRecepcion.Location.Y;

                //captura tabcontrol de las columnas
                tabx = tabControl1.Location.X;
                taby = tabControl1.Location.Y;
                tabh = tabControl1.Size.Height;
                tabw = tabControl1.Size.Width;

                if (lblPedido.Text == "▼ Pedido")
                {
                    lblPedido.Text = "► Pedido";
                    gbPedido.Visible = false;
                    lblServicio.Location = new Point(lblServicio.Location.X, 35);
                    gbServicios.Location = new Point(gbServicios.Location.X, 58);
                    gbMisServicios.Location = new Point(gbMisServicios.Location.X, 58);

                    btnLimpiarRecepcion.Location = new Point(btnLimpiarRecepcion.Location.X, tabControl1.Location.Y-225);
                    btnNuevoDia.Location = new Point(btnNuevoDia.Location.X, tabControl1.Location.Y-225);
                    btnNuevoMes.Location = new Point(btnNuevoMes.Location.X, tabControl1.Location.Y-225);

                    tabControl1.Location = new Point(tabControl1.Location.X, limpy-225);
                    tabControl1.Size = new Size(tabControl1.Size.Width, tabh + 220+91);

                }
                else
                {
                    lblPedido.Text = "▼ Pedido";
                    gbPedido.Visible = true;

                    lblServicio.Location = new Point(lblServicio.Location.X, 261);
                    gbServicios.Location = new Point(gbServicios.Location.X, 284);
                    gbMisServicios.Location = new Point(gbMisServicios.Location.X, 284);
                    
                    tabControl1.Location = new Point(tabControl1.Location.X, taby+225);
                    tabh = tabControl1.Size.Height;
                    tabControl1.Size = new Size(tabControl1.Size.Width, tabh - 220+91);

                    btnLimpiarRecepcion.Location = new Point(btnLimpiarRecepcion.Location.X, tabControl1.Location.Y);
                    btnNuevoDia.Location = new Point(btnNuevoDia.Location.X, tabControl1.Location.Y);
                    btnNuevoMes.Location = new Point(btnNuevoMes.Location.X, tabControl1.Location.Y);
                }
            }

        }

        public int tabx1, taby1, tabh1, tabw1, limpx1, limpy1;
        private void SubMenuServicio()
        {
            if (lblServicio.Text == "▼ Servicios")
            {
                //capturar tamaño boton limpiar recepcion
                limpx1 = btnLimpiarRecepcion.Location.X;
                limpy1 = btnLimpiarRecepcion.Location.Y;

                //captura tabcontrol de las columnas
                tabx1 = tabControl1.Location.X;
                taby1 = tabControl1.Location.Y;
                tabh1 = tabControl1.Size.Height;
                tabw1 = tabControl1.Size.Width;
                
                lblServicio.Text = "► Servicios";
                gbServicios.Visible = false;
                gbMisServicios.Visible = false;

                tabControl1.Size = new Size(tabw1,tabh1+91);
                tabControl1.Location = new Point(tabx, taby1 - 91);

                btnLimpiarRecepcion.Location = new Point(btnLimpiarRecepcion.Location.X, tabControl1.Location.Y);
                btnNuevoDia.Location = new Point(btnNuevoDia.Location.X, tabControl1.Location.Y);
                btnNuevoMes.Location = new Point(btnNuevoMes.Location.X, tabControl1.Location.Y);
            }
            else
            {
                //capturar tamaño boton limpiar recepcion
                limpx1 = btnLimpiarRecepcion.Location.X;
                limpy1 = btnLimpiarRecepcion.Location.Y;

                //captura tabcontrol de las columnas
                tabx1 = tabControl1.Location.X;
                taby1 = tabControl1.Location.Y;
                tabh1 = tabControl1.Size.Height;
                tabw1 = tabControl1.Size.Width;

                lblServicio.Text = "▼ Servicios";
                gbServicios.Visible = true;
                gbMisServicios.Visible = true;


                tabControl1.Size = new Size(tabw1, tabh1 - 91);
                tabControl1.Location = new Point(tabx, taby1 + 91);

                btnLimpiarRecepcion.Location = new Point(btnLimpiarRecepcion.Location.X, tabControl1.Location.Y);
                btnNuevoDia.Location = new Point(btnNuevoDia.Location.X, tabControl1.Location.Y);
                btnNuevoMes.Location = new Point(btnNuevoMes.Location.X, tabControl1.Location.Y);


            }
        }


        //Objetos

      //Load y Close del Formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + $@"\File\Empleado\temp.tmp"))
            {
                if (img1 != null)
                    img1.Dispose();
                File.Delete(Application.StartupPath + $@"\File\Empleado\temp.tmp");
            }

            LoadClose();
            File.WriteAllText("Financias_Process", "true");
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Close_form();
        }
        

        //Pedidos
        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                //Eliminar columna Pedido
                if (dgvPedido.Columns[e.ColumnIndex].Name == "EliminarPedido")
                {
                    try
                    {
                        dgvPedido.Rows.Remove(dgvPedido.CurrentRow);
                        Counts();
                        SaveCells();
                    }
                    catch
                    {
                        Cancelar();
                        MessageBox.Show("No se pudo realizar la operación deseada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                //Editar columna Pedido
                if (dgvPedido.Columns[e.ColumnIndex].Name == "EditarPedido")
                {
                    try
                    {
                        btnAceptar.Text = "Guardar";
                        Edicion = true;
                        txtNombreProducto.Text = dgvPedido.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtUnidMedPedido.Text = dgvPedido.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtCantidad.Text = dgvPedido.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtPrecio.Text = dgvPedido.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtFechaPedido.Text = dgvPedido.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtFechaRecepcion.Text = dgvPedido.Rows[e.RowIndex].Cells[5].Value.ToString();
                        txtNombreProveedor.Text = dgvPedido.Rows[e.RowIndex].Cells[6].Value.ToString();
                        txtTelProveedor.Text = dgvPedido.Rows[e.RowIndex].Cells[7].Value.ToString();
                        txtDirProveedor.Text = dgvPedido.Rows[e.RowIndex].Cells[8].Value.ToString();
                        txtCodProv.Text = dgvPedido.Rows[e.RowIndex].Cells[9].Value.ToString();
                        row = e.RowIndex;
                    }
                    catch
                    {
                        Cancelar();
                        MessageBox.Show("No se pudo realizar la operación deseada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Mandar de Pedido a Recibido y Stock
                if(dgvPedido.Columns[e.ColumnIndex].Name == "PedidoRecibido")
                {
                    if (dgvPedido.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        dgvRecepcion.Rows.Add(dgvPedido.Rows[e.RowIndex].Cells[0].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[1].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[2].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[3].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[4].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[5].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[6].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[7].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[8].Value,
                                              dgvPedido.Rows[e.RowIndex].Cells[9].Value);

                        //Mandar a Stock
                        if(dgvStock.Rows.Count - 1 == 0)
                        {
                            double suma = 0;
                            //si hay Option
                            if (File.Exists(Application.StartupPath+@"\Config\Option"))
                            {
                                string[] corte = File.ReadAllText(Application.StartupPath+@"\Config\Option").Split(';');
                                double porcentaje = 0;

                                if (corte[0] == "Dolar USA")
                                {
                                    suma = Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[3].Value) * double.Parse(corte[1]);

                                    //Porcentaje de ganacia
                                    if (File.Exists(Application.StartupPath+@"\Config\Option_01"))
                                    {
                                        string nro = File.ReadAllText(Application.StartupPath+@"\Config\Option_01");
                                        double unid = suma / Convert.ToInt32(dgvPedido.Rows[e.RowIndex].Cells[2].Value);
                                        porcentaje = ( unid * double.Parse(nro) / 100) + unid;
                                    }

                                    dgvStock.Rows.Add(dgvPedido.Rows[e.RowIndex].Cells[0].Value,
                                                          dgvPedido.Rows[e.RowIndex].Cells[1].Value,
                                                          dgvPedido.Rows[e.RowIndex].Cells[2].Value,
                                                          suma, porcentaje.ToString("n2"), "0", "0","0","0");
                                }
                                else
                                {
                                    //Porcentaje de ganacia
                                    if (File.Exists(Application.StartupPath+@"\Config\Option_01"))
                                    {
                                        porcentaje = 0;
                                        string nro = File.ReadAllText(Application.StartupPath+@"\Config\Option_01");
                                        string nro2 = dgvPedido.Rows[e.RowIndex].Cells[3].Value.ToString();
                                        string nro3 = dgvPedido.Rows[e.RowIndex].Cells[2].Value.ToString();
                                        double unid = (double.Parse(nro2) / double.Parse(nro3));
                                        porcentaje = (( unid * double.Parse(nro)) / 100) + unid;
                                    }
                                    dgvStock.Rows.Add(dgvPedido.Rows[e.RowIndex].Cells[0].Value,
                                                              dgvPedido.Rows[e.RowIndex].Cells[1].Value,
                                                              dgvPedido.Rows[e.RowIndex].Cells[2].Value,
                                                              dgvPedido.Rows[e.RowIndex].Cells[3].Value,
                                                                  porcentaje.ToString("n2"), "0", "0", "0","0");
                                }
                            }
                            else
                            {
                                double porcentaje = 0;
                                    //Porcentaje de ganacia
                                    if (File.Exists(Application.StartupPath+@"\Config\Option_01"))
                                {
                                    string nro = File.ReadAllText(Application.StartupPath+@"\Config\Option_01");
                                    string nro2 = dgvPedido.Rows[e.RowIndex].Cells[3].Value.ToString();
                                    string nro3 = dgvPedido.Rows[e.RowIndex].Cells[2].Value.ToString();
                                    double unid = (double.Parse(nro2) / double.Parse(nro3));
                                    porcentaje = ((unid * double.Parse(nro)) / 100) + unid;
                                }

                                dgvStock.Rows.Add(dgvPedido.Rows[e.RowIndex].Cells[0].Value,
                                                      dgvPedido.Rows[e.RowIndex].Cells[1].Value,
                                                      dgvPedido.Rows[e.RowIndex].Cells[2].Value,
                                                      dgvPedido.Rows[e.RowIndex].Cells[3].Value,
                                                          porcentaje.ToString("n2"), "0", "0","0","0");
                            }
                        }
                        else
                        {
                            bool igual = false;
                            for (int i = 0; dgvStock.Rows.Count > i; i++)
                            {
                                if (dgvStock.Rows.Count != i && dgvStock.Rows[i].Cells[0].Value != null && dgvStock.Rows[i].Cells[1].Value != null)
                                {
                                    double valp = 0;

                                    if (dgvStock.Rows[i].Cells[0].Value.ToString() == dgvPedido.Rows[e.RowIndex].Cells[0].Value.ToString()
                                    && dgvStock.Rows[i].Cells[1].Value.ToString() == dgvPedido.Rows[e.RowIndex].Cells[1].Value.ToString())
                                    {
                                        dgvStock.Rows[i].Cells[0].Value = dgvPedido.Rows[e.RowIndex].Cells[0].Value;
                                        dgvStock.Rows[i].Cells[1].Value = dgvPedido.Rows[e.RowIndex].Cells[1].Value;
                                        double suma = Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[2].Value) + Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value);
                                        dgvStock.Rows[i].Cells[2].Value = suma.ToString();

                                        double suma1 = 0;
                                        //si hay Option
                                        if (File.Exists(Application.StartupPath+@"\Config\Option"))
                                        {
                                            string[] corte = File.ReadAllText(Application.StartupPath+@"\Config\Option").Split(';');

                                            if (corte[0] == "Dolar USA")
                                            {
                                                suma1 = (Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[3].Value) * double.Parse(corte[1])) + Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value);
                                                valp = (suma1 - Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value)) /
                                                    Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[2].Value);
                                            }
                                            else
                                                suma1 = Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[3].Value) + Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value);
                                                valp = (suma1 - Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value)) /
                                                Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[2].Value);
                                        }
                                        else
                                        {
                                            suma1 = Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[3].Value) + Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value);
                                            valp = (suma1 - Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value))/
                                                Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[2].Value);
                                        }

                                        double porcentaje = 0;

                                        //Porcentaje de ganacia
                                        if (File.Exists(Application.StartupPath+@"\Config\Option_01"))
                                        {
                                            string nro = File.ReadAllText(Application.StartupPath+@"\Config\Option_01");
                                            porcentaje = ((valp * double.Parse(nro)) / 100) + valp;
                                        }

                                        dgvStock.Rows[i].Cells[8].Value = "0";
                                        dgvStock.Rows[i].Cells[7].Value = "0";
                                        dgvStock.Rows[i].Cells[3].Value = suma1;
                                        dgvStock.Rows[i].Cells[4].Value = porcentaje.ToString("n2");
                                        igual = true;
                                        break;
                                    }
                                }
                            }

                            if (igual == false)
                            {
                                double suma = 0;
                                //si hay Option
                                if (File.Exists(Application.StartupPath+@"\Config\Option"))
                                {
                                    double porcentaje = 0;
                                    string[] corte = File.ReadAllText(Application.StartupPath+@"\Config\Option").Split(';');

                                    if (corte[0] == "Dolar USA")
                                    {
                                        suma = Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[3].Value) * double.Parse(corte[1]);

                                        //Porcentaje de ganacia
                                        if (File.Exists(Application.StartupPath+@"\Config\Option_01"))
                                        {
                                            double unid = suma/Convert.ToInt32(dgvPedido.Rows[e.RowIndex].Cells[2].Value);
                                            string nro = File.ReadAllText(Application.StartupPath+@"\Config\Option_01");
                                            porcentaje = (( unid * double.Parse(nro)) / 100) + unid;
                                        }

                                        dgvStock.Rows.Add(dgvPedido.Rows[e.RowIndex].Cells[0].Value,
                                                              dgvPedido.Rows[e.RowIndex].Cells[1].Value,
                                                              dgvPedido.Rows[e.RowIndex].Cells[2].Value,
                                                              suma, porcentaje.ToString("n2"), "0", "0","0","0");
                                    }
                                    else
                                    {
                                        //Porcentaje de ganacia
                                        if (File.Exists(Application.StartupPath+@"\Config\Option_01"))
                                        {
                                            string nro = File.ReadAllText(Application.StartupPath+@"\Config\Option_01");
                                            string nro2 = dgvPedido.Rows[e.RowIndex].Cells[3].Value.ToString();
                                            double unid = Convert.ToDouble(nro2) / Convert.ToDouble(dgvPedido.Rows[e.RowIndex].Cells[2].Value);
                                            porcentaje = ((unid * double.Parse(nro)) / 100) + unid;
                                        }
                                        dgvStock.Rows.Add(dgvPedido.Rows[e.RowIndex].Cells[0].Value,
                                                                  dgvPedido.Rows[e.RowIndex].Cells[1].Value,
                                                                  dgvPedido.Rows[e.RowIndex].Cells[2].Value,
                                                                  dgvPedido.Rows[e.RowIndex].Cells[3].Value,
                                                                      porcentaje.ToString("n2"), "0", "0","0","0");
                                    }
                                }
                                else
                                {
                                    double porcentaje = 0;
                                    //Porcentaje de ganacia
                                    if (File.Exists(Application.StartupPath+@"\Config\Option_01"))
                                    {
                                        string nro = File.ReadAllText(Application.StartupPath+@"\Config\Option_01");
                                        string nro2 = dgvPedido.Rows[e.RowIndex].Cells[3].Value.ToString();
                                        double unid = Convert.ToInt32(nro2) / Convert.ToInt32(dgvPedido.Rows[e.RowIndex].Cells[2].Value);
                                        porcentaje = ((unid * double.Parse(nro)) / 100) + unid;
                                    }
                                    dgvStock.Rows.Add(dgvPedido.Rows[e.RowIndex].Cells[0].Value,
                                                          dgvPedido.Rows[e.RowIndex].Cells[1].Value,
                                                          dgvPedido.Rows[e.RowIndex].Cells[2].Value,
                                                          dgvPedido.Rows[e.RowIndex].Cells[3].Value,
                                                              porcentaje.ToString("n2"), "0", "0", "0","0");
                                }
                            }
                        }

                        //Elimina la columna y lo guarda
                        dgvPedido.Rows.Remove(dgvPedido.CurrentRow);
                        Counts();
                        SaveCellsReception();
                        SaveCellsStock();
                        SaveCells();

                    }
                    else
                    {
                        Cancelar();
                        MessageBox.Show("No se pudo realizar la operación deseada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
         //Recepcion
        private void dgvRecepcion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {

                    //Cancelar Recibido y mandar a Pedido
                    if (dgvRecepcion.Columns[e.ColumnIndex].Name == "CancelarRecibido")
                    {
                        bool venta = false;
                        double nroventa = 0;
                        for (int i = 0; dgvStock.Rows.Count > i; i++)
                        {
                            if (dgvStock.Rows.Count != i && dgvStock.Rows[i].Cells[0].Value != null && dgvStock.Rows[i].Cells[1].Value != null)
                            {
                                if (dgvStock.Rows[i].Cells[0].Value.ToString() == dgvRecepcion.Rows[e.RowIndex].Cells[0].Value.ToString()
                                && dgvStock.Rows[i].Cells[1].Value.ToString() == dgvRecepcion.Rows[e.RowIndex].Cells[1].Value.ToString())
                                {
                                    if(Convert.ToDouble(dgvStock.Rows[i].Cells[6].Value) > 0)
                                    {
                                        nroventa = Convert.ToDouble(dgvStock.Rows[i].Cells[6].Value);
                                        venta = true;
                                        break;
                                    }
                                }
                            }
                        }
                        if (dgvRecepcion.Rows[e.RowIndex].Cells[0].Value != null && venta == false)
                        {
                            dgvPedido.Rows.Add(dgvRecepcion.Rows[e.RowIndex].Cells[0].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[1].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[2].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[3].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[4].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[5].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[6].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[7].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[8].Value,
                                                  dgvRecepcion.Rows[e.RowIndex].Cells[9].Value);

                            //Sacar de Stock
                                for (int i = 0; dgvStock.Rows.Count > i; i++)
                                {
                                    if (dgvStock.Rows.Count != i && dgvStock.Rows[i].Cells[0].Value != null && dgvStock.Rows[i].Cells[1].Value != null)
                                    {
                                        if (dgvStock.Rows[i].Cells[0].Value.ToString() == dgvRecepcion.Rows[e.RowIndex].Cells[0].Value.ToString()
                                        && dgvStock.Rows[i].Cells[1].Value.ToString() == dgvRecepcion.Rows[e.RowIndex].Cells[1].Value.ToString())
                                        {
                                            dgvStock.Rows[i].Cells[0].Value = dgvRecepcion.Rows[e.RowIndex].Cells[0].Value;
                                            dgvStock.Rows[i].Cells[1].Value = dgvRecepcion.Rows[e.RowIndex].Cells[1].Value;
                                            double resta = Convert.ToDouble(dgvStock.Rows[i].Cells[2].Value) - Convert.ToDouble(dgvRecepcion.Rows[e.RowIndex].Cells[2].Value);
                                            dgvStock.Rows[i].Cells[2].Value = resta;

                                        double resta1 = 0;
                                        //si hay Option
                                        if (File.Exists(Application.StartupPath+@"\Config\Option"))
                                        {
                                            string[] corte = File.ReadAllText(Application.StartupPath+@"\Config\Option").Split(';');

                                            if (corte[0] == "Dolar USA")
                                            {
                                                resta1 = Convert.ToDouble(dgvRecepcion.Rows[e.RowIndex].Cells[3].Value) * double.Parse(corte[1]);
                                                resta1 = Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value) - resta1;
                                            }
                                            else
                                                resta1 = Convert.ToDouble(dgvRecepcion.Rows[e.RowIndex].Cells[3].Value) - Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value);
                                        }
                                        else
                                        {
                                            resta1 = Convert.ToDouble(dgvRecepcion.Rows[e.RowIndex].Cells[3].Value) - Convert.ToDouble(dgvStock.Rows[i].Cells[3].Value);
                                        }
                                        dgvStock.Rows[i].Cells[3].Value = resta1;
                                        break;
                                        }
                                    }
                                }

                            //Elimina la columna y lo guarda
                            dgvRecepcion.Rows.Remove(dgvRecepcion.CurrentRow);
                            Counts();
                            ComprobarLimpiarRecepcion();
                            SaveCellsReception();
                            SaveCellsStock();
                            SaveCells();

                        }
                        else
                        {
                            if(venta == true)
                            {
                                MessageBox.Show($"Usted ya ha realizado {nroventa} ventas, y no se ha podido realizar la operacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("No se pudo realizar la operación deseada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch
            {

            }

        }


        //Stock
        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ColorCellsStock();
        }

        private void dgvStock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveCellsStock();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {

                //Eliminar columna Pedido
                if (dgvStock.Columns[e.ColumnIndex].Name == "StockEliminar")
                {
                    try
                    {
                        dgvStock.Rows.Remove(dgvStock.CurrentRow);
                        Counts();
                        SaveCellsStock();
                        if (dgvStock.Rows.Count - 1 == 0)
                        {
                            btnNuevoDia.Enabled = false;
                            btnNuevoMes.Enabled = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo realizar la operación deseada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (dgvStock.Columns[e.ColumnIndex].Name == "VenderStock")
                {
                    if (dgvStock.Rows[e.RowIndex].Cells[2].Value != null)
                    {
                        if (Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[6].Value) >= 0
                            && Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[2].Value) > 0)
                        {
                            double suma = 0, resta = 0;

                            resta = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[2].Value) - 1;
                            dgvStock.Rows[e.RowIndex].Cells[2].Value = resta.ToString();

                            suma = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[5].Value) + 1;
                            dgvStock.Rows[e.RowIndex].Cells[5].Value = suma.ToString();

                            suma = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[6].Value) + 1;
                            dgvStock.Rows[e.RowIndex].Cells[6].Value = suma.ToString();

                            suma = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[4].Value) +
                                Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[7].Value);
                            dgvStock.Rows[e.RowIndex].Cells[7].Value = suma.ToString();

                            suma = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[4].Value) +
                                Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[8].Value);
                            dgvStock.Rows[e.RowIndex].Cells[8].Value = suma.ToString();

                            SaveCellsStock();
                        }
                    }
                    else
                        MessageBox.Show("No se pudo realizar la operación deseada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (dgvStock.Columns[e.ColumnIndex].Name == "CancelarVentaStock")
                {
                    if (dgvStock.Rows[e.RowIndex].Cells[2].Value != null)
                    {
                        if (Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[6].Value) > 0
                            && Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[2].Value) >= 0)
                        {
                            double suma = 0, resta = 0;

                            suma = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[2].Value) + 1;
                            dgvStock.Rows[e.RowIndex].Cells[2].Value = suma.ToString();

                            resta = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[6].Value) - 1;
                            dgvStock.Rows[e.RowIndex].Cells[6].Value = resta.ToString();

                            if (Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[5].Value) > 0)
                            {
                                resta = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[5].Value) - 1;
                                dgvStock.Rows[e.RowIndex].Cells[5].Value = resta.ToString();
                            }

                            if (Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[7].Value) > 0)
                            {
                                suma = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[7].Value) -
                                Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[4].Value);
                                dgvStock.Rows[e.RowIndex].Cells[7].Value = suma.ToString();
                            }

                            if (Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[8].Value) > 0)
                            {
                                suma = Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[8].Value) -
                                Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[4].Value);
                                dgvStock.Rows[e.RowIndex].Cells[8].Value = suma.ToString();
                            }

                            SaveCellsStock();
                        }
                    }
                }
            }
        }
        
        //Servicios
        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (dgvServicios.Columns[e.ColumnIndex].Name == "EliminarServicio")
                {
                    if (dgvServicios.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        dgvServicios.Rows.Remove(dgvServicios.CurrentRow);
                        Counts();
                        SaveCellsServicios();
                    }
                    else
                        MessageBox.Show("No se pudo realizar la operación deseada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (dgvServicios.Columns[e.ColumnIndex].Name == "EditarServicios")
                {
                    txtNombreServicio.Text = dgvServicios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtAbonarServicio.Text = dgvServicios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtfechaVencimiento.Text = dgvServicios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    btnAceptarServicio.Text = "Guardar";
                    EdicionServicio = true;
                    rowservicio = e.RowIndex;
                }
            }
        }

        // Mis Servicios
        private void dgvMisServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex < dgvMisServicios.Rows.Count-1 && e.RowIndex > -1)
            {
                if (dgvMisServicios.Columns[e.ColumnIndex].Name == "EliminarMisServicios")
                {
                    dgvMisServicios.Rows.RemoveAt(e.RowIndex);
                    SaveCellsMisServicios();
                    Counts();
                }

                if (dgvMisServicios.Columns[e.ColumnIndex].Name == "EditarMisServicios")
                {
                    rowMiServicio = e.RowIndex;
                    txtNombreMisServicios.Text = dgvMisServicios.Rows[rowMiServicio].Cells[0].Value.ToString();
                    txtValorMisServicios.Text = dgvMisServicios.Rows[rowMiServicio].Cells[1].Value.ToString();
                    btnAceptarMisServis.Text = "Guardar";
                    EdicionMisServicios = true;
                }

                if (dgvMisServicios.Columns[e.ColumnIndex].Name == "MisServisVender")
                {
                    double op = Convert.ToInt32(dgvMisServicios.Rows[e.RowIndex].Cells[1].Value),
                        op1 = Convert.ToInt32(dgvMisServicios.Rows[e.RowIndex].Cells[3].Value),
                        op2 = Convert.ToInt32(dgvMisServicios.Rows[e.RowIndex].Cells[4].Value);

                    dgvMisServicios.Rows[e.RowIndex].Cells[2].Value =
                        (Convert.ToDouble(dgvMisServicios.Rows[e.RowIndex].Cells[2].Value) + 1).ToString();

                    dgvMisServicios.Rows[e.RowIndex].Cells[3].Value =
                        (op1 + op).ToString();

                    dgvMisServicios.Rows[e.RowIndex].Cells[4].Value =
                        (op2 + op).ToString();

                    SaveCellsMisServicios();
                }

                if (dgvMisServicios.Columns[e.ColumnIndex].Name == "MisServisNoVender")
                {
                    double op = Convert.ToInt32(dgvMisServicios.Rows[e.RowIndex].Cells[2].Value),
                        op1 = Convert.ToInt32(dgvMisServicios.Rows[e.RowIndex].Cells[3].Value),
                        op2 = Convert.ToInt32(dgvMisServicios.Rows[e.RowIndex].Cells[1].Value),
                        op3 = Convert.ToInt32(dgvMisServicios.Rows[e.RowIndex].Cells[4].Value);

                    if (op > 0 && op1 > 0)
                    {
                        dgvMisServicios.Rows[e.RowIndex].Cells[2].Value =
                            (op - 1).ToString();
                        dgvMisServicios.Rows[e.RowIndex].Cells[3].Value =
                            (op1 - op2).ToString();

                        op1 = Convert.ToDouble(dgvMisServicios.Rows[e.RowIndex].Cells[3].Value);

                        dgvMisServicios.Rows[e.RowIndex].Cells[4].Value =
                            (op3 - op2).ToString();

                        if (op1 < 0)
                            dgvMisServicios.Rows[e.RowIndex].Cells[3].Value = "0";

                        SaveCellsMisServicios();
                    }
                }
            }
        }

        private void btnIniSesion_Click(object sender, EventArgs e)
        {
            frmInicioAdmin adm = new frmInicioAdmin();
            adm.Visible = true;
        }

        //tabcontrol
        private void tabControl1_Click(object sender, EventArgs e)
        {
            ComprobarLimpiarRecepcion();
        }

        //Precio por unidad
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkUnidad.Checked)
            {
                txtPrecioUnidad.Enabled = true;
                txtPrecio.Enabled = false;
                txtPrecio.Text = "";
            }
            else
            {
                txtPrecioUnidad.Enabled = false;
                txtPrecio.Enabled = true;
                txtPrecioUnidad.Text = "";
            }
        }


        //Subs menu
        private void lblPedido_Click(object sender, EventArgs e)
        {
            SubMenuPedido();
        }

        private void lblServicio_Click(object sender, EventArgs e)
        {
            SubMenuServicio();
        }


        private void btnLimpiarRecepcion_Click(object sender, EventArgs e)
        {
            LimpiarRecepcion();
        }


        //botones 
        private void txtFechaPedido_Click(object sender, EventArgs e)
        {
            FechaForm();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }


        private void btnAceptarServicio_Click(object sender, EventArgs e)
        {
            AceptarServicio();
        }


        private void btnCancelarServicio_Click(object sender, EventArgs e)
        {
            CancelarServicio();
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\Config\IO.dat"))
            {
                frmCorroborarContra f = new frmCorroborarContra();
                f.Visible = true;
            }
            else
            {
                frmEmpleados f = new frmEmpleados();
                f.Visible = true;
            }
        }

        private void cbNombreTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageNombreEmpleado();
        }
        private void Buscador(char c)
        {
            string letra = c.ToString(), txt1 = txtBuscar.Text;

            if (letra == "a" || letra == "b" || letra == "c" || letra == "d" || letra == "e"
                || letra == "f" || letra == "g" || letra == "h" || letra == "i" || letra == "j"
                || letra == "k" || letra == "l" || letra == "m" || letra == "n" || letra == "o"
                || letra == "p" || letra == "q" || letra == "r" || letra == "s" || letra == "t"
                || letra == "u" || letra == "v" || letra == "w" || letra == "x" || letra == "y"
                || letra == "z" || letra == " " || letra == "!" || letra == "?" || letra == "¿"

                || letra == "¡" || letra == "." || letra == "," || letra == "-" || letra == "_"
                || letra == "\r" || letra == ":" || letra == ";" || letra == "=" || letra == "("
                || letra == ")" || letra == "$" || letra == "%" || letra == "·" || letra == "#"
                || letra == "|" || letra == "/" || letra == "\\" || letra == "&" || letra == "¬"
                || letra == "^" || letra == "*" || letra == "+" || letra == "¨" || letra == "{"
                || letra == "}" || letra == "º" || letra == "ª" || letra == "´" || letra == "'"
                || letra == "[" || letra == "]" || letra == "ç" || letra == "Ç" || letra == "@"

                || letra == "\"" || letra == ">" || letra == "<" || letra == "`"
                || letra == "A" || letra == "B" || letra == "C" || letra == "D" || letra == "E"
                || letra == "F" || letra == "G" || letra == "H" || letra == "I" || letra == "J"
                || letra == "K" || letra == "L" || letra == "M" || letra == "N" || letra == "O"
                || letra == "P" || letra == "Q" || letra == "R" || letra == "S" || letra == "T"
                || letra == "U" || letra == "V" || letra == "W" || letra == "X" || letra == "Y"
                || letra == "Z"

                || letra == "1" || letra == "2" || letra == "3" || letra == "4" || letra == "5"
                || letra == "6" || letra == "7" || letra == "8" || letra == "9" || letra == "0")
            {
                txt1 += letra;
            }
            else if (letra == "\b" && txtBuscar.TextLength >= 1)
            {
                txt1 = txt1.Substring(0, txt1.Length - 1);
            }
            else if (letra == "\t" && txtBuscar.TextLength >= 1)
            {
                txtBuscar.Clear();
                txt1 = "";
            }

            if (tabControl1.SelectedIndex == 0)
            {
                for (int i = 0; dgvPedido.Rows.Count - 1 > i; i++)
                {
                    string valor = dgvPedido.Rows[i].Cells[0].Value.ToString();
                    if (txt1.Length <= valor.Length)
                    {
                        if (txt1 == valor.Substring(0, txt1.Length))
                            dgvPedido.Rows[i].Visible = true;
                        else
                            dgvPedido.Rows[i].Visible = false;
                    }
                    else
                        dgvPedido.Rows[i].Visible = false;
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                for (int i = 0; dgvRecepcion.Rows.Count - 1 > i; i++)
                {
                    string valor = dgvRecepcion.Rows[i].Cells[0].Value.ToString();
                    if (txt1.Length <= valor.Length)
                    {
                        if (txt1 == valor.Substring(0, txt1.Length))
                            dgvRecepcion.Rows[i].Visible = true;
                        else
                            dgvRecepcion.Rows[i].Visible = false;
                    }
                    else
                        dgvRecepcion.Rows[i].Visible = false;
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                for (int i = 0; dgvStock.Rows.Count - 1 > i; i++)
                {
                    string valor = dgvStock.Rows[i].Cells[0].Value.ToString();
                    if (txt1.Length <= valor.Length)
                    {
                        if (txt1 == valor.Substring(0, txt1.Length))
                            dgvStock.Rows[i].Visible = true;
                        else
                            dgvStock.Rows[i].Visible = false;
                    }
                    else
                        dgvStock.Rows[i].Visible = false;
                }
            }
            if (tabControl1.SelectedIndex == 3)
            {
                for (int i = 0; dgvServicios.Rows.Count - 1 > i; i++)
                {
                    string valor = dgvServicios.Rows[i].Cells[0].Value.ToString();
                    if (txt1.Length <= valor.Length)
                    {
                        if (txt1 == valor.Substring(0, txt1.Length))
                            dgvServicios.Rows[i].Visible = true;
                        else
                            dgvServicios.Rows[i].Visible = false;
                    }
                    else
                        dgvServicios.Rows[i].Visible = false;
                }
            }
            if (tabControl1.SelectedIndex == 4)
            {
                for (int i = 0; dgvMisServicios.Rows.Count - 1 > i; i++)
                {
                    string valor = dgvMisServicios.Rows[i].Cells[0].Value.ToString();
                    if (txt1.Length <= valor.Length)
                    {
                        if (txt1 == valor.Substring(0, txt1.Length))
                            dgvMisServicios.Rows[i].Visible = true;
                        else
                            dgvMisServicios.Rows[i].Visible = false;
                    }
                    else
                        dgvMisServicios.Rows[i].Visible = false;
                }
            }

            if (txt1.Length >= 1)
            {
                btnBuscar.Visible = true;
            }
            else
            {
                btnBuscar.Visible = false;
            }
        }

        private void EliminarBuscador()
        {
            Buscador('\t');
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buscador(e.KeyChar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EliminarBuscador();
        }

        private void btnAceptarMisServis_Click(object sender, EventArgs e)
        {
            AceptarMisServicio();
        }

        private void btnCancelarMisServis_Click(object sender, EventArgs e)
        {
            CancelarMisServicios();
        }

        private void btnNuevoDia_Click(object sender, EventArgs e)
        {
            NuevoDia();
        }

        private void btnNuevoMes_Click(object sender, EventArgs e)
        {
            NuevoMes();
        }

        private void btnPreferencia_Click(object sender, EventArgs e)
        {
            frmPrefencias frm = new frmPrefencias();
            frm.Visible = true;
        }

        public bool lic = false;
        private void btnLicencia_Click(object sender, EventArgs e)
        {
            frmLicencia l = new frmLicencia();
            l.Visible = true;
            lic = true;
        }
        private void btnContraseña_Click(object sender, EventArgs e)
        {
            frmContraseña c = new frmContraseña();
            c.Visible = true;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPanel();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPanel();
        }

        //perfil
        private void pbePerfil_DoubleClick(object sender, EventArgs e)
        {
            ImageEclipseBox();
        }
        private void lblNomPerfil_Click(object sender, EventArgs e)
        {
            lblNomPerfil.Visible = false;
            txtNomPerfil.Visible = true;
            btnNomPerfilAcep.Visible = true;
            btnNomPerfilCance.Visible = true;
            txtNomPerfil.Text = lblNomPerfil.Text;
            txtNomPerfil.Focus();
            txtNomPerfil.SelectAll();
        }
        private void btnNomPerfilAcep_Click(object sender, EventArgs e)
        {
            AceptNomPerf();
        }
        private void txtNomPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                AceptNomPerf();
            }
        }

        private void btnNomPerfilCance_Click(object sender, EventArgs e)
        {
            txtNomPerfil.Text = "";
            lblNomPerfil.Visible = true;
            txtNomPerfil.Visible = false;
            lblNomPerfil.Visible = true;
            txtNomPerfil.Visible = false;
            btnNomPerfilCance.Visible = false;
            btnNomPerfilAcep.Visible = false;
        }
    }
}
