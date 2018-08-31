DROP TABLE Usuarios
DROP TABLE Noticias


CREATE TABLE Usuarios(
	ID bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Contraseña nvarchar(100) NOT NULL,
	Correo nvarchar(100),
	Roll int(3),
	Passadmin nvarchar(30),
	Nombre nvarchar(100),
	App nvarchar(100),
	Apm nvarchar(100),
	Carrera nvarchar(20),
	Celular bigint(20),
)

CREATE TABLE Item (
	Idnot bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Fecha datetime NOT NULL DEFAULT getdate(),
	Titulo nvarchar(200) NOT NULL,
	Contenido nvarchar(1000) NOT NULL,	
	Foto nvarchar(200) NOT NULL,
	Idseccion int(5),
	Seccion nvarchar(100) NOT NULL	
)
