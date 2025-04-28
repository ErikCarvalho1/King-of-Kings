create database KingOfKings;
CREATE TABLE Usuarios (
    Id INT  PRIMARY KEY,  
    Nome VARCHAR(100) NOT NULL,
    Cpf_cnpj VARCHAR(20), 
	Email VARCHAR(150) NOT NULL UNIQUE,
    Tipo_usuario ENUM('Administrador', 'Funcionário', 'Cliente') NOT NULL,
    Senha VARCHAR(32) NOT NULL,
    Ativo BIT DEFAULT 1,
    criado_em DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- create table Cadastro(
-- Nome VARCHAR(100) NOT NULL,
-- Cpf_cnpj VARCHAR(20), 
 -- Email VARCHAR(150) NOT NULL UNIQUE,
-- Tipo_usuario ENUM('Administrador', 'Funcionário', 'Visitante') NOT NULL
-- );

create table Login (
Id INT primary key,
Usuario_id int,
Email VARCHAR(150) NOT NULL UNIQUE,
Senha Varchar (30),
FOREIGN KEY (Usuario_Id) REFERENCES Usuarios(Id),
Logado_em DATETIME DEFAULT CURRENT_TIMESTAMP   
);
