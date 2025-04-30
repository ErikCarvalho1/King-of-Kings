create database KingOfKings;
CREATE TABLE Usuarios (
    Id INT  PRIMARY KEY auto_increment,  
    Nome VARCHAR(100) NOT NULL,
    Cpf_cnpj VARCHAR(20), 
	Email VARCHAR(150) NOT NULL UNIQUE,
    Tipo_usuario ENUM('Administrador', 'Funcionário', 'Cliente') NOT NULL,
    Senha VARCHAR(32) NOT NULL,
    Ativo BIT DEFAULT 1,
    criado_em DATETIME DEFAULT CURRENT_TIMESTAMP
);
INSERT INTO Usuarios (Id, Nome, Cpf_cnpj, Email, Tipo_usuario, Senha, Ativo)
VALUES (1, 'Erik', '123.456.789-00', 'erik@erik', 'Administrador', md5('123'), 1);
-- create table Cadastro(
-- Nome VARCHAR(100) NOT NULL,
-- Cpf_cnpj VARCHAR(20), 
 -- Email VARCHAR(150) NOT NULL UNIQUE,
-- Tipo_usuario ENUM('Administrador', 'Funcionário', 'Visitante') NOT NULL
-- );

create table Login (
Id INT primary key,
Usuario_id int,
FOREIGN KEY (Usuario_Id) REFERENCES Usuarios(Id),
Logado_em DATETIME DEFAULT CURRENT_TIMESTAMP   
);
SELECT * FROM usuarios WHERE nome = 'erik';


select * from usuarios; 
SELECT * FROM usuarios WHERE email = 'erik@erik' AND senha = md5('123');