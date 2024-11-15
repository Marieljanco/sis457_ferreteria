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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new FrmBuscarProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._producto.id.ToString();
                    txtCodigoProducto.Text = modal._producto.codigo;
                    txtProducto.Text = modal._producto.descripcion;
                    txtPrecio.Text = modal._producto.precioVenta.ToString();
                    txtStock.Text = modal._producto.stock.ToString();
                    nudCantidad.Maximum = modal._producto.stock;
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            decimal precioVenta = 0;
            bool existe = false;
            if (txtCodigoProducto.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "::: Larana - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal.TryParse(txtPrecio.Text, out precioVenta);

            foreach (DataGridViewRow fila in dgvListaDetalle.Rows)
            {
                if (fila.Cells["idProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    existe = true;
                    if (existe)
                    {
                        limpiarProducto();
                        MessageBox.Show("Producto ya seleccionado", "::: Larana - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            if (!existe)
            {
                dgvListaDetalle.Rows.Add(new object[]
                {
                    txtIdProducto.Text,
                    txtProducto.Text,
                    txtPrecio.Text,
                    nudCantidad.Value.ToString(),
                    (nudCantidad.Value * precioVenta).ToString(),
                    "ELIMINAR"
                });
            }

            calcularTotal();
            limpiarProducto();
        }

        private void limpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodigoProducto.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            nudCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvListaDetalle.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaDetalle.Rows)
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value.ToString());
            }
            txtTotal.Text = total.ToString();
        }

        private void dgvListaDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaDetalle.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgvListaDetalle.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			using (var modal = new FrmBuscarClientes())  // Crea una instancia del formulario de búsqueda de clientes
			{
				var result = modal.ShowDialog();  // Muestra el formulario modal y espera que el usuario lo cierre

				if (result == DialogResult.OK)  // Si el usuario seleccionó un cliente y cerró el formulario con OK
				{
					// Asigna solo la cédula y el nombre del cliente a los controles correspondientes
					txtCedulaIdentidad.Text = modal._cliente.cedulaIdentidad;  // Asigna la cédula de identidad
					txtNombre.Text = $"{modal._cliente.nombres} {modal._cliente.primerApellido} {modal._cliente.segundoApellido}".Trim();  // Asigna el nombre completo
				}
			}
		}


		private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtProducto.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Debe llenar todos los campos para registrar un producto", "::: Larana - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear objeto producto (simulación de inserción)
            var nuevoProducto = new
            {
                Id = Guid.NewGuid().ToString(), // Generar un ID único temporalmente
                Codigo = txtCodigoProducto.Text,
                Descripcion = txtProducto.Text,
                PrecioVenta = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text)
            };

            // Simulación de registro en base de datos
            MessageBox.Show($"Producto registrado con éxito:\n\nCódigo: {nuevoProducto.Codigo}\nDescripción: {nuevoProducto.Descripcion}\nPrecio: {nuevoProducto.PrecioVenta}\nStock: {nuevoProducto.Stock}",
                "::: Larana - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            limpiarProducto();
        }
    }
}
