SELECT * FROM KingOfKings.Usuarios;


INSERT INTO `kingofkings`.`usuarios` (`nome`, `email`, `senha`, `nivel_id`, `ativo`)
VALUES ('erik', 'e', MD5('e'), 1, b'1');

INSERT INTO `kingofkings`.`niveis` (`nome`, `sigla`)
VALUES ('Administrador', 'ADM');

DELIMITER $$

CREATE procedure sp_alterar_usuario( 
-- parâmetros da procedure
spid int, spnome varchar(60), spsenha varchar(32), spnivel int)
begin
	update usuarios 
	set nome = spnome, senha = md5(spsenha), nivel_id = spnivel where id = spid;
end$$

DELIMITER 