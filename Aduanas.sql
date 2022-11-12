CREATE DATABASE Aduanas;
GO

USE Aduanas;
GO

CREATE TABLE personas(
	idPersona int identity(1,1) PRIMARY KEY,
	identidad int NOT NULL,
	nombres varchar(30) NOT NULL,
	apellidos varchar(30) NOT NULL,
	sexo varchar(10) NOT NULL,
	paisOrigen varchar(30) NOT NULL,
	paisNaturalizacion varchar(30) NULL,
	telefono varchar(20) NOT NULL,
	correo varchar (30) NOT NULL,
)
GO

CREATE TABLE roles(
	idRol int identity(1,1) PRIMARY KEY,
	descripcion varchar(15) NOT NULL
)
GO

CREATE TABLE agencias(
	idAgencia int identity(1,1) PRIMARY KEY,
	nombreAgencia varchar(30) NOT NULL,
	telefono varchar(20) NOT NULL,
	direccion text NOT NULL,
	pais varchar(30) NOT NULL
)
GO

CREATE TABLE empleados(
	idPersona int references personas(idPersona),
	idAgencia int references agencias(idAgencia),
	idRol int references roles(idRol),
	usuario varchar(20) NOT NULL,
	clave varchar(20) NOT NULL,
	fechaInicio date NOT NULL,
	fechaFin date NULL
)
ALTER TABLE empleados ADD idEmpleado int identity(1,1) PRIMARY KEY;

GO
