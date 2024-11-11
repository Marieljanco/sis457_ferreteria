﻿namespace CpFerreteria
{
	partial class FrmProducto
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
			this.erpStock = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCodigo = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnBuscar = new System.Windows.Forms.Button();
			this.erpUnidadMedida = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.cbxCategoria = new System.Windows.Forms.ComboBox();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.nudPrecioVenta = new System.Windows.Forms.NumericUpDown();
			this.nudStock = new System.Windows.Forms.NumericUpDown();
			this.lblPrecioVenta = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblUnidadMedida = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnEditar = new System.Windows.Forms.Button();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.pnlAcciones = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.erpStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpUnidadMedida)).BeginInit();
			this.gbxDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			this.pnlAcciones.SuspendLayout();
			this.gbxLista.SuspendLayout();
			this.SuspendLayout();
			// 
			// erpStock
			// 
			this.erpStock.ContainerControl = this;
			// 
			// erpPrecioVenta
			// 
			this.erpPrecioVenta.ContainerControl = this;
			// 
			// erpCodigo
			// 
			this.erpCodigo.ContainerControl = this;
			// 
			// btnBuscar
			// 
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(742, 45);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(92, 39);
			this.btnBuscar.TabIndex = 10;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// erpUnidadMedida
			// 
			this.erpUnidadMedida.ContainerControl = this;
			// 
			// btnCancelar
			// 
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(707, 80);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(108, 39);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(600, 80);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(101, 39);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.cbxCategoria);
			this.gbxDatos.Controls.Add(this.lblCategoria);
			this.gbxDatos.Controls.Add(this.lblMarca);
			this.gbxDatos.Controls.Add(this.txtMarca);
			this.gbxDatos.Controls.Add(this.btnCancelar);
			this.gbxDatos.Controls.Add(this.btnGuardar);
			this.gbxDatos.Controls.Add(this.nudPrecioVenta);
			this.gbxDatos.Controls.Add(this.nudStock);
			this.gbxDatos.Controls.Add(this.lblPrecioVenta);
			this.gbxDatos.Controls.Add(this.lblStock);
			this.gbxDatos.Controls.Add(this.cbxUnidadMedida);
			this.gbxDatos.Controls.Add(this.txtDescripcion);
			this.gbxDatos.Controls.Add(this.txtCodigo);
			this.gbxDatos.Controls.Add(this.lblUnidadMedida);
			this.gbxDatos.Controls.Add(this.lblDescripcion);
			this.gbxDatos.Controls.Add(this.lblCodigo);
			this.gbxDatos.Location = new System.Drawing.Point(15, 307);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(819, 123);
			this.gbxDatos.TabIndex = 13;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// cbxCategoria
			// 
			this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCategoria.FormattingEnabled = true;
			this.cbxCategoria.Items.AddRange(new object[] {
            "Caja",
            "Docena",
            "Paquete",
            "Pliego",
            "Unidad"});
			this.cbxCategoria.Location = new System.Drawing.Point(689, 27);
			this.cbxCategoria.Name = "cbxCategoria";
			this.cbxCategoria.Size = new System.Drawing.Size(120, 21);
			this.cbxCategoria.TabIndex = 15;
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(606, 30);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(57, 13);
			this.lblCategoria.TabIndex = 14;
			this.lblCategoria.Text = "Categoría:";
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(15, 86);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(40, 13);
			this.lblMarca.TabIndex = 13;
			this.lblMarca.Text = "Marca:";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(103, 82);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(194, 20);
			this.txtMarca.TabIndex = 12;
			// 
			// nudPrecioVenta
			// 
			this.nudPrecioVenta.Location = new System.Drawing.Point(436, 85);
			this.nudPrecioVenta.Name = "nudPrecioVenta";
			this.nudPrecioVenta.Size = new System.Drawing.Size(143, 20);
			this.nudPrecioVenta.TabIndex = 9;
			// 
			// nudStock
			// 
			this.nudStock.Location = new System.Drawing.Point(436, 57);
			this.nudStock.Name = "nudStock";
			this.nudStock.Size = new System.Drawing.Size(143, 20);
			this.nudStock.TabIndex = 8;
			// 
			// lblPrecioVenta
			// 
			this.lblPrecioVenta.AutoSize = true;
			this.lblPrecioVenta.Location = new System.Drawing.Point(316, 87);
			this.lblPrecioVenta.Name = "lblPrecioVenta";
			this.lblPrecioVenta.Size = new System.Drawing.Size(86, 13);
			this.lblPrecioVenta.TabIndex = 7;
			this.lblPrecioVenta.Text = "Precio de Venta:";
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.Location = new System.Drawing.Point(316, 59);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(38, 13);
			this.lblStock.TabIndex = 6;
			this.lblStock.Text = "Stock:";
			// 
			// cbxUnidadMedida
			// 
			this.cbxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxUnidadMedida.FormattingEnabled = true;
			this.cbxUnidadMedida.Items.AddRange(new object[] {
            "Caja",
            "Docena",
            "Paquete",
            "Pliego",
            "Unidad"});
			this.cbxUnidadMedida.Location = new System.Drawing.Point(436, 28);
			this.cbxUnidadMedida.Name = "cbxUnidadMedida";
			this.cbxUnidadMedida.Size = new System.Drawing.Size(143, 21);
			this.cbxUnidadMedida.TabIndex = 5;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(103, 56);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(194, 20);
			this.txtDescripcion.TabIndex = 4;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(103, 28);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(194, 20);
			this.txtCodigo.TabIndex = 3;
			// 
			// lblUnidadMedida
			// 
			this.lblUnidadMedida.AutoSize = true;
			this.lblUnidadMedida.Location = new System.Drawing.Point(316, 31);
			this.lblUnidadMedida.Name = "lblUnidadMedida";
			this.lblUnidadMedida.Size = new System.Drawing.Size(97, 13);
			this.lblUnidadMedida.TabIndex = 2;
			this.lblUnidadMedida.Text = "Unidad de Medida:";
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(15, 58);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
			this.lblDescripcion.TabIndex = 1;
			this.lblDescripcion.Text = "Descripción:";
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(15, 30);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(43, 13);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Código:";
			// 
			// btnNuevo
			// 
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(205, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(92, 39);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// erpDescripcion
			// 
			this.erpDescripcion.ContainerControl = this;
			// 
			// txtParametro
			// 
			this.txtParametro.Location = new System.Drawing.Point(242, 52);
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(494, 20);
			this.txtParametro.TabIndex = 9;
			this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.Location = new System.Drawing.Point(12, 55);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(165, 13);
			this.lblBusqueda.TabIndex = 8;
			this.lblBusqueda.Text = "Buscar por Código o Descripción:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(10, 13);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(820, 32);
			this.lblTitulo.TabIndex = 7;
			this.lblTitulo.Text = "Productos";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnEditar
			// 
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(303, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(88, 39);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// dgvLista
			// 
			this.dgvLista.AllowUserToAddRows = false;
			this.dgvLista.AllowUserToDeleteRows = false;
			this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.Location = new System.Drawing.Point(6, 23);
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.ReadOnly = true;
			this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLista.Size = new System.Drawing.Size(803, 133);
			this.dgvLista.TabIndex = 0;
			// 
			// pnlAcciones
			// 
			this.pnlAcciones.Controls.Add(this.btnCerrar);
			this.pnlAcciones.Controls.Add(this.btnEliminar);
			this.pnlAcciones.Controls.Add(this.btnEditar);
			this.pnlAcciones.Controls.Add(this.btnNuevo);
			this.pnlAcciones.Location = new System.Drawing.Point(15, 258);
			this.pnlAcciones.Name = "pnlAcciones";
			this.pnlAcciones.Size = new System.Drawing.Size(819, 43);
			this.pnlAcciones.TabIndex = 12;
			// 
			// btnCerrar
			// 
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(501, 2);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(90, 39);
			this.btnCerrar.TabIndex = 9;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(397, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(98, 39);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// gbxLista
			// 
			this.gbxLista.Controls.Add(this.dgvLista);
			this.gbxLista.Location = new System.Drawing.Point(15, 89);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Size = new System.Drawing.Size(815, 162);
			this.gbxLista.TabIndex = 11;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de Productos";
			// 
			// FrmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 442);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.lblBusqueda);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.pnlAcciones);
			this.Controls.Add(this.gbxLista);
			this.Name = "FrmProducto";
			this.Text = "FrmProducto";
			this.Load += new System.EventHandler(this.FrmProducto_Load);
			((System.ComponentModel.ISupportInitialize)(this.erpStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpUnidadMedida)).EndInit();
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			this.pnlAcciones.ResumeLayout(false);
			this.gbxLista.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ErrorProvider erpStock;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.NumericUpDown nudPrecioVenta;
		private System.Windows.Forms.NumericUpDown nudStock;
		private System.Windows.Forms.Label lblPrecioVenta;
		private System.Windows.Forms.Label lblStock;
		private System.Windows.Forms.ComboBox cbxUnidadMedida;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblUnidadMedida;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.TextBox txtParametro;
		private System.Windows.Forms.Label lblBusqueda;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel pnlAcciones;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox gbxLista;
		private System.Windows.Forms.DataGridView dgvLista;
		private System.Windows.Forms.ErrorProvider erpPrecioVenta;
		private System.Windows.Forms.ErrorProvider erpCodigo;
		private System.Windows.Forms.ErrorProvider erpUnidadMedida;
		private System.Windows.Forms.ErrorProvider erpDescripcion;
		private System.Windows.Forms.ComboBox cbxCategoria;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.TextBox txtMarca;
	}
}