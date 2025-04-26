create database KingOfKings;
CREATE TABLE Usuarios (
    Id INT  PRIMARY KEY,
	ClienteId INT NOT NULL, 
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(150) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    Ativo BIT DEFAULT 1
);