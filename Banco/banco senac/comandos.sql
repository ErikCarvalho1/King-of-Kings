SELECT * FROM KingOfKings.Usuarios;


INSERT INTO `kingofkings`.`usuarios` (`nome`, `email`, `senha`, `nivel_id`, `ativo`)
VALUES ('erik', 'e', MD5('e'), 1, b'1');

INSERT INTO `kingofkings`.`niveis` (`nome`, `sigla`)
VALUES ('Administrador', 'ADM');