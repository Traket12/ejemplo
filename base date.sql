DROP TABLE Valoracion
DROP TABLE Comentario
DROP TABLE Noticia
DROP TABLE Seccion
DROP TABLE Usuario

CREATE TABLE Usuario(
	IDUsuario bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Usuario nvarchar(20) NOT NULL,
	Contraseña nvarchar(100) NOT NULL,
	Correo nvarchar(100) NOT NULL,
	Roll int NOT NULL,
	Passadmin nvarchar(30),
	Nombre nvarchar(100),
	App nvarchar(100),
	Apm nvarchar(100),
	Carrera nvarchar(20),
	Celular int
)

CREATE TABLE Seccion(
	IDSeccion bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Seccion nvarchar(100) NOT NULL
)

CREATE TABLE Noticia (
	IDNoticia bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Fecha datetime NOT NULL DEFAULT getdate(),
	Titulo nvarchar(200) NOT NULL,
	Contenido text NOT NULL,	
	Foto nvarchar(200) NOT NULL,
	IDSeccion bigint NOT NULL REFERENCES Seccion,
	IDUsuario bigint NOT NULL REFERENCES Usuario
)

CREATE TABLE Comentario(
	IDComentario bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Comentario text,
	IDNoticia bigint NOT NULL REFERENCES Noticia,
	IDUsuario bigint NOT NULL REFERENCES Usuario
)

CREATE TABLE Valoracion(
	IDValor bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Valor decimal(2,2) NOT NULL,
	IDNoticia bigint NOT NULL REFERENCES Noticia,
	IDUsuario bigint NOT NULL REFERENCES Usuario
)