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
	public partial class FrmCliente : Form
	{
		private bool esNuevo = false;
		public FrmCliente()
		{
			InitializeComponent();
		}
		private void listar()
		{
			var lista = ClienteCln.listarPa(txtParametro.Text.Trim());
			dgvLista.DataSource = lista;
			dgvLista.Columns["id"].Visible = false;
			dgvLista.Columns["estado"].Visible = false;
			dgvLista.Columns["cedulaIdentidad"].HeaderText = "Cédula";
			dgvLista.Columns["nombres"].HeaderText = "Nombres";
			dgvLista.Columns["primerApellido"].HeaderText = "Primer Apellido";
			dgvLista.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
			dgvLista.Columns["celular"].HeaderText = "Celular";
			btnEditar.Enabled = lista.Count > 0;
			btnEliminar.Enabled = lista.Count > 0;
			if (lista.Count > 0) dgvLista.Rows[0].Cells["cedulaIdentidad"].Selected = true;
		}
		private void FrmCliente_Load(object sender, EventArgs e)
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
			txtCedulaIdentidad.Focus();
		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			Size = new Size(860, 481);

			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			var cliente = ClienteCln.obtenerUno(id);
			txtCedulaIdentidad.Text = cliente.cedulaIdentidad;
			txtNombres.Text = cliente.nombres;
			txtPrimerApellido.Text = cliente.primerApellido;
			txtSegundoApellido.Text = cliente.segundoApellido;
			txtCelular.Text = cliente.celular.ToString();
			txtCedulaIdentidad.Focus();
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
			erpCedulaIdentidad.SetError(txtCedulaIdentidad, "");
			erpNombres.SetError(txtNombres, "");
			erpCelular.SetError(txtCelular, "");

			if (string.IsNullOrEmpty(txtCedulaIdentidad.Text))
			{
				esValido = false;
				erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo Cédula es obligatorio");
			}

			if (string.IsNullOrEmpty(txtNombres.Text))
			{
				esValido = false;
				erpNombres.SetError(txtNombres, "El campo Nombres es obligatorio");
			}

			if (string.IsNullOrEmpty(txtCelular.Text) || !long.TryParse(txtCelular.Text, out _))
			{
				esValido = false;
				erpCelular.SetError(txtCelular, "El campo Celular es obligatorio y debe ser numérico");
			}

			return esValido;
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var cliente = new Cliente();
				cliente.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
				cliente.nombres = txtNombres.Text.Trim();
				cliente.primerApellido = txtPrimerApellido.Text.Trim();
				cliente.segundoApellido = txtSegundoApellido.Text.Trim();
				cliente.celular = long.Parse(txtCelular.Text.Trim());
				cliente.usuarioRegistro = Util.usuario.usuario1;

				if (esNuevo)
				{
					cliente.fechaRegistro = DateTime.Now;
					cliente.estado = 1;
					ClienteCln.insertar(cliente);
				}
				else
				{
					int index = dgvLista.CurrentCell.RowIndex;
					cliente.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
					ClienteCln.actualizar(cliente);
					esNuevo = true;
				}

				listar();
				btnCancelar.PerformClick();
				MessageBox.Show("Cliente guardado correctamente", "::: LARANA - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void limpiar()
		{
			txtCedulaIdentidad.Text = string.Empty;
			txtNombres.Text = string.Empty;
			txtPrimerApellido.Text = string.Empty;
			txtSegundoApellido.Text = string.Empty;
			txtCelular.Text = string.Empty;
		}
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			string cedula = dgvLista.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
			DialogResult dialog =
				MessageBox.Show($"¿Está seguro que desea eliminar al cliente con cédula {cedula}?",
				"::: LARANA - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				ClienteCln.eliminar(id, Util.usuario.usuario1);
				listar();
				MessageBox.Show("Cliente eliminado correctamente", "::: LARANA - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
