create database  Controledeacesso;
-- ----------------------------------------------------------------------
   CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    tipo_usuario ENUM('Administrador', 'Funcionário', 'Visitante') NOT NULL,
    senha VARCHAR(255) NOT NULL,
    foto BLOB,
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    ativo TINYINT(1) NOT NULL DEFAULT 1
-- -------------------------------------------------------------------------
);
select * from  usuarios;
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(45),
    Cpf VARCHAR(11), 
     email VARCHAR(100) NOT NULL UNIQUE,
    Tipo_usuario ENUM('Administrador', 'Funcionário', 'Visitante') NOT NULL,
    Senha VARCHAR(255), 
    Foto BLOB,
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Ativo BOOLEAN
);

CREATE TABLE RegistroDeAcesso (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Usuario_Id INT,
    Entrada DATETIME,
    Saida datetime,
    FOREIGN KEY (Usuario_Id) REFERENCES Usuarios(Id)
);
INSERT INTO RegistroDeAcesso (Usuario_Id, Entrada, Saida)
VALUES (1, '2025-04-24 08:00:00', '2025-04-24 17:00:00');

select * from  RegistroDeAcesso;
SELECT 
    ra.Id, 
    ra.Usuario_Id, 
    u.Nome AS UsuarioNome,
    ra.Entrada, 
    ra.Saida, 
    ra.TipoOperacao
FROM RegistroDeAcesso ra
JOIN Usuarios u ON ra.Usuario_Id = u.Id;

 UPDATE RegistroDeAcesso 
 SET Saida = @Saida 
 WHERE Usuario_Id = @UsuarioId AND Saida IS NULL
 ORDER BY Entrada DESC
 LIMIT 1;
  INSERT INTO RegistroDeAcesso (Usuario_Id, Saida)
 VALUES (5, '2025-04-24 17:00:00' );
 
 SELECT * FROM RegistroDeAcesso WHERE Entrada = '0000-00-00 00:00:00' OR Saida = '0000-00-00 00:00:00';
 
 UPDATE RegistroDeAcesso 
SET Entrada = NULL 
WHERE Entrada = '0000-00-00 00:00:00';

UPDATE RegistroDeAcesso 
SET Saida = NULL 
WHERE Saida = '0000-00-00 00:00:00';