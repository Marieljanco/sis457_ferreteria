namespace CpFerreteria
{
	partial class FrmBuscarClientes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dgvListaCliente = new System.Windows.Forms.DataGridView();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblParametro = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(126)))), ((int)(((byte)(189)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(576, 464);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(117, 48);
			this.btnCancelar.TabIndex = 78;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(126)))), ((int)(((byte)(189)))));
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSeleccionar.Location = new System.Drawing.Point(304, 464);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(117, 48);
			this.btnSeleccionar.TabIndex = 77;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSeleccionar.UseVisualStyleBackColor = false;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(126)))), ((int)(((byte)(189)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Location = new System.Drawing.Point(411, 95);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnBuscar.Size = new System.Drawing.Size(57, 39);
			this.btnBuscar.TabIndex = 76;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// dgvListaCliente
			// 
			this.dgvListaCliente.AllowUserToAddRows = false;
			this.dgvListaCliente.AllowUserToDeleteRows = false;
			this.dgvListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListaCliente.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvListaCliente.Location = new System.Drawing.Point(69, 167);
			this.dgvListaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvListaCliente.Name = "dgvListaCliente";
			this.dgvListaCliente.ReadOnly = true;
			this.dgvListaCliente.RowHeadersWidth = 51;
			this.dgvListaCliente.RowTemplate.Height = 24;
			this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaCliente.Size = new System.Drawing.Size(929, 279);
			this.dgvListaCliente.TabIndex = 75;
			// 
			// txtParametro
			// 
			this.txtParametro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtParametro.Location = new System.Drawing.Point(155, 105);
			this.txtParametro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtParametro.Size = new System.Drawing.Size(224, 28);
			this.txtParametro.TabIndex = 72;
			this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
			// 
			// lblParametro
			// 
			this.lblParametro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lblParametro.AutoSize = true;
			this.lblParametro.BackColor = System.Drawing.Color.Transparent;
			this.lblParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblParametro.Location = new System.Drawing.Point(71, 105);
			this.lblParametro.Name = "lblParametro";
			this.lblParametro.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblParametro.Size = new System.Drawing.Size(71, 22);
			this.lblParametro.TabIndex = 73;
			this.lblParametro.Text = "Buscar:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(69, 43);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(929, 42);
			this.lblTitulo.TabIndex = 74;
			this.lblTitulo.Text = "Lista de Productos";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FrmBuscarClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dgvListaCliente);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.lblParametro);
			this.Controls.Add(this.lblTitulo);
			this.Name = "FrmBuscarClientes";
			this.Text = "FrmBuscarClientes";
			this.Load += new System.EventHandler(this.FrmBuscarClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridView dgvListaCliente;
		private System.Windows.Forms.TextBox txtParametro;
		private System.Windows.Forms.Label lblParametro;
		private System.Windows.Forms.Label lblTitulo;
	}
}