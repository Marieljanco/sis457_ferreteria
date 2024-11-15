CREATE DATABASE LabFerreteria;

USE [master]
GO
CREATE LOGIN [usrferreteria] WITH PASSWORD=N'123456',
  DEFAULT_DATABASE = [LabFerreteria],
  CHECK_EXPIRATION = OFF,
  CHECK_POLICY = ON
GO
USE [LabFerreteria]
GO
CREATE USER [usrferreteria] FOR LOGIN [usrferreteria]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrferreteria]
GO

DROP TABLE VentaDetalle;
DROP TABLE Venta;
DROP TABLE CompraDetalle;
DROP TABLE Compra;
DROP TABLE Usuario;
DROP TABLE Producto;
DROP TABLE Categoria;
DROP TABLE Proveedor;
DROP TABLE Cliente;
DROP TABLE Empleado;
GO

CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(30) NOT NULL
);
GO

CREATE TABLE Cliente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  celular BIGINT NOT NULL,
);
GO

CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nit BIGINT NOT NULL,
  razonSocial VARCHAR(100) NOT NULL,
  direccion VARCHAR(250) NULL,
  telefono VARCHAR(30) NOT NULL
);
GO

CREATE TABLE Categoria (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(30) NOT NULL
);
GO

CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  codigo VARCHAR(20) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  marca VARCHAR(20) NULL,
  unidadMedida VARCHAR(20) NOT NULL,
  precioVenta DECIMAL(10, 2) NOT NULL CHECK(precioVenta > 0),
  stock INT NOT NULL,
  idCategoria INT NOT NULL,
  CONSTRAINT fk_Producto_Categoria FOREIGN KEY(idCategoria) REFERENCES Categoria(id)
);
GO

CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL,
  clave VARCHAR(100) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);
GO

CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idUsuario INT NOT NULL,
  idProveedor INT NOT NULL,
  total DECIMAL NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  CONSTRAINT fk_Compra_Usuario FOREIGN KEY(idUsuario) REFERENCES Usuario(id),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
);
GO

CREATE TABLE CompraDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  cantidad INT NOT NULL CHECK(cantidad > 0),
  precioUnitario DECIMAL(10, 2) NOT NULL,
  subtotal DECIMAL(10, 2) NOT NULL,
  CONSTRAINT fk_CompraDetalle_Compra FOREIGN KEY(idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);
GO

CREATE TABLE Venta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idUsuario INT NOT NULL,
  idCliente INT NOT NULL,
  total DECIMAL(10, 2) NOT NULL,
  montoPago DECIMAL(10, 2) NOT NULL,
  montoCambio DECIMAL(10, 2) NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  CONSTRAINT fk_Venta_Usuario FOREIGN KEY(idUsuario) REFERENCES Usuario(id),
  CONSTRAINT fk_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id)
);
GO

CREATE TABLE VentaDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idVenta INT NOT NULL,
  idProducto INT NOT NULL,
  nombreProducto VARCHAR(250) NOT NULL,
  precioUnitario DECIMAL(10, 2) NOT NULL,
  cantidad INT NOT NULL CHECK(cantidad > 0),
  subtotal DECIMAL(10, 2) NOT NULL,
  CONSTRAINT fk_VentaDetalle_Venta FOREIGN KEY(idVenta) REFERENCES Venta(id),
  CONSTRAINT fk_VentaDetalle_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);
GO

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Categoria ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Categoria ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Categoria ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE VentaDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE VentaDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE VentaDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo


GO
ALTER PROC paProductoListar @parametro VARCHAR(100)
AS
  SELECT * FROM Producto
  WHERE estado<>-1 AND descripcion LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY descripcion;

GO
create PROC paEmpleadoListar @parametro VARCHAR(50)
AS
  SELECT e.id, e.cedulaIdentidad, nombres, ISNULL(e.primerApellido,'') AS primerApellido, 
		 ISNULL(e.segundoApellido, '') AS segundoApellido, e.direccion, e.celular, e.cargo,
		 ISNULL(e.usuarioRegistro, '') AS usuarioRegistro, ISNULL(e.fechaRegistro,GETDATE()) AS fechaRegistro, 
		 ISNULL(u.id,0) as idUsuario, ISNULL(u.usuario, '') as usuario
  FROM Empleado e
  LEFT JOIN Usuario u ON e.id = u.idEmpleado
  WHERE e.estado<>-1 
		AND e.cedulaIdentidad+e.nombres+e.primerApellido+e.segundoApellido LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY e.nombres,e.primerApellido;

EXEC paProductoListar 'tubo';
EXEC paEmpleadoListar 'abril';
EXEC paEmpleadoListar 'eli';

