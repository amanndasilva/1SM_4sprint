/*Para criar a pasta Optus*/
CREATE DATABASE optus;

/*Para utilizar a pasta Oputs*/
USE optus;

/*Criação da tabela - Estilos*/
CREATE TABLE estilos(
	IdEstilo INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR (20)
);

/*Criação da tabela - Aristas*/
CREATE TABLE artistas(
	IdArtista INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR (50),

	IdEstilo INT FOREIGN KEY REFERENCES estilos (IdEstilo)
);

/*Criação da tabela - Álbuns*/
CREATE TABLE albuns(
	IdAlbum INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR (20) NOT NULL,
	DataLancamento DATETIME,
	Localizacao VARCHAR (50) NOT NULL,
	StatusAlbum VARCHAR (10) NOT NULL,

	IdArtista INT FOREIGN KEY REFERENCES artistas (IdArtista)
);

/*Criação da tabela - Usuários*/
CREATE TABLE usuarios(
	IdUsuario INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR (20) NOT NULL,
	StatusUsuario VARCHAR (10) NOT NULL,
	Senha VARCHAR (15) NOT NULL,
	Email VARCHAR (30) NOT NULL
);

-- DROP TABLE usuarios;