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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            EmpleadosLoad();
        }
        public Image img;
        public bool edit = false, listedit = false;
        public int rows = 0;
        public string nombreviejo = "", apellidoviejo = "";

        private void EmpleadosLoad()
        {
            if(File.Exists(Application.StartupPath + @"\File\Data_2"))
            {
                string[] linea = File.ReadAllLines(Application.StartupPath + @"\File\Data_2");
                for(int i=0; linea.Count() >i;i++)
                {
                    string[] corte = linea[i].Split(';');
                    dgvEmpleados.Rows.Add(corte[0],corte[1],corte[2],corte[3],corte[4],corte[5],corte[6]);
                }
            }
        }

        private void EmpleadosSave()
        {
            List<string> list = new List<string>();

            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                string linea = "";

                if (dgvEmpleados.Rows.Count - 1 == row.Index)
                    break;
                foreach(DataGridViewCell cells in row.Cells)
                {
                    if (cells == null)
                        linea += " ";
                    else
                        linea += cells.Value.ToString();
                    linea += ";";
                }
                list.Add(linea.TrimEnd(';'));
                if (File.Exists(Application.StartupPath + @"\File\Data_2"))
                    File.Delete(Application.StartupPath + @"\File\Data_2");
                File.WriteAllLines(Application.StartupPath + @"\File\Data_2",list);
            }
        }

        private int CalcularAño(int n1)
        {
            int n2 = 0;
            
            if (txtAño.TextLength == 2)
                n2 = int.Parse(DateTime.Now.ToString("yy"));
            if (txtAño.TextLength == 3)
                n2 = int.Parse(DateTime.Now.ToString("yyy"));
            if (txtAño.TextLength == 4)
                n2 = int.Parse(DateTime.Now.ToString("yyyy"));

            n1 = n2-n1;

            return n1;
        }

        private void Aceptar()
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtAño.Text != "" && txtSueldo.Text != "")
            {
                if (edit == true)
                {
                    dgvEmpleados.Rows[rows].Cells[0].Value = txtNombre.Text;
                    dgvEmpleados.Rows[rows].Cells[1].Value = txtApellido.Text;
                    dgvEmpleados.Rows[rows].Cells[2].Value = txtEdad.Text;
                    dgvEmpleados.Rows[rows].Cells[3].Value = txtAño.Text;
                    dgvEmpleados.Rows[rows].Cells[4].Value = CalcularAño(int.Parse(txtAño.Text));
                    dgvEmpleados.Rows[rows].Cells[5].Value = cbCargos.Text;
                    dgvEmpleados.Rows[rows].Cells[6].Value = double.Parse(txtSueldo.Text).ToString("c2");

                    File.Delete(Application.StartupPath + $@"\File\Empleado\{nombreviejo} {apellidoviejo}\Perfil.jpg");
                    Directory.Delete(Application.StartupPath + $@"\File\Empleado\{nombreviejo} {apellidoviejo}");

                    DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + $@"\File\Empleado\{txtNombre.Text} {txtApellido.Text}");
                    dir.Create();
                    dir.Attributes = FileAttributes.Hidden;

                    pbPerfilEmpleado.Image.Save(Application.StartupPath + $@"\File\Empleado\{txtNombre.Text} {txtApellido.Text}\Perfil.jpg");
                    img.Dispose();
                    if (File.Exists(Application.StartupPath + $@"\File\Empleado\tmp.jpg"))
                    {
                        File.Delete(Application.StartupPath + $@"\File\Empleado\tmp.jpg");
                    }
                    File.Delete(Application.StartupPath + $@"\File\Empleado\image.tmp");

                    Cancelar();
                    EmpleadosSave();
                }
                else
                {
                    dgvEmpleados.Rows.Add(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtAño.Text,
                    CalcularAño(int.Parse(txtAño.Text)), cbCargos.Text, double.Parse(txtSueldo.Text).ToString("c2"));

                    if (!Directory.Exists(Application.StartupPath + $@"\File\Empleado\{txtNombre.Text} {txtApellido.Text}"))
                    {
                        DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + $@"\File\Empleado\{txtNombre.Text} {txtApellido.Text}");
                        dir.Create();
                        dir.Attributes = FileAttributes.Hidden;
                    }
                    pbPerfilEmpleado.Image.Save(Application.StartupPath + $@"\File\Empleado\{txtNombre.Text} {txtApellido.Text}\Perfil.jpg");
                    if (File.Exists(Application.StartupPath + $@"\File\Empleado\tmp.jpg"))
                    {
                        img.Dispose();
                        File.Delete(Application.StartupPath + $@"\File\Empleado\tmp.jpg");
                    }
                    Cancelar();
                    EmpleadosSave();
                }
                Close();
                Application.Restart();
            }
            else
            {
                    MessageBox.Show("Hay espacios en blanco");
            }
        }

        private void Cancelar()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtAño.Text = "";
            txtApellido.Text = "";
            txtSueldo.Text = "";
            cbCargos.Text = "(Seleccione)";
            pbPerfilEmpleado.Image = Image.FromFile(Application.StartupPath + $@"\File\Empleado\usuario perfil oculto.jpg");
            btnAceptar.Text = "Aceptar";
            edit = false;
            rows = 0;
            nombreviejo = "";
            apellidoviejo = "";
        }

        private void imagecharging()
        {
            if (File.Exists(Application.StartupPath + $@"\File\Empleado\image.tmp"))
            {
                img.Dispose();
                File.Delete(Application.StartupPath + $@"\File\Empleado\image.tmp");
            }
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ConversorFoto c = new ConversorFoto();
                img = c.CambiarTamañoImagen(Image.FromFile(openFileDialog1.FileName),200);
                img.Save(Application.StartupPath + $@"\File\Empleado\tmp.jpg");
                pbPerfilEmpleado.Image = img;
            }

        }


        private void pbPerfilEmpleado_DoubleClick(object sender, EventArgs e)
        {
            imagecharging();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                File.WriteAllText(Application.StartupPath + @"\File\mod", "");

                File.Delete(Application.StartupPath + $@"\File\Empleado\{dgvEmpleados.Rows[e.RowIndex].Cells[0].Value} {dgvEmpleados.Rows[e.RowIndex].Cells[1].Value}\Perfil.jpg");
                Directory.Delete(Application.StartupPath + $@"\File\Empleado\{dgvEmpleados.Rows[e.RowIndex].Cells[0].Value} {dgvEmpleados.Rows[e.RowIndex].Cells[1].Value}");
                dgvEmpleados.Rows.RemoveAt(e.RowIndex);
                EmpleadosSave();
                EmpleadoCount();
            }
            if(dgvEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                if(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(0,2) == "\r\n")
                    txtNombre.Text = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(2);
                else
                    txtNombre.Text = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtApellido.Text = dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEdad.Text = dgvEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAño.Text = dgvEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbCargos.Text = dgvEmpleados.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSueldo.Text = dgvEmpleados.Rows[e.RowIndex].Cells[6].Value.ToString().Substring(1);

                if (File.Exists(Application.StartupPath + $@"\File\Empleado\image.tmp"))
                {
                    if (img != null)
                        img.Dispose();
                    File.Delete(Application.StartupPath + $@"\File\Empleado\image.tmp");
                }

                img = Image.FromFile(Application.StartupPath + $@"\File\Empleado\{txtNombre.Text} {txtApellido.Text}\Perfil.jpg");
                img.Save(Application.StartupPath + $@"\File\Empleado\image.tmp");
                img.Dispose();
                img = Image.FromFile(Application.StartupPath + $@"\File\Empleado\image.tmp");
                
                pbPerfilEmpleado.Image = img;
                nombreviejo = txtNombre.Text;
                apellidoviejo = txtApellido.Text;
                rows = e.RowIndex;
                btnAceptar.Text = "Guardar";
                edit = true;
            }
        }

        private void frmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            EliminircbNombreTrabj();
        }

        private void EliminircbNombreTrabj()
        {
            if(File.Exists(Application.StartupPath+@"\File\mod"))
            {
                File.Delete(Application.StartupPath + @"\File\mod");
                Application.Restart();
            }
        }

        private void EmpleadoCount()
        {
            if (dgvEmpleados.Rows.Count - 1 == 0)
            {
                File.Delete(Application.StartupPath + @"\File\Data_2");
                Application.Restart();
            }
        }
    }
}
