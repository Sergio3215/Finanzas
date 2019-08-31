namespace Financias
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.NombreEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntiguedadEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargoEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbCargos = new System.Windows.Forms.ComboBox();
            this.pbPerfilEmpleado = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 53);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(245, 132);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(292, 53);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(445, 53);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(33, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Año de ingreso";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(304, 93);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(54, 20);
            this.txtAño.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(411, 93);
            this.txtSueldo.MaxLength = 20;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(67, 20);
            this.txtSueldo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gestión de Empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEmple,
            this.ApellidoEmple,
            this.EdadEmple,
            this.AñoIngreso,
            this.AntiguedadEmple,
            this.CargoEmple,
            this.SueldEmple,
            this.Editar,
            this.Eliminar});
            this.dgvEmpleados.Location = new System.Drawing.Point(2, 156);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(548, 186);
            this.dgvEmpleados.TabIndex = 8;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // NombreEmple
            // 
            this.NombreEmple.HeaderText = "Nombre";
            this.NombreEmple.Name = "NombreEmple";
            this.NombreEmple.ReadOnly = true;
            this.NombreEmple.Width = 50;
            // 
            // ApellidoEmple
            // 
            this.ApellidoEmple.HeaderText = "Apellido";
            this.ApellidoEmple.Name = "ApellidoEmple";
            this.ApellidoEmple.ReadOnly = true;
            this.ApellidoEmple.Width = 50;
            // 
            // EdadEmple
            // 
            this.EdadEmple.HeaderText = "Edad";
            this.EdadEmple.MaxInputLength = 2;
            this.EdadEmple.Name = "EdadEmple";
            this.EdadEmple.ReadOnly = true;
            this.EdadEmple.Width = 35;
            // 
            // AñoIngreso
            // 
            this.AñoIngreso.HeaderText = "Año de Ingreso";
            this.AñoIngreso.Name = "AñoIngreso";
            this.AñoIngreso.ReadOnly = true;
            this.AñoIngreso.Width = 50;
            // 
            // AntiguedadEmple
            // 
            this.AntiguedadEmple.HeaderText = "Antiguedad";
            this.AntiguedadEmple.MaxInputLength = 2;
            this.AntiguedadEmple.Name = "AntiguedadEmple";
            this.AntiguedadEmple.ReadOnly = true;
            this.AntiguedadEmple.Width = 60;
            // 
            // CargoEmple
            // 
            this.CargoEmple.HeaderText = "Cargo";
            this.CargoEmple.Name = "CargoEmple";
            this.CargoEmple.ReadOnly = true;
            this.CargoEmple.Width = 75;
            // 
            // SueldEmple
            // 
            this.SueldEmple.HeaderText = "Sueldo";
            this.SueldEmple.Name = "SueldEmple";
            this.SueldEmple.ReadOnly = true;
            this.SueldEmple.Width = 75;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 60;
            // 
            // cbCargos
            // 
            this.cbCargos.FormattingEnabled = true;
            this.cbCargos.Items.AddRange(new object[] {
            "Dueño/a",
            "Empleado/a"});
            this.cbCargos.Location = new System.Drawing.Point(125, 93);
            this.cbCargos.Name = "cbCargos";
            this.cbCargos.Size = new System.Drawing.Size(85, 21);
            this.cbCargos.TabIndex = 3;
            this.cbCargos.Text = "(Seleccione)";
            // 
            // pbPerfilEmpleado
            // 
            this.pbPerfilEmpleado.Image = global::Financias.Properties.Resources.usuario_perfil_oculto;
            this.pbPerfilEmpleado.Location = new System.Drawing.Point(12, 46);
            this.pbPerfilEmpleado.Name = "pbPerfilEmpleado";
            this.pbPerfilEmpleado.Size = new System.Drawing.Size(67, 67);
            this.pbPerfilEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerfilEmpleado.TabIndex = 6;
            this.pbPerfilEmpleado.TabStop = false;
            this.pbPerfilEmpleado.DoubleClick += new System.EventHandler(this.pbPerfilEmpleado_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Foto de Perfil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "(Doble click para seleccionar)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 340);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbPerfilEmpleado);
            this.Controls.Add(this.cbCargos);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpleados_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.ComboBox cbCargos;
        private System.Windows.Forms.PictureBox pbPerfilEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntiguedadEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargoEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldEmple;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}