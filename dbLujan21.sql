--use mates
use master
--se crea la base de datos
if exists (select name from dbo.sysdatabases where name = 'dbLujan21')
drop database [dbLujan21]
go
-- se crea y se usa
create database [dbLujan21]
go
use [dbLujan21]
go
----
--------------------------- se crea la tabla de administradaors-------------------------------------------------------
if exists (select name from dbo.sysobjects where name = 'tblAdmi')
drop table tblAdmi
go
create table tblAdmi(
admiId int identity not null,
admiNombre varchar(30) not null,
admiApellidos varchar(30) not null,
admiUsuario varchar(20) not null,
admiPW varchar(15) not null,
admiRights varchar(20) default 'Administrador'
) on[primary]
go
--creo la llave primaria
alter table tblAdmi add constraint 
Pk_admiId primary key (admiId)
go
-------------------------Se crea la tabla de lavados ---------------------------
if exists (select name from dbo.sysobjects where name = 'tblLavados')
drop table tblLavados
go
create table tblLavados(
lavConsecutivo int identity not null,
lavTipoCliente varchar(30) not null,
lavTipoPaquete varchar(30) not null,
lavPaquete varchar(30) not null,
lavSizeVe varchar(30) not null,
lavFechaPago date not null,
lavUsuario varchar(30) not null,
lavLavador varchar(30) not null,
lavFechaLavado date not null,
lavCliente varchar(30) not null,
lavPlaca varchar(30) not null,
lavMarca varchar(30) not null,
lavHora varchar(10) not null,
lavMonto decimal(5,2) not null
) on[primary]
go
--creo la llave primaria
alter table tblLavados add constraint 
Pk_lavID primary key (lavConsecutivo)
go


------------------se crea tabla cliente 
if exists (select name from dbo.sysobjects where name = 'tblCliente')
drop table tblCliente
go
create table tblCliente(
clienId int identity not null,
clienPlacaVehiculo int null,
clienNombre varchar(30) not null,
clienApellidos varchar(30) null,
clienTelefono varchar(11) null,
) on[primary]
go
alter table tblCliente add constraint 
Pk_clienID primary key (clienId)
go
------------------se crea tabla veh�culos
if exists (select name from dbo.sysobjects where name = 'tblVehiculo')
drop table tblVehiculo
go
create table tblVehiculo(
vehPlaca varchar(15) not null,
vehClienteId int not null,
vehMarca varchar(15),
vehSize varchar(8) not null
) on[primary]
go
alter table tblVehiculo add constraint 
Pk_placaVeh primary key (vehPlaca)
go
------------------se crea tabla Paquetes
if exists (select name from dbo.sysobjects where name = 'tblPaquetes')
drop table tblPaquetes
go
create table tblPaquetes(
paqId int identity,
paqNombre varchar(30),
paqTipo varchar (30) default 'Estandar',
paqDescripcion text not null,
paqCosto decimal (10,2) not null
) on[primary]
go
alter table tblPaquetes add constraint 
Pk_paqId primary key (paqId)
go
------------------------Tbl Extras----------
if exists (select name from dbo.sysobjects where name = 'tblExtras')
drop table tblExtras
go
create table tblExtras(
extId int identity,
extNombre varchar(30),
extCosto decimal(5,2)
) on[primary]
go
alter table tblExtras add constraint 
Pk_extraId primary key (extId)
go
----------------------------tbl citas
if exists (select name from dbo.sysobjects where name = 'tblCitas')
drop table tblCitas
go
create table tblCitas(
citId int identity,
citNombre varchar(30) not null,
citApellidos varchar(30) not null,
citPlaca varchar(15),
citMarca varchar(15),
citFecha date not null,
citHora varchar(10) not null,
citTelefono varchar(15),
citDescrip text
) on[primary]
go
alter table tblCitas add constraint 
Pk_citaId primary key (citId)
go
--------Tiquetes
if exists (select name from dbo.sysobjects where name = 'tblTiquete')
drop table tblTiquete
go
create table tblTiquete(
tiqId int identity,
tiqPlaca varchar(30) not null,
tiqCliente varchar(30) not null,
tiqHoraFecha date not null,
) on[primary]
go
alter table tblTiquete add constraint 
Pk_tiqId primary key (tiqId)
go

----------------------------------Llaves foranias
---Llave forania de lavado hacia cliente
alter table tblLavados add constraint
Fk_Lavado_Cliente foreign key (lavIdCliente) references tblCliente(clienId)
go
--Llave forania de lavado hacia vehiculo
alter table tblLavados add constraint
Fk_Lavado_Vehiculo foreign key (lavIdVehiculo) references tblVehiculo(vehPlaca)
go
--Llave forania de lavado hacia paquete
alter table tblLavados add constraint
Fk_Lavado_Paquete foreign key (lavIdPaquete) references tblPaquetes(paqId)
go
--Llave forania de vehiculo hacia cliente
alter table tblVehiculo add constraint
Fk_Vehiculo_Cliente foreign key (vehPlaca) references tblCliente(clienId)
go

select @@servername


------------------Guardar los tipos de lavados existentes
insert into tblPaquetes(paqNombre,paqTipo,paqDescripcion,paqCosto)
values('B�sico','Estandar','Lavado exterior con champ� + secado + aspirado interior',4000)
insert into tblPaquetes(paqNombre,paqTipo,paqDescripcion,paqCosto)
values('Medio','Estandar','B�sico + cera + protector de llantas + abrillantador molduras + protecci�n dash',4900)
insert into tblPaquetes(paqNombre,paqTipo,paqDescripcion,paqCosto)
values('Full','Estandar','MEDIO + antiempa�ado de parabrisas trasero y delantero+lavado alfombras + protector de aros.',5500)
insert into tblPaquetes(paqNombre,paqTipo,paqDescripcion,paqCosto)
values('Motor','Estandar','Lavado de motor.',4000)
insert into tblPaquetes(paqNombre,paqTipo,paqDescripcion,paqCosto)
values('Chasis','Estandar','Lavado de chasis.',3500)
insert into tblPaquetes(paqNombre,paqTipo,paqDescripcion,paqCosto)
values('Motocicleta','Estandar','Lavado de motocicleta.',3000)


insert into tblTiquete(tiqPlaca,tiqCliente,tiqHoraFecha)
values('502-M','Juan Vazques',GETDATE())
select * from tblPaquetes
select * from tblTiquete
select * from tblCitas 