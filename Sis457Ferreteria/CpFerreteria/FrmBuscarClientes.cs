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
	public partial class FrmBuscarClientes : Form
	{
		public Cliente _cliente { get; set; }

		public FrmBuscarClientes()
		{
			InitializeComponent();
		}

		private void FrmBuscarClientes_Load(object sender, EventArgs e)
		{
			listar();
		}

		private void listar()
		{
			var lista = ClienteCln.listarPa(txtParametro.Text.Trim());
			dgvListaCliente.DataSource = lista;
			dgvListaCliente.Columns["id"].Visible = false;
			dgvListaCliente.Columns["estado"].Visible = false;
			dgvListaCliente.Columns["cedulaIdentidad"].HeaderText = "Cédula de Identidad";
			dgvListaCliente.Columns["nombres"].HeaderText = "Nombres";
			dgvListaCliente.Columns["primerApellido"].HeaderText = "Primer Apellido";
			dgvListaCliente.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
			dgvListaCliente.Columns["celular"].HeaderText = "Celular";
			dgvListaCliente.Enabled = lista.Count > 0;
			if (lista.Count > 0) dgvListaCliente.Rows[0].Cells["cedulaIdentidad"].Selected = true;
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
			if (dgvListaCliente.SelectedRows.Count > 0)
			{
				int row = dgvListaCliente.SelectedRows[0].Index;

				_cliente = new Cliente()
				{
					id = Convert.ToInt32(dgvListaCliente.Rows[row].Cells["id"].Value),
					cedulaIdentidad = dgvListaCliente.Rows[row].Cells["cedulaIdentidad"].Value.ToString(),
					nombres = dgvListaCliente.Rows[row].Cells["nombres"].Value.ToString(),
					primerApellido = dgvListaCliente.Rows[row].Cells["primerApellido"].Value.ToString(),
					segundoApellido = dgvListaCliente.Rows[row].Cells["segundoApellido"].Value.ToString(),
					celular = Convert.ToInt64(dgvListaCliente.Rows[row].Cells["celular"].Value),
					//estado = dgvListaCliente.Rows[row].Cells["estado"].Value.ToString()  // El estado
				};

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}

