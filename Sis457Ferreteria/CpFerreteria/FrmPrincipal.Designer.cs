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
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaProductos = new C1.Win.Ribbon.RibbonButton();
            this.btnCaProveedores = new C1.Win.Ribbon.RibbonButton();
            this.btnCaClientes = new C1.Win.Ribbon.RibbonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCjCompras = new C1.Win.Ribbon.RibbonButton();
            this.btnCjVentas = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.btnAdEmpleados = new C1.Win.Ribbon.RibbonButton();
            this.btnAdRoles = new C1.Win.Ribbon.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(800, 161);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
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
            this.ribbonGroup1.Text = "Administración de Catálogos";
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("Edit", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 78));
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.Text = "Poductos";
            // 
            // btnCaProveedores
            // 
            this.btnCaProveedores.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProveedores.IconSet.Add(new C1.Framework.C1BitmapIcon("User", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 331));
            this.btnCaProveedores.Name = "btnCaProveedores";
            this.btnCaProveedores.Text = "Proveedores";
            // 
            // btnCaClientes
            // 
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon("Users", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 332));
            this.btnCaClientes.Name = "btnCaClientes";
            this.btnCaClientes.Text = "Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 284);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup2);
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
            this.btnCjCompras.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCjCompras.IconSet.Add(new C1.Framework.C1BitmapIcon("ReportDesign", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 236));
            this.btnCjCompras.Name = "btnCjCompras";
            this.btnCjCompras.Text = "Compras";
            // 
            // btnCjVentas
            // 
            this.btnCjVentas.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCjVentas.IconSet.Add(new C1.Framework.C1BitmapIcon("GanttResources", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 118));
            this.btnCjVentas.Name = "btnCjVentas";
            this.btnCjVentas.Text = "Ventas";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup3);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Administración";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnAdEmpleados);
            this.ribbonGroup3.Items.Add(this.btnAdRoles);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Gestión de la Configuración";
            // 
            // btnAdEmpleados
            // 
            this.btnAdEmpleados.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdEmpleados.IconSet.Add(new C1.Framework.C1BitmapIcon("CheckNames", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 35));
            this.btnAdEmpleados.Name = "btnAdEmpleados";
            this.btnAdEmpleados.Text = "Empleado";
            // 
            // btnAdRoles
            // 
            this.btnAdRoles.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdRoles.IconSet.Add(new C1.Framework.C1BitmapIcon("EditComments", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 79));
            this.btnAdRoles.Name = "btnAdRoles";
            this.btnAdRoles.Text = "Roles";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Name = "FrmPrincipal";
            this.Text = "::: Ferreteria - Principal :::";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.Ribbon.RibbonButton btnCjCompras;
        private C1.Win.Ribbon.RibbonButton btnCjVentas;
        private C1.Win.Ribbon.RibbonTab ribbonTab3;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonButton btnAdEmpleados;
        private C1.Win.Ribbon.RibbonButton btnAdRoles;
    }
}