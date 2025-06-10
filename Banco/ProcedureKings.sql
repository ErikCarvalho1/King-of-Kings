
-- -----------------------------------------------------
-- Placeholder table for view `comercialtdsdb01`.`vw_pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialtdsdb01`.`vw_pedido` (`pedido` INT, `cliente` INT, `produto` INT, `quantidade` INT, `valor_item` INT, `desc_item` INT, `desc_pedido` INT, `cod_barras` INT, `descricao` INT);

-- -----------------------------------------------------
-- procedure sp_categoria_delete
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_delete`(spid int)
begin
	delete from categorias
    where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_insert
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_insert`(spnome varchar(40), spsigla char(3))
begin
	insert into categorias
    values(0,spnome,spsigla);
    select last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_update
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_update`(spid int, spnome varchar(40), spsigla char(3))
begin
	update categorias set nome = spnome, sigla = spsigla
    where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_cliente_insert
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cliente_insert`(
spnome varchar(100), 
spcpf char(11), 
sptelefone char(14), 
spemail varchar(60), 
spdatanasc date
)
begin 
	insert into clientes 
    values (0,spnome, spcpf, sptelefone, spemail, spdatanasc,default,1);
    select  last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_cliente_update
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cliente_update`(spid int, spnome varchar(100), sptelefone char(14), spdatanasc date)
BEGIN
 update clientes set nome= spnome, telefone  = sptelefone, data_nasc = spdatanasc where id = spid; 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_endereco_delete
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_endereco_delete`(spid int)
begin
delete from enderecos
where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_endereco_insert
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_endereco_insert`(
    spcliente_id int, 
    spcep char(8), 
    splogradouro varchar(100),
    spnumero varchar(40),
    spcomplemento varchar(60),
    spbairro varchar(60),
    spcidade varchar(60),
    spuf char(2),
    sptipo_endereco char(3)
    )
begin
		insert into enderecos 
        values (0,spcliente_id, spcep, splogradouro, spnumero, spcomplemento, spbairro, spcidade, spuf, sptipo_endereco);
        select @@identity as id;
    end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_endereco_update
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_endereco_update`(
spid int,
spcep char(8), 
splogradouro varchar(100),
spnumero varchar(40),
spcomplemento varchar(60),
spbairro varchar(60),
spcidade varchar(60),
spuf char(2),
sptipo_endereco char(3))
begin
	 update enderecos set cep = spcep, 
     logradouro = splogradouro, 
     numero = spnumero, 
	 complemento = spcomplemento, 
	 bairro = spbairro, 
	 cidade = spcidade, 
	 uf = spuf,
	 tipo_endereco = sptipo_endereco 
	 where id = spid;
 end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_itempedido_delete
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_delete`(spid int)
begin
	delete from itempedido
    where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_itempedido_insert
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_insert`(sppedido_id int, spproduto_id int, spquantidade decimal (10,3), spdesconto decimal(10,2))
begin
	insert into itempedido
    values (0, sppedido_id, spproduto_id, (select valor_unit from produtos where id = spproduto_id), spquantidade, spdesconto);
    select last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_itempedido_update
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_update`(spid int,spquantidade decimal(10,3), spdesconto decimal(10,2))
begin
	update itempedido set quantidade = spquantidade, desconto = spdesconto
    where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_nivel_insert
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_nivel_insert`(
		   spnome varchar(45),
           spsigla varchar(45)
)
begin
		   insert into niveis(nome, sigla) values (spnome, spsigla);
           select * from niveis where id = last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_nivel_update
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_nivel_update`(
		    spid int,
            spnome varchar(45),
            spsigla varchar(45)
)
begin
   update niveis set nome = spnome, sigla = spsigla 
   where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_insert
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_pedido_insert`(spusuario_id int, spcliente_id int)
begin
	insert into pedidos
    values(0, spusuario_id, spcliente_id,default , 'A', 0);
    select last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_update
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_pedido_update`(spid int, spstatus char(1), spdesconto decimal(10,2))
begin
	update pedidos set status = spstatus, desconto = spdesconto
    where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_produto_insert
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_insert`(
spcod_barras varchar(60), 
spdescricao varchar(60),
spvalor_unit decimal(10,2),
spunidade_venda varchar(12),
spcategoria_id int,
spestoque_minimo decimal(10,2),
spclasse_desconto decimal(10,2))
begin
	insert into produtos
    values(
    0,
    spcod_barras, 
    spdescricao, 
    spvalor_unit, 
    spunidade_venda,
    spcategoria_id, 
    spestoque_minimo,
    spclasse_desconto,
    null,
    default, 
    default);
    select last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_produto_update
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_update`(
spid int,
spcod_barras varchar(60), 
spdescricao varchar(60),
spvalor_unit decimal(10,2),
spunidade_venda varchar(12),
spcategoria_id int,
spestoque_minimo decimal(10,2),
spclasse_desconto decimal(10,2),
spdescontinuado bit(1)
)
begin
	update produtos set cod_barras = spcod_barras, descricao = spdescricao,
    valor_unit = spvalor_unit, unidade_venda = spunidade_venda, categoria_id = spcategoria_id,
    estoque_minimo = spestoque_minimo, classe_desconto = spclasse_desconto, descontinuado = spdescontinuado 
    where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_usuario_altera
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuario_altera`(
-- parâmetros da procedure
spid int, spnome varchar(60), spsenha varchar(32), spnivel int)
begin
	update usuarios 
	set nome = spnome, senha = md5(spsenha), nivel_id = spnivel where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_usuario_insert
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuario_insert`(
-- parâmetros da procedure
spnome varchar(60), spemail varchar(60), spsenha varchar(32), spnivel int)
begin
	insert into usuarios 
	values (0,spnome, spemail, md5(spsenha), spnivel, default);
    select * from usuarios where id = last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_venda_terminal
-- -----------------------------------------------------

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_venda_terminal`(spusuario_id int,spcpf char(11), spcodbar varchar(60))
begin
	insert pedidos values(0,spusuario_id,(select id from clientes where cpf = spcpf), default, 'A', 0);
		insert itempedido values (
			0,
			last_insert_id(),
			(select id from produtos where cod_barras = spcodbar),
            (select valor_unit from produtos where cod_barras = spcodbar),
            1,
            0);
	select * from itempedido where id = last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- View `comercialtdsdb01`.`vw_pedido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `comercialtdsdb01`.`vw_pedido`;
USE `comercialtdsdb01`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `comercialtdsdb01`.`vw_pedido` AS select `p`.`id` AS `pedido`,`p`.`cliente_id` AS `cliente`,`ip`.`produto_id` AS `produto`,`ip`.`quantidade` AS `quantidade`,`ip`.`valor_unit` AS `valor_item`,`ip`.`desconto` AS `desc_item`,`p`.`desconto` AS `desc_pedido`,`pr`.`cod_barras` AS `cod_barras`,`pr`.`descricao` AS `descricao` from ((`comercialtdsdb01`.`pedidos` `p` join `comercialtdsdb01`.`itempedido` `ip` on(`p`.`id` = `ip`.`pedido_id`)) join `comercialtdsdb01`.`produtos` `pr` on(`ip`.`produto_id` = `pr`.`id`));
USE `comercialtdsdb01`;

DELIMITER $$
USE `comercialtdsdb01`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `comercialtdsdb01`.`trigger_gera_estoque`
AFTER INSERT ON `comercialtdsdb01`.`produtos`
FOR EACH ROW
BEGIN
INSERT INTO estoques values(new.id, 0, current_date());
END$$

USE `comercialtdsdb01`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `comercialtdsdb01`.`trigger_baixa_estoque`
AFTER INSERT ON `comercialtdsdb01`.`itempedido`
FOR EACH ROW
BEGIN
update estoques SET quantidade = quantidade - NEW.quantidade, data_ultimo_movimento = current_date()
where produto_id = new.produto_id
;
END$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
