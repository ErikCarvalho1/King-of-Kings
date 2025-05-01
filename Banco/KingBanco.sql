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

CREATE TABLE RegistroDeAcesso (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Usuario_Id INT ,
    Entrada DATETIME DEFAULT CURRENT_TIMESTAMP,
    Saida datetime DEFAULT NULL,
    FOREIGN KEY (Usuario_Id) REFERENCES Usuarios(Id)
);
INSERT INTO RegistroDeAcesso (id, Usuario_Id, Entrada)
VALUES (1, NOW());

select * from usuarios; 
select * from  RegistroDeAcesso;
SELECT * FROM usuarios WHERE Id = '1';
SELECT * FROM usuarios WHERE email = 'erik@erik' AND senha = md5('123');

update usuarios set senha = '123' where id = 1;
UPDATE RegistroDeAcesso 
SET Saida = now()
WHERE Usuario_Id = 1 AND Saida IS NULL
LIMIT 1;


SELECT * FROM RegistroDeAcesso WHERE Usuario_Id = 1 AND Saida IS NULL ORDER BY Entrada DESC LIMIT 1;
UPDATE registrodeacesso 
SET Saida = NOW()
WHERE Usuario_Id = 1 AND Saida IS NULL
ORDER BY Entrada DESC
LIMIT 1;
SELECT * FROM usuarios WHERE id = 1;
ALTER TABLE usuarios
ADD CONSTRAINT fk_usuario
FOREIGN KEY (Usuario_Id) REFERENCES registrodeacesso(Id);


INSERT INTO usuarios(Id, Entrada)
VALUES ('1', now() );