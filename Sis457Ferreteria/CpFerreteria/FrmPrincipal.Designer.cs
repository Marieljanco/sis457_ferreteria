namespace CpFerreteria
{
    partial class FrmPrincipal
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
			this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
			this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
			this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
			this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
			this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
			this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
			this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
			this.btnCaProductos = new C1.Win.Ribbon.RibbonButton();
			this.btnCaProveedores = new C1.Win.Ribbon.RibbonButton();
			this.btnCaClientes = new C1.Win.Ribbon.RibbonButton();
			this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
			this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
			this.btnCjCompras = new C1.Win.Ribbon.RibbonButton();
			this.btnCjVentas = new C1.Win.Ribbon.RibbonButton();
			this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
			this.btnCjArqueoDiario = new C1.Win.Ribbon.RibbonButton();
			this.ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
			this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
			this.btnAdEmpleado = new C1.Win.Ribbon.RibbonButton();
			this.btnAdRoles = new C1.Win.Ribbon.RibbonButton();
			this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Ribbon1
			// 
			this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
			//this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
			this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
			this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
			this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
			this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.c1Ribbon1.Name = "c1Ribbon1";
			this.c1Ribbon1.QatHolder = this.ribbonQat1;
			this.c1Ribbon1.Size = new System.Drawing.Size(1067, 201);
			this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
			this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
			this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
			this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
			// 
			// ribbonApplicationMenu1
			// 
			this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
			// 
			// ribbonBottomToolBar1
			// 
			this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
			// 
			// ribbonConfigToolBar1
			// 
			this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
			// 
			// ribbonQat1
			// 
			this.ribbonQat1.Name = "ribbonQat1";
			// 
			// ribbonTab1
			// 
			this.ribbonTab1.Groups.Add(this.ribbonGroup1);
			this.ribbonTab1.Name = "ribbonTab1";
			this.ribbonTab1.Text = "Catálogo";
			// 
			// ribbonGroup1
			// 
			this.ribbonGroup1.Items.Add(this.btnCaProductos);
			this.ribbonGroup1.Items.Add(this.btnCaProveedores);
			this.ribbonGroup1.Items.Add(this.btnCaClientes);
			this.ribbonGroup1.Name = "ribbonGroup1";
			this.ribbonGroup1.Text = "Administración de Catálogo";
			// 
			// btnCaProductos
			// 
			this.btnCaProductos.Name = "btnCaProductos";
			this.btnCaProductos.Text = "Productos";
			this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
			// 
			// btnCaProveedores
			// 
			this.btnCaProveedores.Name = "btnCaProveedores";
			this.btnCaProveedores.Text = "Proveedores";
			// 
			// btnCaClientes
			// 
			this.btnCaClientes.Name = "btnCaClientes";
			this.btnCaClientes.Text = "Clientes";
			this.btnCaClientes.Click += new System.EventHandler(this.btnCaClientes_Click);
			// 
			// ribbonTab2
			// 
			this.ribbonTab2.Groups.Add(this.ribbonGroup2);
			this.ribbonTab2.Groups.Add(this.ribbonGroup3);
			this.ribbonTab2.Name = "ribbonTab2";
			this.ribbonTab2.Text = "Caja";
			// 
			// ribbonGroup2
			// 
			this.ribbonGroup2.Items.Add(this.btnCjCompras);
			this.ribbonGroup2.Items.Add(this.btnCjVentas);
			this.ribbonGroup2.Name = "ribbonGroup2";
			this.ribbonGroup2.Text = "Gestión";
			// 
			// btnCjCompras
			// 
			this.btnCjCompras.Name = "btnCjCompras";
			this.btnCjCompras.Text = "Compras";
			// 
			// btnCjVentas
			// 
			this.btnCjVentas.Name = "btnCjVentas";
			this.btnCjVentas.Text = "Ventas";
			this.btnCjVentas.Click += new System.EventHandler(this.btnCjVentas_Click);
			// 
			// ribbonGroup3
			// 
			this.ribbonGroup3.Items.Add(this.btnCjArqueoDiario);
			this.ribbonGroup3.Name = "ribbonGroup3";
			this.ribbonGroup3.Text = "Arqueo de Caja";
			// 
			// btnCjArqueoDiario
			// 
			this.btnCjArqueoDiario.Name = "btnCjArqueoDiario";
			this.btnCjArqueoDiario.Text = "Arqueo Diario";
			// 
			// ribbonTab3
			// 
			this.ribbonTab3.Groups.Add(this.ribbonGroup4);
			this.ribbonTab3.Name = "ribbonTab3";
			this.ribbonTab3.Text = "Administración";
			// 
			// ribbonGroup4
			// 
			this.ribbonGroup4.Items.Add(this.btnAdEmpleado);
			this.ribbonGroup4.Items.Add(this.btnAdRoles);
			this.ribbonGroup4.Name = "ribbonGroup4";
			this.ribbonGroup4.Text = "Gestión de la configuración";
			// 
			// btnAdEmpleado
			// 
			this.btnAdEmpleado.Name = "btnAdEmpleado";
			this.btnAdEmpleado.Text = "Empleados";
			// 
			// btnAdRoles
			// 
			this.btnAdRoles.Name = "btnAdRoles";
			this.btnAdRoles.Text = "Roles";
			// 
			// ribbonTopToolBar1
			// 
			this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::CpFerreteria.Properties.Resources.principal;
			this.pictureBox1.Location = new System.Drawing.Point(0, 201);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1067, 353);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.c1Ribbon1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::: Principal - Ferreteria :::";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonButton btnCaProductos;
        private C1.Win.Ribbon.RibbonButton btnCaProveedores;
        private C1.Win.Ribbon.RibbonButton btnCaClientes;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton btnCjCompras;
        private C1.Win.Ribbon.RibbonButton btnCjVentas;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonButton btnCjArqueoDiario;
        private C1.Win.Ribbon.RibbonTab ribbonTab3;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonButton btnAdEmpleado;
        private C1.Win.Ribbon.RibbonButton btnAdRoles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}