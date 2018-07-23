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
create TABLE ActivodeNegocios
(			

			ActivodeNegocioId int primary key identity(1,1),
			Nombre  varchar(25),
            Activo money

			
);
go

insert into ActivodeNegocios(Nombre,Activo) Values('Activos',0);

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
create TABLE ReciboDetalles
(			

			ID int primary key identity(1,1),
            ReciboId int,
            ClienteId int,
            ArticuloId int,
			ActivodeNegocioId int,
            Articulo varchar(40),
            Descripcion varchar(max),
            Cantidad int,
            Monto money,
            Fecha date,
            FechaVencimiento date,
            EstadodelArticulo varchar(10)
);
go

go
Create table Usuarios
(
	UsuariosId int primary Key identity(1,1),
	Nombre varchar(25),
	Usuario varchar(15),
	Contraseña varchar(20),
	Tipodeusuario varchar(15)

);
go

go
create table EntradadeActivos
(

		EntradadeActivosId int primary key identity(1,1),
        Fecha date,
		ActivodeNegocioId int,
        Motivo varchar(max),
        Suma money
		);
go

select *from ActivodeNegocios
Select* from EntradadeActivos
select *from Articulos
select *from Clientes
select *from Usuarios
Select* from ReciboDetalles
Select* from Recibos

truncate table ActivodeNegocio
truncate table EntradadeActivos
truncate table Articulos
truncate table Clientes
truncate table Usuarios
truncate table ReciboDetalles
truncate table Recibos