CREATE DATABASE Aula11052023;

			CREATE TABLE Usuarios (
				Id INT IDENTITY(1, 1),
				Nome VARCHAR(30),
				Idade INT,
				Email VARCHAR(40),
				PRIMARY KEY(Id)
			);

			INSERT INTO Usuarios (Nome, Idade, Email)
				VALUES
				('João', 18, 'joao@email.com'),
				('Maria', 25, 'maria@email.com');
