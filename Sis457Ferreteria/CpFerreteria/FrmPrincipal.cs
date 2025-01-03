﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpFerreteria
{
    public partial class FrmPrincipal : Form
    {
        private FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAutenticacion.Visible = true;
        }
        private void btnCaProductos_Click(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }
		private void btnCaClientes_Click(object sender, EventArgs e)
		{
			new FrmCliente().ShowDialog();
		}
		private void btnCjVentas_Click(object sender, EventArgs e)
        {
            new FrmVenta().ShowDialog();
        }

        private void btnAdEmpleado_Click(object sender, EventArgs e)
        {
            new FrmEmpleados().ShowDialog();
        }
    }
}