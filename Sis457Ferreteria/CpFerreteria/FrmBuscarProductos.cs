using CadFerreteria;
using ClnFerreteria;
using System;
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
    public partial class FrmBuscarProductos : Form
    {
		public Producto _producto { get; set; }
		public FrmBuscarProductos()
        {
            InitializeComponent();
        }

		private void FrmBusquedaProducto_Load(object sender, EventArgs e)
		{
			listar();
		}

		private void listar()
		{
			var lista = ProductoCln.listarPa(txtParametro.Text.Trim());
			dgvListaProducto.DataSource = lista;
			dgvListaProducto.Columns["id"].Visible = false;
			dgvListaProducto.Columns["estado"].Visible = false;
			dgvListaProducto.Columns["codigo"].HeaderText = "Código";
			dgvListaProducto.Columns["descripcion"].HeaderText = "Descripción";
			dgvListaProducto.Columns["marca"].HeaderText = "Marca";
			dgvListaProducto.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
			dgvListaProducto.Columns["precioVenta"].HeaderText = "Precio de Venta";
			dgvListaProducto.Columns["stock"].HeaderText = "Stock";
			dgvListaProducto.Columns["usuarioRegistro"].Visible = false;
			dgvListaProducto.Columns["fechaRegistro"].Visible = false;
			dgvListaProducto.Columns["idCategoria"].Visible = false;
			dgvListaProducto.Enabled = lista.Count > 0;
			if (lista.Count > 0) dgvListaProducto.Rows[0].Cells["codigo"].Selected = true;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}

		private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) listar();
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			// Verifica si hay una fila seleccionada
			if (dgvListaProducto.SelectedRows.Count > 0)
			{
				int row = dgvListaProducto.SelectedRows[0].Index; // Obtener la fila seleccionada

				_producto = new Producto()
				{
					id = Convert.ToInt32(dgvListaProducto.Rows[row].Cells["id"].Value),
					codigo = dgvListaProducto.Rows[row].Cells["codigo"].Value.ToString(),
					descripcion = dgvListaProducto.Rows[row].Cells["descripcion"].Value.ToString(),
					precioVenta = Convert.ToDecimal(dgvListaProducto.Rows[row].Cells["precioVenta"].Value),
					stock = Convert.ToInt32(dgvListaProducto.Rows[row].Cells["stock"].Value)
				};

				// Indicar que se seleccionó un producto
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				// Si no hay fila seleccionada, puedes mostrar un mensaje de error
				MessageBox.Show("Por favor, seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			// Cerrar el formulario sin hacer nada
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
