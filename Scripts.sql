create database CompraventaDB
GO
USE CompraventaDB
GO
create TABLE Clientes
(  ClienteId int primary key identity(1,1),
            Nombre varchar(45),
            Cedula varchar(13),
            Telefono varchar(12),
            Direccion varchar(max)
);
go

go
create TABLE Articulos
(			

	   ArticuloId int primary key identity(1,1),
	   Nombre varchar(40),
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

insert into ActivodeNegocios(Nombre,Activo) Values('Activos',0);

go
create TABLE Recibos
(			

			ReciboId int primary key identity(1,1),
			ActivodeNegocioId int,
			ClienteId int,
			NombredeCliente varchar(45),
            Fecha  Date,
            MontoTotal money,
			Abono money,
			UltimaFechadeVigencia date

);
go


go
create TABLE ReciboDetalles
(			

			ID int primary key identity(1,1),
            ReciboId int,
            ArticuloId int,
            Articulo varchar(40),
            Descripcion varchar(max),
            Cantidad int,
            Monto money,
           	        
);
go

go
create table Usuarios
(
	UsuariosId int primary Key identity(1,1),
	Nombre varchar(45),
	Usuario varchar(25),
	Contraseña varchar(20),
	Tipodeusuario varchar(15)

);
go

insert into Usuarios(Nombre,Usuario,Contraseña,Tipodeusuario) Values('Root','root','admin','Administrador');

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



go
create table Pagos
(
            PagosId int primary key Identity(1,1),
            ReciboId int,
			ActivodeNegocioId int,
            Fecha Date,
            Abono money,
		);
go



Select* from EntradadeActivos
select *from Clientes
select *from Usuarios

Select* from ReciboDetalles
Select* from Recibos
select *from Pagos
select *from ActivodeNegocios
select *from Articulos

select c.nombre from Clientes c

select c.ClienteId,C.Nombre,r.ReciboId,r.Fecha,r.MontoTotal,r.Abono
 from Clientes c inner join Recibos r on c.ClienteId = r.ClienteId  inner join Pagos p on p.ReciboId = r.ReciboId where c.ClienteId = 2

 delete from Recibos  where ReciboId =0;

truncate table EntradadeActivos
truncate table Clientes
truncate table Pagos
truncate table Usuarios

truncate table ReciboDetalles
truncate table Recibos
truncate table ActivodeNegocios
truncate table Articulos