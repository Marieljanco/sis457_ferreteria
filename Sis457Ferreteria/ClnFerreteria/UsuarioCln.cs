using CadFerreteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ClnFerreteria
{
    public class UsuarioCln
    {
        public static Usuario validar(string usuario, string clave)
        {
            using (var context = new LabFerreteriaEntities())
            {
                var query = from u in context.Usuario
                            join e in context.Empleado on u.idEmpleado equals e.id
                            where u.usuario1 == usuario && u.clave == clave
                            select new
                            {
                                Usuario = u,
                                Cargo = e.cargo
                            };

                var result = query.FirstOrDefault();
                if (result != null)
                {
                    result.Usuario.Cargo = result.Cargo;
                    return result.Usuario;
                }

                return null;
            }
        }
    }
}
