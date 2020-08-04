/*Aula - 07*/
USE clinica;

/*DML: Data Manipulation Language*/

-- INSERT: insere os dados na tabela
INSERT INTO clinicas (Nome, Endereco) VALUES ('My Pet', 'Rua Vermelha 598');
SELECT * FROM clinicas;

INSERT INTO donos (Nome) VALUES ('Liza');
SELECT * FROM donos;

INSERT INTO tipos_pets (Descricao) VALUES ('Gato');
SELECT * FROM tipos_pets;

INSERT INTO veterinarios (Nome, DescricaoVet, IdClinica) VALUES ('Augusto', 31425, 1);
SELECT * FROM veterinarios;

INSERT INTO raca (DescricaoRaca, IdTipoPet) VALUES ('Siamês', 2);
SELECT * FROM raca;

INSERT INTO pets (Nome, DataNascimento, IdRaca, IdDono) VALUES ('Frida', 05/09/2010, 2, 7);
SELECT * FROM pets;

INSERT INTO atendimento (DescricaoAt, DataAtendimento, IdVeterinario, IdPet) VALUES ('O pacience está ok.', 2022-02-05, 2, 5);
SELECT * FROM atendimento;

-- UPDATE: altera dados
/*UPDATE clinicas SET
	Nome = 'My Pet'
WHERE IdClinica = 1;*/

-- DEELETE: deleta dados
-- DELETE FROM donos WHERE IdDono = 1;

-- DQL: consulta de dados
-- SELECT * FROM clinicas;