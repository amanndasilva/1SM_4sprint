/*Para criar a pasta da clínica*/
CREATE DATABASE clinica;

/*Para utilizar esse banco de dados*/
USE clinica;

/*Criação da tabela - Clínica*/
CREATE TABLE clinicas(
	IdClinica INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR (20) NOT NULL,
	Endereco VARCHAR (100) NOT NULL
);
/*DROP TABLE clínica;*/

/*Criação da tabela - Donos*/
CREATE TABLE donos(
	IdDono INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR (100) NOT NULL
);

/*Criação da tabela - Tipos de Pets*/
CREATE TABLE tipos_pets(
	IdTipoPet INT IDENTITY PRIMARY KEY NOT NULL,
	Descricao VARCHAR (50) NOT NULL
);

/*Criação da tabela - Veterinários*/
CREATE TABLE veterinarios(
	IdVeterinario INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR (100) NOT NULL,
	DescricaoVet VARCHAR (20) NOT NULL,

	IdClinica INT FOREIGN KEY REFERENCES clinicas (IdClinica) NOT NULL
);

/*Criação da tabela - Raça*/
CREATE TABLE raca(
	IdRaca INT IDENTITY PRIMARY KEY NOT NULL,
	DescricaoRaca VARCHAR (20) NOT NULL,

	IdTipoPet INT FOREIGN KEY REFERENCES tipos_pets (IdTipoPet) NOT NULL
);

/*Criação da tabela - Pets*/
CREATE TABLE pets(
	IdPet INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR (100) NOT NULL,
	DataNascimento DATETIME NOT NULL,

	IdRaca INT FOREIGN KEY REFERENCES raca (IdRaca) NOT NULL,
	IdDono INT FOREIGN KEY REFERENCES donos (IdDono) NOT NULL
);

/*Criação da tabela - Atendimento*/
CREATE TABLE atendimento(
	IdAtendimentos INT IDENTITY PRIMARY KEY NOT NULL,
	DescricaoAt VARCHAR (1000) NOT NULL,
	DataAtendimento DATETIME NOT NULL,

	IdVeterinario INT FOREIGN KEY REFERENCES veterinarios (IdVeterinario) NOT NULL,
	IdPet INT FOREIGN KEY REFERENCES pets (IdPet) NOT NULL
);