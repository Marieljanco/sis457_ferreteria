using CadFerreteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnFerreteria
{
	public class ProductoCln
	{
        public static int insertar(Producto producto)
        {
            using (var context = new LabFerreteriaEntities())
            {
                try
                {
                    context.Producto.Add(producto);
                    context.SaveChanges(); // Aquí se captura el error
                    return producto.id;
                }
                catch (Exception ex)
                {
                    // Imprime el error para depuración
                    Console.WriteLine("Error al insertar producto: " + ex.Message);
                    throw; // Lanza la excepción para manejarla en niveles superiores si es necesario
                }
            }
        }

        public static int actualizar(Producto producto)
		{
			using (var context = new LabFerreteriaEntities())
			{
				var existente = context.Producto.Find(producto.id);
				existente.codigo = producto.codigo;
				existente.descripcion = producto.descripcion;
				existente.unidadMedida = producto.unidadMedida;
				existente.marca = producto.marca;
				existente.precioVenta = producto.precioVenta;
				existente.stock = producto.stock;
				existente.idCategoria = producto.idCategoria;
				existente.usuarioRegistro = producto.usuarioRegistro;
				return context.SaveChanges();
			}
		}
		public static int eliminar(int id, string usuario)
		{
			using (var context = new LabFerreteriaEntities())
			{
				var producto = context.Producto.Find(id);
				producto.estado = -1;
				producto.usuarioRegistro = usuario;
				return context.SaveChanges();
			}
		}

		public static Producto obtenerUno(int id)
		{
			using (var context = new LabFerreteriaEntities())
			{
				return context.Producto.Find(id);
			}
		}

		public static List<Producto> listar()
		{
			using (var context = new LabFerreteriaEntities())
			{
				return context.Producto.Where(x => x.estado != -1).ToList();
			}
		}

		public static List<paProductoListar_Result> listarPa(string parametro)
		{
			using (var context = new LabFerreteriaEntities())
			{
				return context.paProductoListar(parametro).ToList();
			}
		}
	}
}