GO
CREATE PROCEDURE paVentaListar @parametro VARCHAR(50)
AS
BEGIN
  SELECT 
    v.id,
    v.idUsuario,
    v.idCliente,
    v.total,
    v.montoPago,
    v.montoCambio,
    ISNULL(v.fecha, GETDATE()) AS fecha,
    ISNULL(u.usuario, '') AS usuario,
    ISNULL(c.nombres, '') + ' ' + ISNULL(c.primerApellido, '') + ' ' + ISNULL(c.segundoApellido, '') AS cliente
  FROM Venta v
  LEFT JOIN Usuario u ON v.idUsuario = u.id
  LEFT JOIN Cliente c ON v.idCliente = c.id
  WHERE v.estado <> -1
    AND CAST(v.id AS VARCHAR) + CAST(v.idUsuario AS VARCHAR) + 
        CAST(v.idCliente AS VARCHAR) + CAST(v.total AS VARCHAR) + 
        CAST(v.montoPago AS VARCHAR) + CAST(v.montoCambio AS VARCHAR) + 
        ISNULL(c.nombres, '') + ISNULL(c.primerApellido, '') + ISNULL(c.segundoApellido, '') LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
  ORDER BY v.fecha DESC;
END;
GO

EXEC paVentaListar 'sierra';
EXEC paVentaListar '';

-- cliente procedimiento no ejecutado revisar
DROP PROC paClienteListar;
GO
CREATE PROCEDURE paClienteListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Cliente
    WHERE estado <> -1 AND nombres LIKE '%' + REPLACE(@parametro,' ','%')+'%';
  END

EXEC paClienteListar 'paco';
-- fin proc cliente

-- DML
INSERT INTO Producto (codigo, descripcion, marca, unidadMedida, precioVenta, stock, idCategoria)
VALUES ('P001', 'Tubo de PVC 2"', 'Plomería S.A.', 'Metro', 15.50, 100, 1);


INSERT INTO Categoria(nombre)
VALUES('Herramientas Eléctricas');

INSERT INTO Categoria(nombre)
VALUES('Herramientas Manuales');

INSERT INTO Categoria(nombre)
VALUES('Plomería');

INSERT INTO Categoria(nombre)
VALUES('Electricidad');

INSERT INTO Categoria(nombre)
VALUES('Materiales de Construcción');

INSERT INTO Proveedor(nit, razonSocial, direccion, telefono)
VALUES(1016259020, 'Fábrica Nacional de Cemento S.A.', 'Av. Marcelo Quiroga Sta. Cruz', '6453882')

INSERT INTO Proveedor(nit, razonSocial, direccion, telefono)
VALUES(3233474011, 'Cerámica Elvia Ltda.', 'Av. Circunvalación', '6454345')

INSERT INTO Proveedor(nit, razonSocial, direccion, telefono)
VALUES(3233455221, 'FABOCE S.R.L.', 'J. Prudencio Bustillos 1010', '6429080')

INSERT INTO Proveedor(nit, razonSocial, direccion, telefono)
VALUES(3233544859, 'TIGRE S.A.', 'Dirección: Parque Industrial Ramón D. Gutiérrez PI-22, Sta. Cruz', '69046448')

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES('123456', 'Milena', 'Padilla', 'Mendez', 'Calle X', 76862782, 'ADMINISTRADOR');

INSERT INTO Usuario(usuario, clave, idEmpleado)
VALUES('fiona', 'i0hcoO/nssY6WOs9pOp5Xw==', 1);

INSERT INTO Usuario(usuario, clave, idEmpleado)
VALUES('gregoria', 'i0hcoO/nssY6WOs9pOp5Xw==', 1);

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES('123457', 'Juan', 'Pérez', 'López', 'Calle X', 76862783, 'CAJERO');

INSERT INTO Usuario(usuario, clave, idEmpleado)
VALUES('jperez', 'i0hcoO/nssY6WOs9pOp5Xw==', 2);

INSERT INTO Cliente(cedulaIdentidad, nombres, primerApellido, segundoApellido, celular)
VALUES('123458', 'Paco', 'Perez', 'Perez', 73457845);

INSERT INTO Cliente(cedulaIdentidad, nombres, primerApellido, segundoApellido, celular)
VALUES('123459', 'Pablo', 'Gonzalez', 'Perez', 73457845);

SELECT * FROM Producto WHERE estado<>-1;

SELECT * FROM Usuario;
SELECT * FROM Empleado;
SELECT * FROM Cliente;
SELECT * FROM Categoria;
SELECT * FROM Producto;
SELECT * FROM VentaDetalle;
SELECT * FROM Venta;
