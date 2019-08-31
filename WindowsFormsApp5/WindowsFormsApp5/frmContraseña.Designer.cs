namespace Financias
{
    partial class frmContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContraseña));
            this.lblAntiguaContra = new System.Windows.Forms.Label();
            this.txtAnti = new System.Windows.Forms.TextBox();
            this.lblNuevaContra = new System.Windows.Forms.Label();
            this.txtNue = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAcept = new System.Windows.Forms.Button();
            this.lblNueva = new System.Windows.Forms.Label();
            this.lblInfoAnti = new System.Windows.Forms.Label();
            this.lblInfoNue = new System.Windows.Forms.Label();
            this.lblInfoConf = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAntiguaContra
            // 
            this.lblAntiguaContra.AutoSize = true;
            this.lblAntiguaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguaContra.Location = new System.Drawing.Point(12, 41);
            this.lblAntiguaContra.Name = "lblAntiguaContra";
            this.lblAntiguaContra.Size = new System.Drawing.Size(147, 16);
            this.lblAntiguaContra.TabIndex = 0;
            this.lblAntiguaContra.Text = "Antigua Contraseña:";
            // 
            // txtAnti
            // 
            this.txtAnti.Location = new System.Drawing.Point(12, 57);
            this.txtAnti.MaxLength = 20;
            this.txtAnti.Name = "txtAnti";
            this.txtAnti.PasswordChar = '•';
            this.txtAnti.Size = new System.Drawing.Size(164, 20);
            this.txtAnti.TabIndex = 1;
            // 
            // lblNuevaContra
            // 
            this.lblNuevaContra.AutoSize = true;
            this.lblNuevaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContra.Location = new System.Drawing.Point(12, 97);
            this.lblNuevaContra.Name = "lblNuevaContra";
            this.lblNuevaContra.Size = new System.Drawing.Size(140, 16);
            this.lblNuevaContra.TabIndex = 0;
            this.lblNuevaContra.Text = "Nueva Contraseña:";
            // 
            // txtNue
            // 
            this.txtNue.Location = new System.Drawing.Point(12, 113);
            this.txtNue.MaxLength = 20;
            this.txtNue.Name = "txtNue";
            this.txtNue.PasswordChar = '•';
            this.txtNue.Size = new System.Drawing.Size(164, 20);
            this.txtNue.TabIndex = 1;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(12, 151);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(157, 16);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Text = "Confirmar Contraseña";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(12, 167);
            this.txtConfirm.MaxLength = 20;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '•';
            this.txtConfirm.Size = new System.Drawing.Size(164, 20);
            this.txtConfirm.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cree o modifique la contraseña de seguridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(5, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nota: La contraseña es un metodo de protección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(35, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "puede optar por no generarla o modificarla.";
            // 
            // btnAcept
            // 
            this.btnAcept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcept.Location = new System.Drawing.Point(58, 213);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 2;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.Location = new System.Drawing.Point(182, 114);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(126, 16);
            this.lblNueva.TabIndex = 0;
            this.lblNueva.Text = "(min. 6 y max. 16)";
            // 
            // lblInfoAnti
            // 
            this.lblInfoAnti.AutoSize = true;
            this.lblInfoAnti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAnti.Location = new System.Drawing.Point(182, 58);
            this.lblInfoAnti.Name = "lblInfoAnti";
            this.lblInfoAnti.Size = new System.Drawing.Size(0, 16);
            this.lblInfoAnti.TabIndex = 0;
            // 
            // lblInfoNue
            // 
            this.lblInfoNue.AutoSize = true;
            this.lblInfoNue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoNue.Location = new System.Drawing.Point(182, 130);
            this.lblInfoNue.Name = "lblInfoNue";
            this.lblInfoNue.Size = new System.Drawing.Size(0, 16);
            this.lblInfoNue.TabIndex = 0;
            // 
            // lblInfoConf
            // 
            this.lblInfoConf.AutoSize = true;
            this.lblInfoConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoConf.Location = new System.Drawing.Point(182, 168);
            this.lblInfoConf.Name = "lblInfoConf";
            this.lblInfoConf.Size = new System.Drawing.Size(0, 16);
            this.lblInfoConf.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(9, 195);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            this.lblInfo.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(156, 213);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(104, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar Contraseña";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 278);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtNue);
            this.Controls.Add(this.lblNuevaContra);
            this.Controls.Add(this.txtAnti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInfoNue);
            this.Controls.Add(this.lblInfoConf);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.lblInfoAnti);
            this.Controls.Add(this.lblAntiguaContra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAntiguaContra;
        private System.Windows.Forms.TextBox txtAnti;
        private System.Windows.Forms.Label lblNuevaContra;
        private System.Windows.Forms.TextBox txtNue;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.Label lblInfoAnti;
        private System.Windows.Forms.Label lblInfoNue;
        private System.Windows.Forms.Label lblInfoConf;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBorrar;
    }
}