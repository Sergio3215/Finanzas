namespace Financias
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtFechaRecepcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            this.chkUnidad = new System.Windows.Forms.CheckBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUnidMedPedido = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gbProveedores = new System.Windows.Forms.GroupBox();
            this.txtCodProv = new System.Windows.Forms.TextBox();
            this.txtDirProveedor = new System.Windows.Forms.TextBox();
            this.txtTelProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPedido = new System.Windows.Forms.TabPage();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.NombreArticuloPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnMedPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantArtPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRecepcionPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionProveedorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoProveedorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProveedorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarPedido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarPedido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PedidoRecibido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbRecepción = new System.Windows.Forms.TabPage();
            this.dgvRecepcion = new System.Windows.Forms.DataGridView();
            this.NombreArtRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndMediRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioArticuloRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedidoRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedorRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelProvRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirProvRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProvRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelarRecibido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbStock = new System.Windows.Forms.TabPage();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tbServicios = new System.Windows.Forms.TabPage();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.NombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarServicios = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarServicio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbMisServis = new System.Windows.Forms.TabPage();
            this.dgvMisServicios = new System.Windows.Forms.DataGridView();
            this.MiServiNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MisServis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MisServiCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentaDiaMisServicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVendidoMisServicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MisServisVender = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MisServisNoVender = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditarMisServicios = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarMisServicios = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbReporte = new System.Windows.Forms.TabPage();
            this.lblGananciaDía = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblPromCap = new System.Windows.Forms.Label();
            this.lblPromGan = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblGan = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblGast = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblArtCant = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnLimpiarRecepcion = new System.Windows.Forms.Button();
            this.gbReferencia = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.btnCancelarServicio = new System.Windows.Forms.Button();
            this.btnAceptarServicio = new System.Windows.Forms.Button();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtfechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtAbonarServicio = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnPreferencia = new System.Windows.Forms.Button();
            this.btnNuevoDia = new System.Windows.Forms.Button();
            this.btnNuevoMes = new System.Windows.Forms.Button();
            this.gbMisServicios = new System.Windows.Forms.GroupBox();
            this.btnCancelarMisServis = new System.Windows.Forms.Button();
            this.btnAceptarMisServis = new System.Windows.Forms.Button();
            this.txtNombreMisServicios = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtValorMisServicios = new System.Windows.Forms.TextBox();
            this.btnIniSesion = new System.Windows.Forms.Button();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.cbNombreTrabajador = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.pbEmpleFoto = new Financias.PictureBoxEclipse();
            this.btnNomPerfilCance = new System.Windows.Forms.Button();
            this.btnNomPerfilAcep = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pbePerfil = new Financias.PictureBoxEclipse();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnContraseña = new System.Windows.Forms.Button();
            this.btnLicencia = new System.Windows.Forms.Button();
            this.lblNomPerfil = new System.Windows.Forms.Label();
            this.txtNomPerfil = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.ofdBuscarPerfil = new System.Windows.Forms.OpenFileDialog();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ArtNombreStrock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnMedStick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtCantStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentaDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtVendStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoCosteDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenderStock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CancelarVentaStock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StockEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbArticulo.SuspendLayout();
            this.gbProveedores.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.tbRecepción.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcion)).BeginInit();
            this.tbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tbServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.tbMisServis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisServicios)).BeginInit();
            this.tbReporte.SuspendLayout();
            this.gbReferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gbPedido.SuspendLayout();
            this.gbServicios.SuspendLayout();
            this.gbMisServicios.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(164, 19);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(198, 22);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del Artículo* :";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(315, 198);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 21);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(833, 20);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrecio.MaxLength = 7;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(65, 22);
            this.txtPrecio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(705, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Importe a Pagar* :";
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPedido.Location = new System.Drawing.Point(402, 49);
            this.txtFechaPedido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.Size = new System.Drawing.Size(100, 22);
            this.txtFechaPedido.TabIndex = 5;
            this.txtFechaPedido.Click += new System.EventHandler(this.txtFechaPedido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(264, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de Pedido* :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(397, 198);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 21);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFechaRecepcion
            // 
            this.txtFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRecepcion.Location = new System.Drawing.Point(669, 49);
            this.txtFechaRecepcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFechaRecepcion.Name = "txtFechaRecepcion";
            this.txtFechaRecepcion.Size = new System.Drawing.Size(98, 22);
            this.txtFechaRecepcion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(506, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Recepción* :";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(169, 18);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(120, 22);
            this.txtNombreProveedor.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Proveedor* :";
            // 
            // gbArticulo
            // 
            this.gbArticulo.Controls.Add(this.chkUnidad);
            this.gbArticulo.Controls.Add(this.txtNombreProducto);
            this.gbArticulo.Controls.Add(this.txtPrecioUnidad);
            this.gbArticulo.Controls.Add(this.txtPrecio);
            this.gbArticulo.Controls.Add(this.txtFechaPedido);
            this.gbArticulo.Controls.Add(this.label10);
            this.gbArticulo.Controls.Add(this.label9);
            this.gbArticulo.Controls.Add(this.label4);
            this.gbArticulo.Controls.Add(this.label1);
            this.gbArticulo.Controls.Add(this.label3);
            this.gbArticulo.Controls.Add(this.txtUnidMedPedido);
            this.gbArticulo.Controls.Add(this.txtCantidad);
            this.gbArticulo.Controls.Add(this.label18);
            this.gbArticulo.Controls.Add(this.txtFechaRecepcion);
            this.gbArticulo.Controls.Add(this.label2);
            this.gbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArticulo.Location = new System.Drawing.Point(6, 21);
            this.gbArticulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbArticulo.Size = new System.Drawing.Size(905, 82);
            this.gbArticulo.TabIndex = 0;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "Artículo";
            // 
            // chkUnidad
            // 
            this.chkUnidad.AutoSize = true;
            this.chkUnidad.Location = new System.Drawing.Point(234, 55);
            this.chkUnidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkUnidad.Name = "chkUnidad";
            this.chkUnidad.Size = new System.Drawing.Size(15, 14);
            this.chkUnidad.TabIndex = 12;
            this.chkUnidad.UseVisualStyleBackColor = true;
            this.chkUnidad.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Enabled = false;
            this.txtPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnidad.Location = new System.Drawing.Point(160, 46);
            this.txtPrecioUnidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrecioUnidad.MaxLength = 7;
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(69, 22);
            this.txtPrecioUnidad.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(482, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Unidad de Medida* :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(366, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad* :";
            // 
            // txtUnidMedPedido
            // 
            this.txtUnidMedPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidMedPedido.Location = new System.Drawing.Point(629, 19);
            this.txtUnidMedPedido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUnidMedPedido.MaxLength = 10;
            this.txtUnidMedPedido.Name = "txtUnidMedPedido";
            this.txtUnidMedPedido.Size = new System.Drawing.Size(72, 22);
            this.txtUnidMedPedido.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(444, 20);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCantidad.MaxLength = 7;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(34, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(6, 47);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 18);
            this.label18.TabIndex = 10;
            this.label18.Text = "Importe por Unidad :";
            // 
            // gbProveedores
            // 
            this.gbProveedores.Controls.Add(this.txtCodProv);
            this.gbProveedores.Controls.Add(this.txtDirProveedor);
            this.gbProveedores.Controls.Add(this.txtTelProveedor);
            this.gbProveedores.Controls.Add(this.label8);
            this.gbProveedores.Controls.Add(this.label7);
            this.gbProveedores.Controls.Add(this.label6);
            this.gbProveedores.Controls.Add(this.txtNombreProveedor);
            this.gbProveedores.Controls.Add(this.label5);
            this.gbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProveedores.Location = new System.Drawing.Point(6, 109);
            this.gbProveedores.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbProveedores.Name = "gbProveedores";
            this.gbProveedores.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbProveedores.Size = new System.Drawing.Size(632, 80);
            this.gbProveedores.TabIndex = 1;
            this.gbProveedores.TabStop = false;
            this.gbProveedores.Text = "Datos del Proveedor";
            // 
            // txtCodProv
            // 
            this.txtCodProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProv.Location = new System.Drawing.Point(494, 53);
            this.txtCodProv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Size = new System.Drawing.Size(100, 22);
            this.txtCodProv.TabIndex = 3;
            // 
            // txtDirProveedor
            // 
            this.txtDirProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirProveedor.Location = new System.Drawing.Point(196, 54);
            this.txtDirProveedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDirProveedor.Name = "txtDirProveedor";
            this.txtDirProveedor.Size = new System.Drawing.Size(129, 22);
            this.txtDirProveedor.TabIndex = 2;
            // 
            // txtTelProveedor
            // 
            this.txtTelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelProveedor.Location = new System.Drawing.Point(467, 17);
            this.txtTelProveedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelProveedor.Name = "txtTelProveedor";
            this.txtTelProveedor.Size = new System.Drawing.Size(114, 22);
            this.txtTelProveedor.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(331, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Código de Proveedor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(14, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirección del Proveedor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(306, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono Proveedor :";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tbPedido);
            this.tabControl1.Controls.Add(this.tbRecepción);
            this.tabControl1.Controls.Add(this.tbStock);
            this.tabControl1.Controls.Add(this.tbServicios);
            this.tabControl1.Controls.Add(this.tbMisServis);
            this.tabControl1.Controls.Add(this.tbReporte);
            this.tabControl1.Location = new System.Drawing.Point(1, 390);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 260);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tbPedido
            // 
            this.tbPedido.Controls.Add(this.dgvPedido);
            this.tbPedido.Location = new System.Drawing.Point(4, 22);
            this.tbPedido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPedido.Name = "tbPedido";
            this.tbPedido.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPedido.Size = new System.Drawing.Size(994, 234);
            this.tbPedido.TabIndex = 0;
            this.tbPedido.Text = "Pedido";
            this.tbPedido.UseVisualStyleBackColor = true;
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreArticuloPedido,
            this.UnMedPedido,
            this.CantArtPedido,
            this.PrecioPedido,
            this.FechaPedido,
            this.FechaRecepcionPedido,
            this.NombreProveedorPedido,
            this.DireccionProveedorPedido,
            this.TelefonoProveedorPedido,
            this.CodigoProveedorPedido,
            this.EditarPedido,
            this.EliminarPedido,
            this.PedidoRecibido});
            this.dgvPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedido.Location = new System.Drawing.Point(2, 3);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(990, 228);
            this.dgvPedido.TabIndex = 0;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            // 
            // NombreArticuloPedido
            // 
            this.NombreArticuloPedido.HeaderText = "Nombre del Articulo";
            this.NombreArticuloPedido.Name = "NombreArticuloPedido";
            this.NombreArticuloPedido.ReadOnly = true;
            // 
            // UnMedPedido
            // 
            this.UnMedPedido.HeaderText = "Unidad de Medición";
            this.UnMedPedido.Name = "UnMedPedido";
            this.UnMedPedido.ReadOnly = true;
            this.UnMedPedido.Width = 50;
            // 
            // CantArtPedido
            // 
            this.CantArtPedido.HeaderText = "Cantidad del Articulo";
            this.CantArtPedido.Name = "CantArtPedido";
            this.CantArtPedido.ReadOnly = true;
            this.CantArtPedido.Width = 50;
            // 
            // PrecioPedido
            // 
            this.PrecioPedido.HeaderText = "Precio del Articulo";
            this.PrecioPedido.Name = "PrecioPedido";
            this.PrecioPedido.ReadOnly = true;
            this.PrecioPedido.Width = 50;
            // 
            // FechaPedido
            // 
            this.FechaPedido.HeaderText = "Fecha de Pedido";
            this.FechaPedido.Name = "FechaPedido";
            this.FechaPedido.ReadOnly = true;
            this.FechaPedido.Width = 90;
            // 
            // FechaRecepcionPedido
            // 
            this.FechaRecepcionPedido.HeaderText = "Fecha de Recepción";
            this.FechaRecepcionPedido.Name = "FechaRecepcionPedido";
            this.FechaRecepcionPedido.ReadOnly = true;
            this.FechaRecepcionPedido.Width = 90;
            // 
            // NombreProveedorPedido
            // 
            this.NombreProveedorPedido.HeaderText = "Nombre del Proveedor";
            this.NombreProveedorPedido.Name = "NombreProveedorPedido";
            this.NombreProveedorPedido.ReadOnly = true;
            this.NombreProveedorPedido.Width = 90;
            // 
            // DireccionProveedorPedido
            // 
            this.DireccionProveedorPedido.HeaderText = "Direccion del Proveedor";
            this.DireccionProveedorPedido.Name = "DireccionProveedorPedido";
            this.DireccionProveedorPedido.ReadOnly = true;
            this.DireccionProveedorPedido.Width = 75;
            // 
            // TelefonoProveedorPedido
            // 
            this.TelefonoProveedorPedido.HeaderText = "Telefono del Proveedor";
            this.TelefonoProveedorPedido.Name = "TelefonoProveedorPedido";
            this.TelefonoProveedorPedido.ReadOnly = true;
            this.TelefonoProveedorPedido.Width = 75;
            // 
            // CodigoProveedorPedido
            // 
            this.CodigoProveedorPedido.HeaderText = "Codigo del Proveedor";
            this.CodigoProveedorPedido.Name = "CodigoProveedorPedido";
            this.CodigoProveedorPedido.ReadOnly = true;
            this.CodigoProveedorPedido.Width = 75;
            // 
            // EditarPedido
            // 
            this.EditarPedido.HeaderText = "";
            this.EditarPedido.Name = "EditarPedido";
            this.EditarPedido.ReadOnly = true;
            this.EditarPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditarPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditarPedido.Text = "Editar";
            this.EditarPedido.UseColumnTextForButtonValue = true;
            this.EditarPedido.Width = 50;
            // 
            // EliminarPedido
            // 
            this.EliminarPedido.HeaderText = "";
            this.EliminarPedido.Name = "EliminarPedido";
            this.EliminarPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EliminarPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EliminarPedido.Text = "Eliminar";
            this.EliminarPedido.UseColumnTextForButtonValue = true;
            this.EliminarPedido.Width = 75;
            // 
            // PedidoRecibido
            // 
            this.PedidoRecibido.HeaderText = "";
            this.PedidoRecibido.Name = "PedidoRecibido";
            this.PedidoRecibido.ReadOnly = true;
            this.PedidoRecibido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PedidoRecibido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PedidoRecibido.Text = "Recibido";
            this.PedidoRecibido.UseColumnTextForButtonValue = true;
            this.PedidoRecibido.Width = 75;
            // 
            // tbRecepción
            // 
            this.tbRecepción.Controls.Add(this.dgvRecepcion);
            this.tbRecepción.Location = new System.Drawing.Point(4, 22);
            this.tbRecepción.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbRecepción.Name = "tbRecepción";
            this.tbRecepción.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbRecepción.Size = new System.Drawing.Size(994, 234);
            this.tbRecepción.TabIndex = 1;
            this.tbRecepción.Text = "Recepción";
            this.tbRecepción.UseVisualStyleBackColor = true;
            // 
            // dgvRecepcion
            // 
            this.dgvRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreArtRecibido,
            this.UndMediRecibido,
            this.CantidadRecibido,
            this.PrecioArticuloRecepcion,
            this.FechaPedidoRecepcion,
            this.FechaRecepcion,
            this.NombreProveedorRecepcion,
            this.TelProvRecibido,
            this.DirProvRecibido,
            this.CodProvRec,
            this.CancelarRecibido});
            this.dgvRecepcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecepcion.Location = new System.Drawing.Point(2, 3);
            this.dgvRecepcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvRecepcion.Name = "dgvRecepcion";
            this.dgvRecepcion.Size = new System.Drawing.Size(990, 228);
            this.dgvRecepcion.TabIndex = 0;
            this.dgvRecepcion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecepcion_CellClick);
            // 
            // NombreArtRecibido
            // 
            this.NombreArtRecibido.HeaderText = "Nombre del Articulo";
            this.NombreArtRecibido.Name = "NombreArtRecibido";
            // 
            // UndMediRecibido
            // 
            this.UndMediRecibido.HeaderText = "Unidad de Medición";
            this.UndMediRecibido.Name = "UndMediRecibido";
            this.UndMediRecibido.ReadOnly = true;
            this.UndMediRecibido.Width = 50;
            // 
            // CantidadRecibido
            // 
            this.CantidadRecibido.HeaderText = "Cantidad del Articulo";
            this.CantidadRecibido.Name = "CantidadRecibido";
            this.CantidadRecibido.ReadOnly = true;
            this.CantidadRecibido.Width = 50;
            // 
            // PrecioArticuloRecepcion
            // 
            this.PrecioArticuloRecepcion.HeaderText = "Precio del Articulo";
            this.PrecioArticuloRecepcion.Name = "PrecioArticuloRecepcion";
            this.PrecioArticuloRecepcion.ReadOnly = true;
            this.PrecioArticuloRecepcion.Width = 50;
            // 
            // FechaPedidoRecepcion
            // 
            this.FechaPedidoRecepcion.HeaderText = "Fecha del Pedido";
            this.FechaPedidoRecepcion.Name = "FechaPedidoRecepcion";
            this.FechaPedidoRecepcion.Width = 90;
            // 
            // FechaRecepcion
            // 
            this.FechaRecepcion.HeaderText = "Fecha Recibido";
            this.FechaRecepcion.Name = "FechaRecepcion";
            this.FechaRecepcion.ReadOnly = true;
            this.FechaRecepcion.Width = 90;
            // 
            // NombreProveedorRecepcion
            // 
            this.NombreProveedorRecepcion.HeaderText = "Nombre del Proveedor";
            this.NombreProveedorRecepcion.Name = "NombreProveedorRecepcion";
            this.NombreProveedorRecepcion.ReadOnly = true;
            this.NombreProveedorRecepcion.Width = 90;
            // 
            // TelProvRecibido
            // 
            this.TelProvRecibido.HeaderText = "Telefono del Proveedor";
            this.TelProvRecibido.Name = "TelProvRecibido";
            this.TelProvRecibido.ReadOnly = true;
            this.TelProvRecibido.Width = 75;
            // 
            // DirProvRecibido
            // 
            this.DirProvRecibido.HeaderText = "Direccion del Proveedor";
            this.DirProvRecibido.Name = "DirProvRecibido";
            this.DirProvRecibido.ReadOnly = true;
            this.DirProvRecibido.Width = 75;
            // 
            // CodProvRec
            // 
            this.CodProvRec.HeaderText = "Codigo del Proveedor";
            this.CodProvRec.Name = "CodProvRec";
            this.CodProvRec.Width = 75;
            // 
            // CancelarRecibido
            // 
            this.CancelarRecibido.HeaderText = "";
            this.CancelarRecibido.Name = "CancelarRecibido";
            this.CancelarRecibido.Text = "Cancelar";
            this.CancelarRecibido.UseColumnTextForButtonValue = true;
            this.CancelarRecibido.Width = 75;
            // 
            // tbStock
            // 
            this.tbStock.Controls.Add(this.dgvStock);
            this.tbStock.Location = new System.Drawing.Point(4, 22);
            this.tbStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbStock.Name = "tbStock";
            this.tbStock.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbStock.Size = new System.Drawing.Size(994, 234);
            this.tbStock.TabIndex = 2;
            this.tbStock.Text = "Stock";
            this.tbStock.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtNombreStrock,
            this.UnMedStick,
            this.ArtCantStock,
            this.PrecioCompra,
            this.PrecioStock,
            this.VentaDia,
            this.ArtVendStock,
            this.UltimoCosteDia,
            this.UltimoCosto,
            this.VenderStock,
            this.CancelarVentaStock,
            this.StockEliminar});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(2, 3);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvStock.Name = "dgvStock";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.Size = new System.Drawing.Size(990, 228);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            this.dgvStock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellEndEdit);
            this.dgvStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStock_CellFormatting);
            // 
            // tbServicios
            // 
            this.tbServicios.Controls.Add(this.dgvServicios);
            this.tbServicios.Location = new System.Drawing.Point(4, 22);
            this.tbServicios.Name = "tbServicios";
            this.tbServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tbServicios.Size = new System.Drawing.Size(994, 234);
            this.tbServicios.TabIndex = 3;
            this.tbServicios.Text = "Servicios";
            this.tbServicios.UseVisualStyleBackColor = true;
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreServicio,
            this.MontoPagar,
            this.FechaVencimiento,
            this.EditarServicios,
            this.EliminarServicio});
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(3, 3);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(988, 228);
            this.dgvServicios.TabIndex = 0;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            // 
            // NombreServicio
            // 
            this.NombreServicio.HeaderText = "Nombre del Servicio";
            this.NombreServicio.Name = "NombreServicio";
            this.NombreServicio.ReadOnly = true;
            // 
            // MontoPagar
            // 
            this.MontoPagar.HeaderText = "Monto a Abonar";
            this.MontoPagar.Name = "MontoPagar";
            this.MontoPagar.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha de Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            // 
            // EditarServicios
            // 
            this.EditarServicios.HeaderText = "";
            this.EditarServicios.Name = "EditarServicios";
            this.EditarServicios.Text = "Editar";
            this.EditarServicios.UseColumnTextForButtonValue = true;
            this.EditarServicios.Width = 50;
            // 
            // EliminarServicio
            // 
            this.EliminarServicio.HeaderText = "";
            this.EliminarServicio.Name = "EliminarServicio";
            this.EliminarServicio.Text = "Eliminar";
            this.EliminarServicio.UseColumnTextForButtonValue = true;
            this.EliminarServicio.Width = 50;
            // 
            // tbMisServis
            // 
            this.tbMisServis.Controls.Add(this.dgvMisServicios);
            this.tbMisServis.Location = new System.Drawing.Point(4, 22);
            this.tbMisServis.Name = "tbMisServis";
            this.tbMisServis.Padding = new System.Windows.Forms.Padding(3);
            this.tbMisServis.Size = new System.Drawing.Size(994, 234);
            this.tbMisServis.TabIndex = 5;
            this.tbMisServis.Text = "Mis Servicios";
            this.tbMisServis.UseVisualStyleBackColor = true;
            // 
            // dgvMisServicios
            // 
            this.dgvMisServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MiServiNombre,
            this.MisServis,
            this.MisServiCantidad,
            this.VentaDiaMisServicios,
            this.TotalVendidoMisServicios,
            this.MisServisVender,
            this.MisServisNoVender,
            this.EditarMisServicios,
            this.EliminarMisServicios});
            this.dgvMisServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMisServicios.Location = new System.Drawing.Point(3, 3);
            this.dgvMisServicios.Name = "dgvMisServicios";
            this.dgvMisServicios.Size = new System.Drawing.Size(988, 228);
            this.dgvMisServicios.TabIndex = 0;
            this.dgvMisServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisServicios_CellClick);
            // 
            // MiServiNombre
            // 
            this.MiServiNombre.HeaderText = "Nombre del Servicio";
            this.MiServiNombre.Name = "MiServiNombre";
            this.MiServiNombre.ReadOnly = true;
            // 
            // MisServis
            // 
            this.MisServis.HeaderText = "Valor del Servicio";
            this.MisServis.Name = "MisServis";
            this.MisServis.ReadOnly = true;
            // 
            // MisServiCantidad
            // 
            this.MisServiCantidad.HeaderText = "Servicios Vendidos";
            this.MisServiCantidad.Name = "MisServiCantidad";
            this.MisServiCantidad.ReadOnly = true;
            // 
            // VentaDiaMisServicios
            // 
            this.VentaDiaMisServicios.HeaderText = "Ventas del Dia";
            this.VentaDiaMisServicios.Name = "VentaDiaMisServicios";
            this.VentaDiaMisServicios.ReadOnly = true;
            // 
            // TotalVendidoMisServicios
            // 
            this.TotalVendidoMisServicios.HeaderText = "Total Vendido";
            this.TotalVendidoMisServicios.Name = "TotalVendidoMisServicios";
            this.TotalVendidoMisServicios.ReadOnly = true;
            // 
            // MisServisVender
            // 
            this.MisServisVender.HeaderText = "";
            this.MisServisVender.Name = "MisServisVender";
            this.MisServisVender.Text = "Servicio Vendido";
            this.MisServisVender.UseColumnTextForButtonValue = true;
            this.MisServisVender.Width = 90;
            // 
            // MisServisNoVender
            // 
            this.MisServisNoVender.HeaderText = "";
            this.MisServisNoVender.Name = "MisServisNoVender";
            this.MisServisNoVender.Text = "Servicio no Vendido";
            this.MisServisNoVender.UseColumnTextForButtonValue = true;
            this.MisServisNoVender.Width = 90;
            // 
            // EditarMisServicios
            // 
            this.EditarMisServicios.HeaderText = "";
            this.EditarMisServicios.Name = "EditarMisServicios";
            this.EditarMisServicios.Text = "Editar";
            this.EditarMisServicios.UseColumnTextForButtonValue = true;
            this.EditarMisServicios.Width = 75;
            // 
            // EliminarMisServicios
            // 
            this.EliminarMisServicios.HeaderText = "";
            this.EliminarMisServicios.Name = "EliminarMisServicios";
            this.EliminarMisServicios.Text = "Eliminar";
            this.EliminarMisServicios.UseColumnTextForButtonValue = true;
            this.EliminarMisServicios.Width = 75;
            // 
            // tbReporte
            // 
            this.tbReporte.Controls.Add(this.lblGananciaDía);
            this.tbReporte.Controls.Add(this.label26);
            this.tbReporte.Controls.Add(this.lblCap);
            this.tbReporte.Controls.Add(this.label24);
            this.tbReporte.Controls.Add(this.lblPromCap);
            this.tbReporte.Controls.Add(this.lblPromGan);
            this.tbReporte.Controls.Add(this.label23);
            this.tbReporte.Controls.Add(this.lblGan);
            this.tbReporte.Controls.Add(this.label22);
            this.tbReporte.Controls.Add(this.lblGast);
            this.tbReporte.Controls.Add(this.label21);
            this.tbReporte.Controls.Add(this.lblArtCant);
            this.tbReporte.Controls.Add(this.label20);
            this.tbReporte.Controls.Add(this.label19);
            this.tbReporte.Location = new System.Drawing.Point(4, 22);
            this.tbReporte.Name = "tbReporte";
            this.tbReporte.Padding = new System.Windows.Forms.Padding(3);
            this.tbReporte.Size = new System.Drawing.Size(994, 234);
            this.tbReporte.TabIndex = 4;
            this.tbReporte.Text = "Reporte";
            this.tbReporte.UseVisualStyleBackColor = true;
            // 
            // lblGananciaDía
            // 
            this.lblGananciaDía.AutoSize = true;
            this.lblGananciaDía.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciaDía.Location = new System.Drawing.Point(669, 77);
            this.lblGananciaDía.Name = "lblGananciaDía";
            this.lblGananciaDía.Size = new System.Drawing.Size(21, 24);
            this.lblGananciaDía.TabIndex = 1;
            this.lblGananciaDía.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(420, 77);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(183, 24);
            this.label26.TabIndex = 2;
            this.label26.Text = "Ganancias del día:";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.Location = new System.Drawing.Point(252, 112);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(21, 24);
            this.lblCap.TabIndex = 0;
            this.lblCap.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 24);
            this.label24.TabIndex = 0;
            this.label24.Text = "Capital:";
            // 
            // lblPromCap
            // 
            this.lblPromCap.AutoSize = true;
            this.lblPromCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromCap.Location = new System.Drawing.Point(252, 180);
            this.lblPromCap.Name = "lblPromCap";
            this.lblPromCap.Size = new System.Drawing.Size(21, 24);
            this.lblPromCap.TabIndex = 0;
            this.lblPromCap.Text = "0";
            // 
            // lblPromGan
            // 
            this.lblPromGan.AutoSize = true;
            this.lblPromGan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromGan.Location = new System.Drawing.Point(252, 156);
            this.lblPromGan.Name = "lblPromGan";
            this.lblPromGan.Size = new System.Drawing.Size(21, 24);
            this.lblPromGan.TabIndex = 0;
            this.lblPromGan.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 180);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(205, 24);
            this.label23.TabIndex = 0;
            this.label23.Text = "Promedio de Capital:";
            // 
            // lblGan
            // 
            this.lblGan.AutoSize = true;
            this.lblGan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGan.Location = new System.Drawing.Point(252, 88);
            this.lblGan.Name = "lblGan";
            this.lblGan.Size = new System.Drawing.Size(21, 24);
            this.lblGan.TabIndex = 0;
            this.lblGan.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 156);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(230, 24);
            this.label22.TabIndex = 0;
            this.label22.Text = "Promedio de Ganancia:";
            // 
            // lblGast
            // 
            this.lblGast.AutoSize = true;
            this.lblGast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGast.Location = new System.Drawing.Point(252, 64);
            this.lblGast.Name = "lblGast";
            this.lblGast.Size = new System.Drawing.Size(21, 24);
            this.lblGast.TabIndex = 0;
            this.lblGast.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "Ganancias:";
            // 
            // lblArtCant
            // 
            this.lblArtCant.AutoSize = true;
            this.lblArtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtCant.Location = new System.Drawing.Point(252, 22);
            this.lblArtCant.Name = "lblArtCant";
            this.lblArtCant.Size = new System.Drawing.Size(21, 24);
            this.lblArtCant.TabIndex = 0;
            this.lblArtCant.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Gastos:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(215, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Cantidad de Articulos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Aviso 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Aviso 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 66);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Puede que se agote";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(33, 88);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Aún hay suficiente";
            // 
            // btnLimpiarRecepcion
            // 
            this.btnLimpiarRecepcion.Enabled = false;
            this.btnLimpiarRecepcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiarRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarRecepcion.Location = new System.Drawing.Point(531, 390);
            this.btnLimpiarRecepcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiarRecepcion.Name = "btnLimpiarRecepcion";
            this.btnLimpiarRecepcion.Size = new System.Drawing.Size(112, 23);
            this.btnLimpiarRecepcion.TabIndex = 8;
            this.btnLimpiarRecepcion.Text = "Limpiar Recepcion";
            this.btnLimpiarRecepcion.UseVisualStyleBackColor = true;
            this.btnLimpiarRecepcion.Click += new System.EventHandler(this.btnLimpiarRecepcion_Click);
            // 
            // gbReferencia
            // 
            this.gbReferencia.Controls.Add(this.label14);
            this.gbReferencia.Controls.Add(this.pictureBox1);
            this.gbReferencia.Controls.Add(this.label17);
            this.gbReferencia.Controls.Add(this.pictureBox2);
            this.gbReferencia.Controls.Add(this.label16);
            this.gbReferencia.Controls.Add(this.pictureBox3);
            this.gbReferencia.Controls.Add(this.label15);
            this.gbReferencia.Controls.Add(this.pictureBox4);
            this.gbReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbReferencia.Location = new System.Drawing.Point(643, 109);
            this.gbReferencia.Name = "gbReferencia";
            this.gbReferencia.Size = new System.Drawing.Size(155, 110);
            this.gbReferencia.TabIndex = 9;
            this.gbReferencia.TabStop = false;
            this.gbReferencia.Text = "Referencia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Location = new System.Drawing.Point(10, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 14);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Orange;
            this.pictureBox2.Location = new System.Drawing.Point(10, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 14);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox3.Location = new System.Drawing.Point(10, 65);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 14);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.Location = new System.Drawing.Point(10, 87);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 14);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.gbArticulo);
            this.gbPedido.Controls.Add(this.btnAceptar);
            this.gbPedido.Controls.Add(this.gbReferencia);
            this.gbPedido.Controls.Add(this.btnCancelar);
            this.gbPedido.Controls.Add(this.gbProveedores);
            this.gbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbPedido.Location = new System.Drawing.Point(20, 25);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(926, 225);
            this.gbPedido.TabIndex = 10;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Pedidos";
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.btnCancelarServicio);
            this.gbServicios.Controls.Add(this.btnAceptarServicio);
            this.gbServicios.Controls.Add(this.txtNombreServicio);
            this.gbServicios.Controls.Add(this.label11);
            this.gbServicios.Controls.Add(this.label12);
            this.gbServicios.Controls.Add(this.label13);
            this.gbServicios.Controls.Add(this.txtfechaVencimiento);
            this.gbServicios.Controls.Add(this.txtAbonarServicio);
            this.gbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServicios.Location = new System.Drawing.Point(20, 276);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(494, 95);
            this.gbServicios.TabIndex = 11;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = "Servicios";
            // 
            // btnCancelarServicio
            // 
            this.btnCancelarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarServicio.Location = new System.Drawing.Point(372, 61);
            this.btnCancelarServicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelarServicio.Name = "btnCancelarServicio";
            this.btnCancelarServicio.Size = new System.Drawing.Size(74, 24);
            this.btnCancelarServicio.TabIndex = 17;
            this.btnCancelarServicio.Text = "Cancelar";
            this.btnCancelarServicio.UseVisualStyleBackColor = true;
            this.btnCancelarServicio.Click += new System.EventHandler(this.btnCancelarServicio_Click);
            // 
            // btnAceptarServicio
            // 
            this.btnAceptarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAceptarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarServicio.Location = new System.Drawing.Point(294, 61);
            this.btnAceptarServicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAceptarServicio.Name = "btnAceptarServicio";
            this.btnAceptarServicio.Size = new System.Drawing.Size(74, 24);
            this.btnAceptarServicio.TabIndex = 16;
            this.btnAceptarServicio.Text = "Aceptar";
            this.btnAceptarServicio.UseVisualStyleBackColor = true;
            this.btnAceptarServicio.Click += new System.EventHandler(this.btnAceptarServicio_Click);
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.Location = new System.Drawing.Point(166, 21);
            this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(124, 22);
            this.txtNombreServicio.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(8, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Fecha de vencimiento* :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(303, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Monto a abonar* :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(8, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "Nombre del Servicio* :";
            // 
            // txtfechaVencimiento
            // 
            this.txtfechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaVencimiento.Location = new System.Drawing.Point(175, 60);
            this.txtfechaVencimiento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtfechaVencimiento.MaxLength = 10;
            this.txtfechaVencimiento.Name = "txtfechaVencimiento";
            this.txtfechaVencimiento.Size = new System.Drawing.Size(78, 22);
            this.txtfechaVencimiento.TabIndex = 12;
            // 
            // txtAbonarServicio
            // 
            this.txtAbonarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbonarServicio.Location = new System.Drawing.Point(431, 24);
            this.txtAbonarServicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAbonarServicio.MaxLength = 7;
            this.txtAbonarServicio.Name = "txtAbonarServicio";
            this.txtAbonarServicio.Size = new System.Drawing.Size(53, 22);
            this.txtAbonarServicio.TabIndex = 11;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(4, 2);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(84, 20);
            this.lblPedido.TabIndex = 12;
            this.lblPedido.Text = "▼ Pedido";
            this.lblPedido.Click += new System.EventHandler(this.lblPedido_Click);
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(4, 253);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(101, 20);
            this.lblServicio.TabIndex = 12;
            this.lblServicio.Text = "▼ Servicios";
            this.lblServicio.Click += new System.EventHandler(this.lblServicio_Click);
            // 
            // btnPreferencia
            // 
            this.btnPreferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferencia.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreferencia.Location = new System.Drawing.Point(10, 525);
            this.btnPreferencia.Name = "btnPreferencia";
            this.btnPreferencia.Size = new System.Drawing.Size(236, 45);
            this.btnPreferencia.TabIndex = 13;
            this.btnPreferencia.Text = "Preferencias";
            this.btnPreferencia.UseVisualStyleBackColor = true;
            this.btnPreferencia.Click += new System.EventHandler(this.btnPreferencia_Click);
            // 
            // btnNuevoDia
            // 
            this.btnNuevoDia.Enabled = false;
            this.btnNuevoDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevoDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDia.Location = new System.Drawing.Point(656, 390);
            this.btnNuevoDia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevoDia.Name = "btnNuevoDia";
            this.btnNuevoDia.Size = new System.Drawing.Size(112, 23);
            this.btnNuevoDia.TabIndex = 8;
            this.btnNuevoDia.Text = "Nuevo Día";
            this.btnNuevoDia.UseVisualStyleBackColor = true;
            this.btnNuevoDia.Click += new System.EventHandler(this.btnNuevoDia_Click);
            // 
            // btnNuevoMes
            // 
            this.btnNuevoMes.Enabled = false;
            this.btnNuevoMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevoMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMes.Location = new System.Drawing.Point(776, 390);
            this.btnNuevoMes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevoMes.Name = "btnNuevoMes";
            this.btnNuevoMes.Size = new System.Drawing.Size(112, 23);
            this.btnNuevoMes.TabIndex = 8;
            this.btnNuevoMes.Text = "Nuevo Mes";
            this.btnNuevoMes.UseVisualStyleBackColor = true;
            this.btnNuevoMes.Click += new System.EventHandler(this.btnNuevoMes_Click);
            // 
            // gbMisServicios
            // 
            this.gbMisServicios.Controls.Add(this.btnCancelarMisServis);
            this.gbMisServicios.Controls.Add(this.btnAceptarMisServis);
            this.gbMisServicios.Controls.Add(this.txtNombreMisServicios);
            this.gbMisServicios.Controls.Add(this.label27);
            this.gbMisServicios.Controls.Add(this.label28);
            this.gbMisServicios.Controls.Add(this.txtValorMisServicios);
            this.gbMisServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMisServicios.Location = new System.Drawing.Point(520, 276);
            this.gbMisServicios.Name = "gbMisServicios";
            this.gbMisServicios.Size = new System.Drawing.Size(426, 95);
            this.gbMisServicios.TabIndex = 11;
            this.gbMisServicios.TabStop = false;
            this.gbMisServicios.Text = "Mis Servicios";
            // 
            // btnCancelarMisServis
            // 
            this.btnCancelarMisServis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelarMisServis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMisServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMisServis.Location = new System.Drawing.Point(333, 59);
            this.btnCancelarMisServis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelarMisServis.Name = "btnCancelarMisServis";
            this.btnCancelarMisServis.Size = new System.Drawing.Size(74, 24);
            this.btnCancelarMisServis.TabIndex = 17;
            this.btnCancelarMisServis.Text = "Cancelar";
            this.btnCancelarMisServis.UseVisualStyleBackColor = true;
            this.btnCancelarMisServis.Click += new System.EventHandler(this.btnCancelarMisServis_Click);
            // 
            // btnAceptarMisServis
            // 
            this.btnAceptarMisServis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAceptarMisServis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMisServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarMisServis.Location = new System.Drawing.Point(255, 59);
            this.btnAceptarMisServis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAceptarMisServis.Name = "btnAceptarMisServis";
            this.btnAceptarMisServis.Size = new System.Drawing.Size(74, 24);
            this.btnAceptarMisServis.TabIndex = 16;
            this.btnAceptarMisServis.Text = "Aceptar";
            this.btnAceptarMisServis.UseVisualStyleBackColor = true;
            this.btnAceptarMisServis.Click += new System.EventHandler(this.btnAceptarMisServis_Click);
            // 
            // txtNombreMisServicios
            // 
            this.txtNombreMisServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMisServicios.Location = new System.Drawing.Point(166, 21);
            this.txtNombreMisServicios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreMisServicios.Name = "txtNombreMisServicios";
            this.txtNombreMisServicios.Size = new System.Drawing.Size(124, 22);
            this.txtNombreMisServicios.TabIndex = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(8, 63);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(136, 18);
            this.label27.TabIndex = 14;
            this.label27.Text = "Valor del Servicio* :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(8, 22);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(156, 18);
            this.label28.TabIndex = 13;
            this.label28.Text = "Nombre del Servicio* :";
            // 
            // txtValorMisServicios
            // 
            this.txtValorMisServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMisServicios.Location = new System.Drawing.Point(143, 62);
            this.txtValorMisServicios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtValorMisServicios.MaxLength = 7;
            this.txtValorMisServicios.Name = "txtValorMisServicios";
            this.txtValorMisServicios.Size = new System.Drawing.Size(75, 22);
            this.txtValorMisServicios.TabIndex = 11;
            // 
            // btnIniSesion
            // 
            this.btnIniSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniSesion.Location = new System.Drawing.Point(10, 596);
            this.btnIniSesion.Name = "btnIniSesion";
            this.btnIniSesion.Size = new System.Drawing.Size(236, 45);
            this.btnIniSesion.TabIndex = 13;
            this.btnIniSesion.Text = "Iniciar Sesión";
            this.btnIniSesion.UseVisualStyleBackColor = true;
            this.btnIniSesion.Click += new System.EventHandler(this.btnIniSesion_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.btnBuscar);
            this.pnPrincipal.Controls.Add(this.txtBuscar);
            this.pnPrincipal.Controls.Add(this.lblPedido);
            this.pnPrincipal.Controls.Add(this.gbPedido);
            this.pnPrincipal.Controls.Add(this.lblServicio);
            this.pnPrincipal.Controls.Add(this.btnLimpiarRecepcion);
            this.pnPrincipal.Controls.Add(this.btnNuevoMes);
            this.pnPrincipal.Controls.Add(this.gbMisServicios);
            this.pnPrincipal.Controls.Add(this.gbServicios);
            this.pnPrincipal.Controls.Add(this.btnNuevoDia);
            this.pnPrincipal.Controls.Add(this.tabControl1);
            this.pnPrincipal.Controls.Add(this.btnMenu);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1008, 642);
            this.pnPrincipal.TabIndex = 15;
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMenu.Controls.Add(this.cbNombreTrabajador);
            this.pnMenu.Controls.Add(this.label29);
            this.pnMenu.Controls.Add(this.pbEmpleFoto);
            this.pnMenu.Controls.Add(this.btnNomPerfilCance);
            this.pnMenu.Controls.Add(this.btnNomPerfilAcep);
            this.pnMenu.Controls.Add(this.label25);
            this.pnMenu.Controls.Add(this.btnAtras);
            this.pnMenu.Controls.Add(this.pbePerfil);
            this.pnMenu.Controls.Add(this.btnEmpleado);
            this.pnMenu.Controls.Add(this.btnContraseña);
            this.pnMenu.Controls.Add(this.btnLicencia);
            this.pnMenu.Controls.Add(this.btnIniSesion);
            this.pnMenu.Controls.Add(this.btnPreferencia);
            this.pnMenu.Controls.Add(this.lblNomPerfil);
            this.pnMenu.Controls.Add(this.txtNomPerfil);
            this.pnMenu.Location = new System.Drawing.Point(754, 1);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(254, 645);
            this.pnMenu.TabIndex = 14;
            this.pnMenu.Visible = false;
            // 
            // cbNombreTrabajador
            // 
            this.cbNombreTrabajador.Enabled = false;
            this.cbNombreTrabajador.FormattingEnabled = true;
            this.cbNombreTrabajador.Location = new System.Drawing.Point(38, 334);
            this.cbNombreTrabajador.Name = "cbNombreTrabajador";
            this.cbNombreTrabajador.Size = new System.Drawing.Size(180, 21);
            this.cbNombreTrabajador.TabIndex = 20;
            this.cbNombreTrabajador.SelectedIndexChanged += new System.EventHandler(this.cbNombreTrabajador_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(21, 307);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(200, 24);
            this.label29.TabIndex = 16;
            this.label29.Text = "Empleado/Empleador:";
            // 
            // pbEmpleFoto
            // 
            this.pbEmpleFoto.Image = global::Financias.Properties.Resources.usuario_perfil_oculto;
            this.pbEmpleFoto.Location = new System.Drawing.Point(68, 191);
            this.pbEmpleFoto.Name = "pbEmpleFoto";
            this.pbEmpleFoto.Size = new System.Drawing.Size(115, 115);
            this.pbEmpleFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmpleFoto.TabIndex = 19;
            this.pbEmpleFoto.TabStop = false;
            // 
            // btnNomPerfilCance
            // 
            this.btnNomPerfilCance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomPerfilCance.Location = new System.Drawing.Point(135, 163);
            this.btnNomPerfilCance.Name = "btnNomPerfilCance";
            this.btnNomPerfilCance.Size = new System.Drawing.Size(75, 23);
            this.btnNomPerfilCance.TabIndex = 17;
            this.btnNomPerfilCance.Text = "Cancelar";
            this.btnNomPerfilCance.UseVisualStyleBackColor = true;
            this.btnNomPerfilCance.Visible = false;
            this.btnNomPerfilCance.Click += new System.EventHandler(this.btnNomPerfilCance_Click);
            // 
            // btnNomPerfilAcep
            // 
            this.btnNomPerfilAcep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomPerfilAcep.Location = new System.Drawing.Point(38, 165);
            this.btnNomPerfilAcep.Name = "btnNomPerfilAcep";
            this.btnNomPerfilAcep.Size = new System.Drawing.Size(75, 23);
            this.btnNomPerfilAcep.TabIndex = 17;
            this.btnNomPerfilAcep.Text = "Guardar";
            this.btnNomPerfilAcep.UseVisualStyleBackColor = true;
            this.btnNomPerfilAcep.Visible = false;
            this.btnNomPerfilAcep.Click += new System.EventHandler(this.btnNomPerfilAcep_Click);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(31, 107);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(179, 24);
            this.label25.TabIndex = 0;
            this.label25.Text = "Nombre del Local:";
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::Financias.Properties.Resources.adelante_web;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(6, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(39, 28);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pbePerfil
            // 
            this.pbePerfil.Image = global::Financias.Properties.Resources.usuario_perfil;
            this.pbePerfil.Location = new System.Drawing.Point(68, 0);
            this.pbePerfil.Name = "pbePerfil";
            this.pbePerfil.Size = new System.Drawing.Size(105, 104);
            this.pbePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbePerfil.TabIndex = 14;
            this.pbePerfil.TabStop = false;
            this.pbePerfil.DoubleClick += new System.EventHandler(this.pbePerfil_DoubleClick);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEmpleado.Location = new System.Drawing.Point(10, 423);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(236, 45);
            this.btnEmpleado.TabIndex = 13;
            this.btnEmpleado.Text = "Gestión de Empleados";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnContraseña
            // 
            this.btnContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnContraseña.Location = new System.Drawing.Point(10, 474);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(236, 45);
            this.btnContraseña.TabIndex = 13;
            this.btnContraseña.Text = "Gestion de Contraseña";
            this.btnContraseña.UseVisualStyleBackColor = true;
            this.btnContraseña.Click += new System.EventHandler(this.btnContraseña_Click);
            // 
            // btnLicencia
            // 
            this.btnLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicencia.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicencia.Location = new System.Drawing.Point(10, 372);
            this.btnLicencia.Name = "btnLicencia";
            this.btnLicencia.Size = new System.Drawing.Size(236, 45);
            this.btnLicencia.TabIndex = 13;
            this.btnLicencia.Text = "Licencia";
            this.btnLicencia.UseVisualStyleBackColor = true;
            this.btnLicencia.Click += new System.EventHandler(this.btnLicencia_Click);
            // 
            // lblNomPerfil
            // 
            this.lblNomPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPerfil.Location = new System.Drawing.Point(10, 136);
            this.lblNomPerfil.Name = "lblNomPerfil";
            this.lblNomPerfil.Size = new System.Drawing.Size(241, 52);
            this.lblNomPerfil.TabIndex = 0;
            this.lblNomPerfil.Text = "Ingrese un nombre aquí";
            this.lblNomPerfil.Click += new System.EventHandler(this.lblNomPerfil_Click);
            // 
            // txtNomPerfil
            // 
            this.txtNomPerfil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNomPerfil.Location = new System.Drawing.Point(16, 139);
            this.txtNomPerfil.Name = "txtNomPerfil";
            this.txtNomPerfil.Size = new System.Drawing.Size(232, 20);
            this.txtNomPerfil.TabIndex = 18;
            this.txtNomPerfil.Visible = false;
            this.txtNomPerfil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomPerfil_KeyPress);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackgroundImage = global::Financias.Properties.Resources.MENU;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(951, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(51, 41);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // ofdBuscarPerfil
            // 
            this.ofdBuscarPerfil.Filter = "JPEG|*.jpg;*.jpeg |Bitmap|* .bmp |PNG| *.png|Image|*.IMAGE";
            this.ofdBuscarPerfil.Title = "Cargue una imagen";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(260, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(440, 22);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(701, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 22);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "X";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ArtNombreStrock
            // 
            this.ArtNombreStrock.HeaderText = "Nombre del Articulo";
            this.ArtNombreStrock.Name = "ArtNombreStrock";
            // 
            // UnMedStick
            // 
            this.UnMedStick.HeaderText = "Unidad de Medición";
            this.UnMedStick.Name = "UnMedStick";
            this.UnMedStick.Width = 50;
            // 
            // ArtCantStock
            // 
            this.ArtCantStock.HeaderText = "Cantidad del Articulo";
            this.ArtCantStock.Name = "ArtCantStock";
            this.ArtCantStock.Width = 50;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio de Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Visible = false;
            // 
            // PrecioStock
            // 
            this.PrecioStock.HeaderText = "Precio de Venta";
            this.PrecioStock.MaxInputLength = 7;
            this.PrecioStock.Name = "PrecioStock";
            this.PrecioStock.Width = 75;
            // 
            // VentaDia
            // 
            this.VentaDia.HeaderText = "Venta del Día";
            this.VentaDia.Name = "VentaDia";
            this.VentaDia.Width = 50;
            // 
            // ArtVendStock
            // 
            this.ArtVendStock.HeaderText = "Articulos Vendidos";
            this.ArtVendStock.Name = "ArtVendStock";
            this.ArtVendStock.Width = 50;
            // 
            // UltimoCosteDia
            // 
            this.UltimoCosteDia.HeaderText = "Ultimo Costo del Día";
            this.UltimoCosteDia.Name = "UltimoCosteDia";
            this.UltimoCosteDia.Visible = false;
            // 
            // UltimoCosto
            // 
            this.UltimoCosto.HeaderText = "Ultimo Costo";
            this.UltimoCosto.Name = "UltimoCosto";
            this.UltimoCosto.Visible = false;
            // 
            // VenderStock
            // 
            this.VenderStock.HeaderText = "";
            this.VenderStock.Name = "VenderStock";
            this.VenderStock.Text = "Vender";
            this.VenderStock.UseColumnTextForButtonValue = true;
            this.VenderStock.Width = 75;
            // 
            // CancelarVentaStock
            // 
            this.CancelarVentaStock.HeaderText = "";
            this.CancelarVentaStock.Name = "CancelarVentaStock";
            this.CancelarVentaStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CancelarVentaStock.Text = "No Vender";
            this.CancelarVentaStock.UseColumnTextForButtonValue = true;
            this.CancelarVentaStock.Width = 90;
            // 
            // StockEliminar
            // 
            this.StockEliminar.HeaderText = "";
            this.StockEliminar.Name = "StockEliminar";
            this.StockEliminar.Text = "Eliminar";
            this.StockEliminar.UseColumnTextForButtonValue = true;
            this.StockEliminar.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbArticulo.ResumeLayout(false);
            this.gbArticulo.PerformLayout();
            this.gbProveedores.ResumeLayout(false);
            this.gbProveedores.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.tbRecepción.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcion)).EndInit();
            this.tbStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tbServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.tbMisServis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisServicios)).EndInit();
            this.tbReporte.ResumeLayout(false);
            this.tbReporte.PerformLayout();
            this.gbReferencia.ResumeLayout(false);
            this.gbReferencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gbPedido.ResumeLayout(false);
            this.gbServicios.ResumeLayout(false);
            this.gbServicios.PerformLayout();
            this.gbMisServicios.ResumeLayout(false);
            this.gbMisServicios.PerformLayout();
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbePerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtFechaRecepcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbArticulo;
        private System.Windows.Forms.GroupBox gbProveedores;
        private System.Windows.Forms.TextBox txtCodProv;
        private System.Windows.Forms.TextBox txtDirProveedor;
        private System.Windows.Forms.TextBox txtTelProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TabPage tbRecepción;
        private System.Windows.Forms.DataGridView dgvRecepcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnidMedPedido;
        private System.Windows.Forms.TabPage tbStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticuloPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnMedPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantArtPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecepcionPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedorPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionProveedorPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoProveedorPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProveedorPedido;
        private System.Windows.Forms.DataGridViewButtonColumn EditarPedido;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarPedido;
        private System.Windows.Forms.DataGridViewButtonColumn PedidoRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArtRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndMediRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioArticuloRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedidoRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedorRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelProvRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirProvRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProvRec;
        private System.Windows.Forms.DataGridViewButtonColumn CancelarRecibido;
        private System.Windows.Forms.Button btnLimpiarRecepcion;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkUnidad;
        private System.Windows.Forms.TabPage tbServicios;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.GroupBox gbReferencia;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtfechaVencimiento;
        private System.Windows.Forms.TextBox txtAbonarServicio;
        private System.Windows.Forms.Button btnCancelarServicio;
        private System.Windows.Forms.Button btnAceptarServicio;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TabPage tbReporte;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblPromCap;
        private System.Windows.Forms.Label lblPromGan;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblGan;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblGast;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblArtCant;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnPreferencia;
        private System.Windows.Forms.Button btnNuevoDia;
        private System.Windows.Forms.Label lblGananciaDía;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnNuevoMes;
        private System.Windows.Forms.TabPage tbMisServis;
        private System.Windows.Forms.DataGridView dgvMisServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewButtonColumn EditarServicios;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarServicio;
        private System.Windows.Forms.GroupBox gbMisServicios;
        private System.Windows.Forms.Button btnCancelarMisServis;
        private System.Windows.Forms.Button btnAceptarMisServis;
        private System.Windows.Forms.TextBox txtNombreMisServicios;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtValorMisServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiServiNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MisServis;
        private System.Windows.Forms.DataGridViewTextBoxColumn MisServiCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentaDiaMisServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVendidoMisServicios;
        private System.Windows.Forms.DataGridViewButtonColumn MisServisVender;
        private System.Windows.Forms.DataGridViewButtonColumn MisServisNoVender;
        private System.Windows.Forms.DataGridViewButtonColumn EditarMisServicios;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarMisServicios;
        private System.Windows.Forms.Button btnIniSesion;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Button btnLicencia;
        private System.Windows.Forms.Button btnContraseña;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblNomPerfil;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnNomPerfilAcep;
        private PictureBoxEclipse pbePerfil;
        private System.Windows.Forms.OpenFileDialog ofdBuscarPerfil;
        private System.Windows.Forms.TextBox txtNomPerfil;
        private System.Windows.Forms.Button btnNomPerfilCance;
        private System.Windows.Forms.Label label29;
        private PictureBoxEclipse pbEmpleFoto;
        public System.Windows.Forms.ComboBox cbNombreTrabajador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtNombreStrock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnMedStick;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtCantStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentaDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtVendStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoCosteDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoCosto;
        private System.Windows.Forms.DataGridViewButtonColumn VenderStock;
        private System.Windows.Forms.DataGridViewButtonColumn CancelarVentaStock;
        private System.Windows.Forms.DataGridViewButtonColumn StockEliminar;
    }
}

