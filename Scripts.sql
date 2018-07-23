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
create TABLE Articulos
(			

	   ArticuloId int primary key identity(1,1),
	   Nombre varchar(30),
	   Inventario int

			
);
go
insert into Articulos(Nombre,Inventario) Values('Lavadora',0);
insert into Articulos(Nombre,Inventario) Values('Abanico',0);

go
create TABLE ActivodeNegocios
(			

			ActivodeNegocioId int primary key identity(1,1),
			Nombre  varchar(25),
            Activo money

			
);
go

insert into ActivodeNegocios(Nombre,Activo) Values('Activos',75000);

go
create TABLE Recibos
(			

			ReciboId int primary key identity(1,1),
			ActivodeNegocioId int,
            Fecha  Date,
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
			NombredeCliente varchar(30),
            Articulo varchar(40),
            Descripcion varchar(max),
            Cantidad int,
            Monto money,
            FechadeEmpeño  date,
           

			
         
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


Select* from EntradadeActivos
select *from Clientes
select *from Usuarios

Select* from ReciboDetalles
Select* from Recibos
select *from ActivodeNegocios
select *from Articulos


truncate table EntradadeActivos
truncate table Clientes
truncate table Usuarios

truncate table ReciboDetalles
truncate table Recibos
truncate table ActivodeNegocios
truncate table Articulos