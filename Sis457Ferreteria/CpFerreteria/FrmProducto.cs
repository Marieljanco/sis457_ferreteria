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
	public partial class FrmProducto : Form
	{
		private bool esNuevo = false;
		public FrmProducto()
		{
			InitializeComponent();
		}
		private void listar()
		{
			var lista = ProductoCln.listarPa(txtParametro.Text.Trim());
			dgvLista.DataSource = lista;
			dgvLista.Columns["id"].Visible = false;
			dgvLista.Columns["estado"].Visible = false;
			dgvLista.Columns["codigo"].HeaderText = "Código";
			dgvLista.Columns["descripcion"].HeaderText = "Descripción";
			dgvLista.Columns["marca"].HeaderText = "Marca";
			dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
			dgvLista.Columns["precioVenta"].HeaderText = "Precio de Venta";
			dgvLista.Columns["stock"].HeaderText = "Stock";
			dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
			dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
			dgvLista.Columns["idCategoria"].HeaderText = "Categoria";
			btnEditar.Enabled = lista.Count > 0;
			btnEliminar.Enabled = lista.Count > 0;
			if (lista.Count > 0) dgvLista.Rows[0].Cells["codigo"].Selected = true;
		}
		private void FrmProducto_Load(object sender, EventArgs e)
		{
			Size = new Size(860, 349);
			listar();
		}
		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			Size = new Size(860, 481);
			txtCodigo.Focus();
		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			Size = new Size(860, 481);

			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			var producto = ProductoCln.obtenerUno(id);
			txtCodigo.Text = producto.codigo;
			txtDescripcion.Text = producto.descripcion;
			txtMarca.Text = producto.marca;
			cbxUnidadMedida.Text = producto.unidadMedida;
			nudPrecioVenta.Value = producto.precioVenta;
			nudStock.Value = producto.stock;
			cbxCategoria.SelectedValue = producto.idCategoria;
			txtCodigo.Focus();
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Size = new Size(860, 349);
			limpiar();
		}
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}
		private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) listar();
		}
		private bool validar()
		{
			bool esValido = true;
			erpCodigo.SetError(txtCodigo, "");
			erpDescripcion.SetError(txtDescripcion, "");
			erpUnidadMedida.SetError(cbxUnidadMedida, "");
			erpPrecioVenta.SetError(nudPrecioVenta, "");
			erpStock.SetError(nudStock, "");

			if (string.IsNullOrEmpty(txtCodigo.Text))
			{
				esValido = false;
				erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
			}
			if (string.IsNullOrEmpty(txtDescripcion.Text))
			{
				esValido = false;
				erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
			}
			if (string.IsNullOrEmpty(cbxUnidadMedida.Text))
			{
				esValido = false;
				erpUnidadMedida.SetError(cbxUnidadMedida, "El campo Unidad de Medida es obligatorio");
			}
			if (string.IsNullOrEmpty(nudPrecioVenta.Text))
			{
				esValido = false;
				erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta es obligatorio");
			}
			if (nudPrecioVenta.Value <= 0)
			{
				esValido = false;
				erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta debe ser mayor a Cero");
			}
			if (string.IsNullOrEmpty(nudStock.Text))
			{
				esValido = false;
				erpStock.SetError(nudStock, "El campo Precio de Venta es obligatorio");
			}
			if (nudStock.Value <= 0)
			{
				esValido = false;
				erpStock.SetError(nudStock, "El campo Precio de Venta debe ser mayor a Cero");
			}
			return esValido;
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var producto = new Producto();
				producto.codigo = txtCodigo.Text.Trim();
				producto.descripcion = txtDescripcion.Text.Trim();
				producto.marca = txtMarca.Text.Trim();
				producto.unidadMedida = cbxUnidadMedida.Text.Trim();
				producto.precioVenta = nudPrecioVenta.Value;
				producto.stock = (int)nudStock.Value;
				producto.idCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
				producto.usuarioRegistro = Util.usuario.usuario1;

				if (esNuevo)
				{
					producto.fechaRegistro = DateTime.Now;
					producto.estado = 1;
					ProductoCln.insertar(producto);
				}
				else
				{
					int index = dgvLista.CurrentCell.RowIndex;
					producto.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
					ProductoCln.actualizar(producto);
					esNuevo = true;
				}
				listar();
				btnCancelar.PerformClick();
				MessageBox.Show("Producto guardado correctamente", "::: LARANA - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void limpiar()
		{
			txtCodigo.Text = string.Empty;
			txtDescripcion.Text = string.Empty;
			txtMarca.Text = string.Empty;
			cbxUnidadMedida.SelectedIndex = -1;
			nudPrecioVenta.Value = 0;
			nudStock.Value = 0;
			cbxCategoria.SelectedIndex = 0;
		}
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
			DialogResult dialog =
				MessageBox.Show($"¿Está seguro que desea dar de baja el producto con código {codigo}?",
				"::: LARANA - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				ProductoCln.eliminar(id, Util.usuario.usuario1);
				listar();
				MessageBox.Show("Producto dado de baja correctamente", "::: LARANA - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
