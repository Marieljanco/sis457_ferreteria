using System;
using System.Collections.Generic;

namespace WebFerreteria.Models;

public partial class Compra
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public int IdProveedor { get; set; }

    public decimal Total { get; set; }

    public DateOnly Fecha { get; set; }

    public virtual ICollection<CompraDetalle> CompraDetalles { get; set; } = new List<CompraDetalle>();

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
