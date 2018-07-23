create database CompraventaDB
GO
USE CompraventaDB
GO
CREATE TABLE Clientes
(  ClienteId int primary key identity(1,1),
            Nombre varchar(30),
            Cedula varchar(13),
            Telefono varchar(12),
            Direccion varchar(max)
);
go

go
CREATE TABLE Articulos
(			

	   ArticuloId int primary key identity(1,1),
	   Nombre varchar(30),
	   Inventario int

			
);
go


go
CREATE TABLE CapitaldeNegocios
(			

			CapitaldeNegocioId int primary key identity(1,1),
            Fecha  Date,
            Capital money

			
);
go


go
CREATE TABLE Recibos
(			

			ReciboId int primary key identity(1,1),
            Fecha  Date,
			Articulo varchar(40),
			Observacion varchar(max),
            MontoTotal money

);
go


go
CREATE TABLE ReciboDetalles
(			

			ID int primary key identity(1,1),
            ReciboId int,
            ClienteId int,
            ArticuloId int,
            Articulo varchar(40),
            Descripcion varchar(max),
            Cantidad int,
            Monto money,
            Fecha date,
            FechaVencimiento date,
            EstadodelArticulo varchar(10)
);
go

