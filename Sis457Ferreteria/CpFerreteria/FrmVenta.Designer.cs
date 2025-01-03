﻿namespace CpFerreteria
{
    partial class FrmVenta
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblCedulaIdentidad = new System.Windows.Forms.Label();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.lblCambio = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.nudPago = new System.Windows.Forms.NumericUpDown();
			this.lblPago = new System.Windows.Forms.Label();
			this.gbxInformacionVenta = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
			this.gbxInformacionCliente = new System.Windows.Forms.GroupBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.btnRegistrarProducto = new System.Windows.Forms.Button();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAgregarProducto = new System.Windows.Forms.Button();
			this.dgvListaDetalle = new System.Windows.Forms.DataGridView();
			this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.nudCambio = new System.Windows.Forms.NumericUpDown();
			this.gbxInformacionProducto = new System.Windows.Forms.GroupBox();
			this.txtIdProducto = new System.Windows.Forms.TextBox();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.lblProducto = new System.Windows.Forms.Label();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.txtCodigoProducto = new System.Windows.Forms.TextBox();
			this.lblCodigoProducto = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPago)).BeginInit();
			this.gbxInformacionVenta.SuspendLayout();
			this.gbxInformacionCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCambio)).BeginInit();
			this.gbxInformacionProducto.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtStock
			// 
			this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtStock.Enabled = false;
			this.txtStock.Location = new System.Drawing.Point(807, 65);
			this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(141, 28);
			this.txtStock.TabIndex = 30;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtPrecio.Enabled = false;
			this.txtPrecio.Location = new System.Drawing.Point(627, 65);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(149, 28);
			this.txtPrecio.TabIndex = 29;
			// 
			// lblPrecio
			// 
			this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.Location = new System.Drawing.Point(623, 36);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(66, 22);
			this.lblPrecio.TabIndex = 25;
			this.lblPrecio.Text = "Precio:";
			// 
			// lblCedulaIdentidad
			// 
			this.lblCedulaIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCedulaIdentidad.AutoSize = true;
			this.lblCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCedulaIdentidad.Location = new System.Drawing.Point(5, 30);
			this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
			this.lblCedulaIdentidad.Size = new System.Drawing.Size(175, 22);
			this.lblCedulaIdentidad.TabIndex = 1;
			this.lblCedulaIdentidad.Text = "Cédula de Identidad:";
			// 
			// nudCantidad
			// 
			this.nudCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.nudCantidad.Location = new System.Drawing.Point(987, 65);
			this.nudCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(120, 28);
			this.nudCantidad.TabIndex = 24;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(379, 55);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(319, 28);
			this.txtNombre.TabIndex = 20;
			// 
			// lblNombre
			// 
			this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(375, 30);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(78, 22);
			this.lblNombre.TabIndex = 19;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblStock
			// 
			this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblStock.AutoSize = true;
			this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStock.Location = new System.Drawing.Point(803, 36);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(60, 22);
			this.lblStock.TabIndex = 27;
			this.lblStock.Text = "Stock:";
			// 
			// lblCambio
			// 
			this.lblCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCambio.AutoSize = true;
			this.lblCambio.BackColor = System.Drawing.Color.Transparent;
			this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCambio.Location = new System.Drawing.Point(669, 654);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(76, 22);
			this.lblCambio.TabIndex = 52;
			this.lblCambio.Text = "Cambio:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(5, 30);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(65, 22);
			this.lblFecha.TabIndex = 1;
			this.lblFecha.Text = "Fecha:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Enabled = false;
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(11, 57);
			this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(219, 27);
			this.dtpFecha.TabIndex = 0;
			this.dtpFecha.Value = new System.DateTime(2024, 6, 7, 21, 24, 35, 0);
			// 
			// nudPago
			// 
			this.nudPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nudPago.DecimalPlaces = 2;
			this.nudPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudPago.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nudPago.Location = new System.Drawing.Point(376, 694);
			this.nudPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudPago.Name = "nudPago";
			this.nudPago.Size = new System.Drawing.Size(192, 28);
			this.nudPago.TabIndex = 51;
			// 
			// lblPago
			// 
			this.lblPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblPago.AutoSize = true;
			this.lblPago.BackColor = System.Drawing.Color.Transparent;
			this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPago.Location = new System.Drawing.Point(372, 654);
			this.lblPago.Name = "lblPago";
			this.lblPago.Size = new System.Drawing.Size(91, 22);
			this.lblPago.TabIndex = 50;
			this.lblPago.Text = "Paga con:";
			// 
			// gbxInformacionVenta
			// 
			this.gbxInformacionVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbxInformacionVenta.BackColor = System.Drawing.Color.Thistle;
			this.gbxInformacionVenta.Controls.Add(this.lblFecha);
			this.gbxInformacionVenta.Controls.Add(this.dtpFecha);
			this.gbxInformacionVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxInformacionVenta.Location = new System.Drawing.Point(36, 50);
			this.gbxInformacionVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxInformacionVenta.Name = "gbxInformacionVenta";
			this.gbxInformacionVenta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxInformacionVenta.Size = new System.Drawing.Size(371, 94);
			this.gbxInformacionVenta.TabIndex = 42;
			this.gbxInformacionVenta.TabStop = false;
			this.gbxInformacionVenta.Text = "Información Venta";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 32);
			this.label1.TabIndex = 41;
			this.label1.Text = "Registro de Ventas";
			// 
			// txtCedulaIdentidad
			// 
			this.txtCedulaIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCedulaIdentidad.Location = new System.Drawing.Point(11, 55);
			this.txtCedulaIdentidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
			this.txtCedulaIdentidad.Size = new System.Drawing.Size(285, 28);
			this.txtCedulaIdentidad.TabIndex = 2;
			// 
			// gbxInformacionCliente
			// 
			this.gbxInformacionCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbxInformacionCliente.BackColor = System.Drawing.Color.Thistle;
			this.gbxInformacionCliente.Controls.Add(this.txtNombre);
			this.gbxInformacionCliente.Controls.Add(this.lblNombre);
			this.gbxInformacionCliente.Controls.Add(this.btnBuscarCliente);
			this.gbxInformacionCliente.Controls.Add(this.txtCedulaIdentidad);
			this.gbxInformacionCliente.Controls.Add(this.lblCedulaIdentidad);
			this.gbxInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxInformacionCliente.Location = new System.Drawing.Point(573, 50);
			this.gbxInformacionCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxInformacionCliente.Name = "gbxInformacionCliente";
			this.gbxInformacionCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxInformacionCliente.Size = new System.Drawing.Size(715, 94);
			this.gbxInformacionCliente.TabIndex = 43;
			this.gbxInformacionCliente.TabStop = false;
			this.gbxInformacionCliente.Text = "Información Cliente";
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(190)))), ((int)(((byte)(228)))));
			this.btnBuscarCliente.Location = new System.Drawing.Point(301, 49);
			this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnBuscarCliente.Size = new System.Drawing.Size(45, 39);
			this.btnBuscarCliente.TabIndex = 18;
			this.btnBuscarCliente.UseVisualStyleBackColor = false;
			this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
			// 
			// lblCantidad
			// 
			this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(980, 36);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(87, 22);
			this.lblCantidad.TabIndex = 23;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// btnRegistrarProducto
			// 
			this.btnRegistrarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(126)))), ((int)(((byte)(189)))));
			this.btnRegistrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRegistrarProducto.Location = new System.Drawing.Point(981, 636);
			this.btnRegistrarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRegistrarProducto.Name = "btnRegistrarProducto";
			this.btnRegistrarProducto.Size = new System.Drawing.Size(192, 100);
			this.btnRegistrarProducto.TabIndex = 49;
			this.btnRegistrarProducto.Text = "Registrar";
			this.btnRegistrarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRegistrarProducto.UseVisualStyleBackColor = false;
			this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(57, 694);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(192, 28);
			this.txtTotal.TabIndex = 48;
			this.txtTotal.Text = "0";
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTotal.AutoSize = true;
			this.lblTotal.BackColor = System.Drawing.Color.Transparent;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(53, 654);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(124, 22);
			this.lblTotal.TabIndex = 47;
			this.lblTotal.Text = "Total a Pagar:";
			// 
			// btnAgregarProducto
			// 
			this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(126)))), ((int)(((byte)(189)))));
			this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAgregarProducto.Location = new System.Drawing.Point(1157, 166);
			this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAgregarProducto.Name = "btnAgregarProducto";
			this.btnAgregarProducto.Size = new System.Drawing.Size(108, 112);
			this.btnAgregarProducto.TabIndex = 46;
			this.btnAgregarProducto.Text = "Agregar";
			this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAgregarProducto.UseVisualStyleBackColor = false;
			this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
			// 
			// dgvListaDetalle
			// 
			this.dgvListaDetalle.AllowUserToAddRows = false;
			this.dgvListaDetalle.AllowUserToDeleteRows = false;
			this.dgvListaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.precioUnitario,
            this.cantidad,
            this.subtotal,
            this.btnEliminar});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListaDetalle.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvListaDetalle.Location = new System.Drawing.Point(36, 297);
			this.dgvListaDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvListaDetalle.Name = "dgvListaDetalle";
			this.dgvListaDetalle.ReadOnly = true;
			this.dgvListaDetalle.RowHeadersWidth = 51;
			this.dgvListaDetalle.RowTemplate.Height = 24;
			this.dgvListaDetalle.Size = new System.Drawing.Size(1229, 331);
			this.dgvListaDetalle.TabIndex = 45;
			this.dgvListaDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDetalle_CellContentClick);
			// 
			// idProducto
			// 
			this.idProducto.HeaderText = "idProducto";
			this.idProducto.MinimumWidth = 6;
			this.idProducto.Name = "idProducto";
			this.idProducto.ReadOnly = true;
			this.idProducto.Visible = false;
			this.idProducto.Width = 125;
			// 
			// nombreProducto
			// 
			this.nombreProducto.HeaderText = "Producto";
			this.nombreProducto.MinimumWidth = 6;
			this.nombreProducto.Name = "nombreProducto";
			this.nombreProducto.ReadOnly = true;
			this.nombreProducto.Width = 111;
			// 
			// precioUnitario
			// 
			this.precioUnitario.HeaderText = "Precio Unidad";
			this.precioUnitario.MinimumWidth = 6;
			this.precioUnitario.Name = "precioUnitario";
			this.precioUnitario.ReadOnly = true;
			this.precioUnitario.Width = 152;
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "Cantidad";
			this.cantidad.MinimumWidth = 6;
			this.cantidad.Name = "cantidad";
			this.cantidad.ReadOnly = true;
			this.cantidad.Width = 111;
			// 
			// subtotal
			// 
			this.subtotal.HeaderText = "Sub Total";
			this.subtotal.MinimumWidth = 6;
			this.subtotal.Name = "subtotal";
			this.subtotal.ReadOnly = true;
			this.subtotal.Width = 117;
			// 
			// btnEliminar
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle5;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.HeaderText = "";
			this.btnEliminar.MinimumWidth = 6;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.ReadOnly = true;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.Width = 6;
			// 
			// nudCambio
			// 
			this.nudCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nudCambio.DecimalPlaces = 2;
			this.nudCambio.Enabled = false;
			this.nudCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudCambio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nudCambio.Location = new System.Drawing.Point(673, 695);
			this.nudCambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudCambio.Name = "nudCambio";
			this.nudCambio.Size = new System.Drawing.Size(192, 28);
			this.nudCambio.TabIndex = 53;
			// 
			// gbxInformacionProducto
			// 
			this.gbxInformacionProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbxInformacionProducto.BackColor = System.Drawing.Color.Thistle;
			this.gbxInformacionProducto.Controls.Add(this.txtIdProducto);
			this.gbxInformacionProducto.Controls.Add(this.txtStock);
			this.gbxInformacionProducto.Controls.Add(this.txtPrecio);
			this.gbxInformacionProducto.Controls.Add(this.lblStock);
			this.gbxInformacionProducto.Controls.Add(this.lblPrecio);
			this.gbxInformacionProducto.Controls.Add(this.nudCantidad);
			this.gbxInformacionProducto.Controls.Add(this.lblCantidad);
			this.gbxInformacionProducto.Controls.Add(this.txtProducto);
			this.gbxInformacionProducto.Controls.Add(this.lblProducto);
			this.gbxInformacionProducto.Controls.Add(this.btnBuscarProducto);
			this.gbxInformacionProducto.Controls.Add(this.txtCodigoProducto);
			this.gbxInformacionProducto.Controls.Add(this.lblCodigoProducto);
			this.gbxInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxInformacionProducto.Location = new System.Drawing.Point(36, 166);
			this.gbxInformacionProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxInformacionProducto.Name = "gbxInformacionProducto";
			this.gbxInformacionProducto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxInformacionProducto.Size = new System.Drawing.Size(1115, 112);
			this.gbxInformacionProducto.TabIndex = 44;
			this.gbxInformacionProducto.TabStop = false;
			this.gbxInformacionProducto.Text = "Información Producto";
			// 
			// txtIdProducto
			// 
			this.txtIdProducto.BackColor = System.Drawing.Color.Thistle;
			this.txtIdProducto.Location = new System.Drawing.Point(377, 36);
			this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtIdProducto.Name = "txtIdProducto";
			this.txtIdProducto.Size = new System.Drawing.Size(69, 28);
			this.txtIdProducto.TabIndex = 32;
			this.txtIdProducto.Visible = false;
			// 
			// txtProducto
			// 
			this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtProducto.Enabled = false;
			this.txtProducto.Location = new System.Drawing.Point(277, 65);
			this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(329, 28);
			this.txtProducto.TabIndex = 20;
			// 
			// lblProducto
			// 
			this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblProducto.AutoSize = true;
			this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducto.Location = new System.Drawing.Point(273, 36);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(87, 22);
			this.lblProducto.TabIndex = 19;
			this.lblProducto.Text = "Producto:";
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(190)))), ((int)(((byte)(228)))));
			this.btnBuscarProducto.Location = new System.Drawing.Point(21, 39);
			this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBuscarProducto.Name = "btnBuscarProducto";
			this.btnBuscarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnBuscarProducto.Size = new System.Drawing.Size(64, 52);
			this.btnBuscarProducto.TabIndex = 18;
			this.btnBuscarProducto.UseVisualStyleBackColor = false;
			this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
			// 
			// txtCodigoProducto
			// 
			this.txtCodigoProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCodigoProducto.Enabled = false;
			this.txtCodigoProducto.Location = new System.Drawing.Point(105, 65);
			this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCodigoProducto.Name = "txtCodigoProducto";
			this.txtCodigoProducto.Size = new System.Drawing.Size(149, 28);
			this.txtCodigoProducto.TabIndex = 2;
			// 
			// lblCodigoProducto
			// 
			this.lblCodigoProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCodigoProducto.AutoSize = true;
			this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigoProducto.Location = new System.Drawing.Point(101, 36);
			this.lblCodigoProducto.Name = "lblCodigoProducto";
			this.lblCodigoProducto.Size = new System.Drawing.Size(149, 22);
			this.lblCodigoProducto.TabIndex = 1;
			this.lblCodigoProducto.Text = "Código Producto:";
			// 
			// FrmVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(1317, 750);
			this.Controls.Add(this.lblCambio);
			this.Controls.Add(this.nudPago);
			this.Controls.Add(this.lblPago);
			this.Controls.Add(this.gbxInformacionVenta);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbxInformacionCliente);
			this.Controls.Add(this.btnRegistrarProducto);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnAgregarProducto);
			this.Controls.Add(this.dgvListaDetalle);
			this.Controls.Add(this.nudCambio);
			this.Controls.Add(this.gbxInformacionProducto);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmVenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::: Venta - Ferreteria :::";
			this.Load += new System.EventHandler(this.FrmVenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPago)).EndInit();
			this.gbxInformacionVenta.ResumeLayout(false);
			this.gbxInformacionVenta.PerformLayout();
			this.gbxInformacionCliente.ResumeLayout(false);
			this.gbxInformacionCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCambio)).EndInit();
			this.gbxInformacionProducto.ResumeLayout(false);
			this.gbxInformacionProducto.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.GroupBox gbxInformacionVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.GroupBox gbxInformacionCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvListaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.NumericUpDown nudCambio;
        private System.Windows.Forms.GroupBox gbxInformacionProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
		private System.Windows.Forms.TextBox txtIdProducto;
	}
}