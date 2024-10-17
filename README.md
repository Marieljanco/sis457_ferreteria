# sis457_ferreteria
Empleado (id, cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)

Cliente (id, cedulaIdentidad, nombres, primerApellido, segundoApellido, celular)

Proveedor (id, nit, razonSocial, direccion, telefono)

Categoria (id, nombre)

Producto (id, codigo, descripcion, marca, unidadMedida, precioVenta, stock, idCategoria)

Usuario (id, idEmpleado, usuario, clave)

Compra (id, idUsuario, idProveedor, total, fecha)

CompraDetalle (id, idCompra, idProducto, cantidad, precioUnitario, subtotal)

Venta (id, idUsuario, idCliente, total, montoPago, montoCambio, fecha)

VentaDetalle (id, idVenta, idProducto, nombreProducto, precioUnitario, cantidad, subtotal)