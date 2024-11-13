﻿namespace CpFerreteria
{
	partial class FrmAutenticacion
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
			this.txtClave = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblClave = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpClave = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpClave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(107, 218);
			this.txtClave.MaxLength = 15;
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(140, 20);
			this.txtClave.TabIndex = 13;
			this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(107, 185);
			this.txtUsuario.MaxLength = 10;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(140, 20);
			this.txtUsuario.TabIndex = 12;
			// 
			// lblClave
			// 
			this.lblClave.AutoSize = true;
			this.lblClave.Location = new System.Drawing.Point(14, 221);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(64, 13);
			this.lblClave.TabIndex = 11;
			this.lblClave.Text = "Contraseña:";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(14, 188);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(46, 13);
			this.lblUsuario.TabIndex = 10;
			this.lblUsuario.Text = "Usuario:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 7);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(250, 32);
			this.lblTitulo.TabIndex = 9;
			this.lblTitulo.Text = "Iniciar Sesión";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// erpUsuario
			// 
			this.erpUsuario.ContainerControl = this;
			// 
			// erpClave
			// 
			this.erpClave.ContainerControl = this;
			// 
			// btnSalir
			// 
			this.btnSalir.Image = global::CpFerreteria.Properties.Resources.close;
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(167, 256);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(80, 43);
			this.btnSalir.TabIndex = 16;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnIngresar
			// 
			this.btnIngresar.Image = global::CpFerreteria.Properties.Resources.login_okferre;
			this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIngresar.Location = new System.Drawing.Point(58, 256);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(103, 43);
			this.btnIngresar.TabIndex = 15;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// pctLogo
			// 
			this.pctLogo.Image = global::CpFerreteria.Properties.Resources.securityferre;
			this.pctLogo.Location = new System.Drawing.Point(87, 42);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(100, 113);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 14;
			this.pctLogo.TabStop = false;
			// 
			// FrmAutenticacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 323);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.pctLogo);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblTitulo);
			this.Name = "FrmAutenticacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autenticacion";
			((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpClave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblClave;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.ErrorProvider erpUsuario;
		private System.Windows.Forms.ErrorProvider erpClave;
	}
}