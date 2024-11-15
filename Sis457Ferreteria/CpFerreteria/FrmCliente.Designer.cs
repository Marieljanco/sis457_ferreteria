namespace CpFerreteria
{
	partial class FrmCliente
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
			this.txtPrimerApellido = new System.Windows.Forms.TextBox();
			this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblSegundoApellido = new System.Windows.Forms.Label();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
			this.lblPrimerApellido = new System.Windows.Forms.Label();
			this.lblNombres = new System.Windows.Forms.Label();
			this.lblCedulaIdentidad = new System.Windows.Forms.Label();
			this.pnlAcciones = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.txtSegundoApellido = new System.Windows.Forms.TextBox();
			this.lblCelular = new System.Windows.Forms.Label();
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
			this.pnlAcciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			this.gbxLista.SuspendLayout();
			this.gbxDatos.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPrimerApellido
			// 
			this.txtPrimerApellido.Location = new System.Drawing.Point(155, 83);
			this.txtPrimerApellido.MaxLength = 50;
			this.txtPrimerApellido.Name = "txtPrimerApellido";
			this.txtPrimerApellido.Size = new System.Drawing.Size(142, 22);
			this.txtPrimerApellido.TabIndex = 12;
			// 
			// erpCedulaIdentidad
			// 
			this.erpCedulaIdentidad.ContainerControl = this;
			// 
			// erpNombres
			// 
			this.erpNombres.ContainerControl = this;
			// 
			// erpApellidos
			// 
			this.erpApellidos.ContainerControl = this;
			// 
			// erpCelular
			// 
			this.erpCelular.ContainerControl = this;
			// 
			// lblSegundoApellido
			// 
			this.lblSegundoApellido.AutoSize = true;
			this.lblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSegundoApellido.Location = new System.Drawing.Point(306, 30);
			this.lblSegundoApellido.Name = "lblSegundoApellido";
			this.lblSegundoApellido.Size = new System.Drawing.Size(118, 16);
			this.lblSegundoApellido.TabIndex = 6;
			this.lblSegundoApellido.Text = "Segundo Apellido:";
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(155, 55);
			this.txtNombres.MaxLength = 50;
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(142, 22);
			this.txtNombres.TabIndex = 4;
			// 
			// txtCedulaIdentidad
			// 
			this.txtCedulaIdentidad.Location = new System.Drawing.Point(155, 27);
			this.txtCedulaIdentidad.MaxLength = 10;
			this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
			this.txtCedulaIdentidad.Size = new System.Drawing.Size(142, 22);
			this.txtCedulaIdentidad.TabIndex = 3;
			// 
			// lblPrimerApellido
			// 
			this.lblPrimerApellido.AutoSize = true;
			this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrimerApellido.Location = new System.Drawing.Point(15, 86);
			this.lblPrimerApellido.Name = "lblPrimerApellido";
			this.lblPrimerApellido.Size = new System.Drawing.Size(102, 16);
			this.lblPrimerApellido.TabIndex = 2;
			this.lblPrimerApellido.Text = "Primer Apellido:";
			// 
			// lblNombres
			// 
			this.lblNombres.AutoSize = true;
			this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombres.Location = new System.Drawing.Point(15, 58);
			this.lblNombres.Name = "lblNombres";
			this.lblNombres.Size = new System.Drawing.Size(66, 16);
			this.lblNombres.TabIndex = 1;
			this.lblNombres.Text = "Nombres:";
			// 
			// lblCedulaIdentidad
			// 
			this.lblCedulaIdentidad.AutoSize = true;
			this.lblCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCedulaIdentidad.Location = new System.Drawing.Point(15, 30);
			this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
			this.lblCedulaIdentidad.Size = new System.Drawing.Size(131, 16);
			this.lblCedulaIdentidad.TabIndex = 0;
			this.lblCedulaIdentidad.Text = "Cédula de Identidad:";
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
			this.pnlAcciones.TabIndex = 26;
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(190)))), ((int)(((byte)(228)))));
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Image = global::CpFerreteria.Properties.Resources.cancelferre;
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(512, 2);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(90, 39);
			this.btnCerrar.TabIndex = 13;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(190)))), ((int)(((byte)(228)))));
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = global::CpFerreteria.Properties.Resources.deleteferre;
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(408, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(98, 39);
			this.btnEliminar.TabIndex = 12;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(190)))), ((int)(((byte)(228)))));
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = global::CpFerreteria.Properties.Resources.editferre;
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(314, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(88, 39);
			this.btnEditar.TabIndex = 11;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(190)))), ((int)(((byte)(228)))));
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = global::CpFerreteria.Properties.Resources.newferre;
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(216, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(92, 39);
			this.btnNuevo.TabIndex = 10;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// txtParametro
			// 
			this.txtParametro.Location = new System.Drawing.Point(261, 52);
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(475, 20);
			this.txtParametro.TabIndex = 23;
			this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBusqueda.Location = new System.Drawing.Point(12, 55);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(214, 16);
			this.lblBusqueda.TabIndex = 22;
			this.lblBusqueda.Text = "Buscar por CI o Nombre Completo:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(10, 13);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(820, 32);
			this.lblTitulo.TabIndex = 21;
			this.lblTitulo.Text = "Clientes";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// gbxLista
			// 
			this.gbxLista.Controls.Add(this.dgvLista);
			this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxLista.Location = new System.Drawing.Point(15, 89);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Size = new System.Drawing.Size(815, 162);
			this.gbxLista.TabIndex = 25;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de Clientes";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(306, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Usuario:";
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(438, 55);
			this.txtCelular.MaxLength = 8;
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(142, 22);
			this.txtCelular.TabIndex = 16;
			// 
			// txtSegundoApellido
			// 
			this.txtSegundoApellido.Location = new System.Drawing.Point(438, 27);
			this.txtSegundoApellido.MaxLength = 50;
			this.txtSegundoApellido.Name = "txtSegundoApellido";
			this.txtSegundoApellido.Size = new System.Drawing.Size(142, 22);
			this.txtSegundoApellido.TabIndex = 14;
			// 
			// lblCelular
			// 
			this.lblCelular.AutoSize = true;
			this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCelular.Location = new System.Drawing.Point(306, 58);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(52, 16);
			this.lblCelular.TabIndex = 13;
			this.lblCelular.Text = "Celular:";
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.txtUsuario);
			this.gbxDatos.Controls.Add(this.btnCancelar);
			this.gbxDatos.Controls.Add(this.btnGuardar);
			this.gbxDatos.Controls.Add(this.label1);
			this.gbxDatos.Controls.Add(this.txtCelular);
			this.gbxDatos.Controls.Add(this.txtSegundoApellido);
			this.gbxDatos.Controls.Add(this.lblCelular);
			this.gbxDatos.Controls.Add(this.txtPrimerApellido);
			this.gbxDatos.Controls.Add(this.lblSegundoApellido);
			this.gbxDatos.Controls.Add(this.txtNombres);
			this.gbxDatos.Controls.Add(this.txtCedulaIdentidad);
			this.gbxDatos.Controls.Add(this.lblPrimerApellido);
			this.gbxDatos.Controls.Add(this.lblNombres);
			this.gbxDatos.Controls.Add(this.lblCedulaIdentidad);
			this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxDatos.Location = new System.Drawing.Point(15, 307);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(819, 123);
			this.gbxDatos.TabIndex = 27;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(438, 83);
			this.txtUsuario.MaxLength = 15;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(144, 22);
			this.txtUsuario.TabIndex = 20;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(126)))), ((int)(((byte)(189)))));
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = global::CpFerreteria.Properties.Resources.cancelar;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(701, 72);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(108, 47);
			this.btnCancelar.TabIndex = 30;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(126)))), ((int)(((byte)(189)))));
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Image = global::CpFerreteria.Properties.Resources.saveferre;
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(594, 72);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(101, 47);
			this.btnGuardar.TabIndex = 29;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(126)))), ((int)(((byte)(189)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = global::CpFerreteria.Properties.Resources.searchferre;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(742, 45);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(92, 39);
			this.btnBuscar.TabIndex = 28;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// FrmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(844, 442);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.pnlAcciones);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.lblBusqueda);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.gbxLista);
			this.Controls.Add(this.gbxDatos);
			this.Name = "FrmCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCliente";
			this.Load += new System.EventHandler(this.FrmCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
			this.pnlAcciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			this.gbxLista.ResumeLayout(false);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPrimerApellido;
		private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
		private System.Windows.Forms.Panel pnlAcciones;
		private System.Windows.Forms.TextBox txtParametro;
		private System.Windows.Forms.Label lblBusqueda;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox gbxLista;
		private System.Windows.Forms.DataGridView dgvLista;
		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.TextBox txtSegundoApellido;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.Label lblSegundoApellido;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.TextBox txtCedulaIdentidad;
		private System.Windows.Forms.Label lblPrimerApellido;
		private System.Windows.Forms.Label lblNombres;
		private System.Windows.Forms.Label lblCedulaIdentidad;
		private System.Windows.Forms.ErrorProvider erpNombres;
		private System.Windows.Forms.ErrorProvider erpApellidos;
		private System.Windows.Forms.ErrorProvider erpCelular;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
	}
}