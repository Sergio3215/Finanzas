namespace Financias
{
    partial class frmSuscripción
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuscripción));
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdmAcc = new System.Windows.Forms.Button();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaGlobal = new System.Windows.Forms.Label();
            this.trFecha = new System.Windows.Forms.Timer(this.components);
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnModoPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(63, 75);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(53, 20);
            this.txtAño.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Años";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(132, 120);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Establecimiento de Suscripción";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(142, 75);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(53, 20);
            this.txtMes.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(139, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meses";
            // 
            // btnAdmAcc
            // 
            this.btnAdmAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmAcc.Location = new System.Drawing.Point(12, 162);
            this.btnAdmAcc.Name = "btnAdmAcc";
            this.btnAdmAcc.Size = new System.Drawing.Size(122, 23);
            this.btnAdmAcc.TabIndex = 2;
            this.btnAdmAcc.Text = "Modo Administrador";
            this.btnAdmAcc.UseVisualStyleBackColor = true;
            this.btnAdmAcc.Click += new System.EventHandler(this.btnAdmAcc_Click);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(218, 75);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(53, 20);
            this.txtDias.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(215, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(69, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha y Hora Actual";
            // 
            // lblFechaGlobal
            // 
            this.lblFechaGlobal.AutoSize = true;
            this.lblFechaGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGlobal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaGlobal.Location = new System.Drawing.Point(55, 247);
            this.lblFechaGlobal.Name = "lblFechaGlobal";
            this.lblFechaGlobal.Size = new System.Drawing.Size(251, 25);
            this.lblFechaGlobal.TabIndex = 1;
            this.lblFechaGlobal.Text = "dd/MM/yyyy HH:mm:ss";
            // 
            // trFecha
            // 
            this.trFecha.Tick += new System.EventHandler(this.trFecha_Tick);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(116, 280);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(114, 23);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.Text = "Restaurar Hora";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnModoPrueba
            // 
            this.btnModoPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModoPrueba.Location = new System.Drawing.Point(214, 162);
            this.btnModoPrueba.Name = "btnModoPrueba";
            this.btnModoPrueba.Size = new System.Drawing.Size(126, 23);
            this.btnModoPrueba.TabIndex = 4;
            this.btnModoPrueba.Text = "Modo de Prueba";
            this.btnModoPrueba.UseVisualStyleBackColor = true;
            this.btnModoPrueba.Click += new System.EventHandler(this.btnModoPrueba_Click);
            // 
            // frmSuscripción
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 313);
            this.Controls.Add(this.btnModoPrueba);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnAdmAcc);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFechaGlobal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAño);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSuscripción";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdmAcc;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechaGlobal;
        private System.Windows.Forms.Timer trFecha;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnModoPrueba;
    }
}