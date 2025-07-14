DELIMITER $$

USE `kings`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_delete`(spid int)
BEGIN
    DELETE FROM categorias WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_insert`(spnome varchar(40), spsigla char(3))
BEGIN
    INSERT INTO categorias VALUES (0, spnome, spsigla);
    SELECT LAST_INSERT_ID();
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_update`(spid int, spnome varchar(40), spsigla char(3))
BEGIN
    UPDATE categorias SET nome = spnome, sigla = spsigla WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_endereco_delete`(spid int)
BEGIN
    DELETE FROM enderecos WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_endereco_insert`(
    spcliente_id int, spcep char(8), splogradouro varchar(100),
    spnumero varchar(40), spcomplemento varchar(60),
    spbairro varchar(60), spcidade varchar(60), spuf char(2), sptipo_endereco char(3))
BEGIN
    INSERT INTO enderecos VALUES (0, spcliente_id, spcep, splogradouro, spnumero, spcomplemento, spbairro, spcidade, spuf, sptipo_endereco);
    SELECT @@IDENTITY AS id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_endereco_update`(
    spid int, spcep char(8), splogradouro varchar(100),
    spnumero varchar(40), spcomplemento varchar(60),
    spbairro varchar(60), spcidade varchar(60), spuf char(2), sptipo_endereco char(3))
BEGIN
    UPDATE enderecos SET cep = spcep, logradouro = splogradouro, numero = spnumero, complemento = spcomplemento,
    bairro = spbairro, cidade = spcidade, uf = spuf, tipo_endereco = sptipo_endereco WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cliente_insert`(
    spnome varchar(100), spcpf char(11), sptelefone char(14), spemail varchar(60), spdatanasc date)
BEGIN
    INSERT INTO clientes VALUES (0, spnome, spcpf, sptelefone, spemail, spdatanasc, DEFAULT, 1);
    SELECT LAST_INSERT_ID();
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cliente_update`(spid int, spnome varchar(100), sptelefone char(14), spdatanasc date)
BEGIN
    UPDATE clientes SET nome = spnome, telefone = sptelefone, data_nasc = spdatanasc WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_delete`(spid int)
BEGIN
    DELETE FROM itempedido WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_insert`(sppedido_id int, spproduto_id int, spquantidade decimal(10,3), spdesconto decimal(10,2))
BEGIN
    INSERT INTO itempedido VALUES (0, sppedido_id, spproduto_id, (SELECT valor_unit FROM produtos WHERE id = spproduto_id), spquantidade, spdesconto);
    SELECT LAST_INSERT_ID();
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_update`(spid int, spquantidade decimal(10,3), spdesconto decimal(10,2))
BEGIN
    UPDATE itempedido SET quantidade = spquantidade, desconto = spdesconto WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_pedido_insert`(spusuario_id int, spcliente_id int)
BEGIN
    INSERT INTO pedidos VALUES(0, spusuario_id, spcliente_id, DEFAULT, 'A', 0);
    SELECT LAST_INSERT_ID();
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_pedido_update`(spid int, spstatus char(1), spdesconto decimal(10,2))
BEGIN
    UPDATE pedidos SET status = spstatus, desconto = spdesconto WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_insert`(
    spcod_barras varchar(60), spdescricao varchar(60), spvalor_unit decimal(10,2),
    spunidade_venda varchar(12), spcategoria_id int, spestoque_minimo decimal(10,3),
    spclasse_desconto decimal(10,4), spimagem blob)
BEGIN
    INSERT INTO produtos VALUES (
        0, spcod_barras, spdescricao, spvalor_unit, spunidade_venda, spcategoria_id,
        spestoque_minimo, (spclasse_desconto/100), spimagem, DEFAULT, DEFAULT);
    SELECT LAST_INSERT_ID();
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_update`(
    spid int, spcod_barras varchar(60), spdescricao varchar(60), spvalor_unit decimal(10,2),
    spunidade_venda varchar(12), spcategoria_id int, spestoque_minimo decimal(10,3),
    spclasse_desconto decimal(10,4), spimagem blob, spdescontinuado bit(1))
BEGIN
    UPDATE produtos SET cod_barras = spcod_barras, descricao = spdescricao, valor_unit = spvalor_unit,
    unidade_venda = spunidade_venda, categoria_id = spcategoria_id, estoque_minimo = spestoque_minimo,
    classe_desconto = (spclasse_desconto/100), imagem = spimagem, descontinuado = spdescontinuado WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuario_altera`(spid int, spnome varchar(60), spsenha varchar(32), spnivel int)
BEGIN
    UPDATE usuarios SET nome = spnome, senha = MD5(spsenha), nivel_id = spnivel WHERE id = spid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuario_insert`(spnome varchar(60), spemail varchar(60), spsenha varchar(32), spnivel int)
BEGIN
    INSERT INTO usuarios VALUES (0, spnome, spemail, MD5(spsenha), spnivel, DEFAULT);
    SELECT * FROM usuarios WHERE id = LAST_INSERT_ID();
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_venda_terminal`(spusuario_id int, spcpf char(11), spcodbar varchar(60))
BEGIN
    INSERT INTO pedidos VALUES(0, spusuario_id, (SELECT id FROM clientes WHERE cpf = spcpf), DEFAULT, 'A', 0);
    INSERT INTO itempedido VALUES (
        0,
        LAST_INSERT_ID(),
        (SELECT id FROM produtos WHERE cod_barras = spcodbar),
        (SELECT valor_unit FROM produtos WHERE cod_barras = spcodbar),
        1,
        0);
    SELECT * FROM itempedido WHERE id = LAST_INSERT_ID();
END$$

CREATE PROCEDURE `sp_nivel_insert`(spnome varchar(45), spsigla varchar(45))
BEGIN
    INSERT INTO niveis(nome, sigla) VALUES (spnome, spsigla);
    SELECT * FROM niveis WHERE id = LAST_INSERT_ID();
END$$

CREATE PROCEDURE `sp_nivel_update`(spid int, spnome varchar(45), spsigla varchar(45))
BEGIN
    UPDATE niveis SET nome = spnome, sigla = spsigla WHERE id = spid;
END$$

CREATE TRIGGER `trigger_gera_estoque` AFTER INSERT ON `produtos` FOR EACH ROW
BEGIN
    INSERT INTO estoques VALUES(NEW.id, 0, CURRENT_DATE());
END$$

CREATE TRIGGER `trigger_baixa_estoque` AFTER INSERT ON `itempedido` FOR EACH ROW
BEGIN
    UPDATE estoques SET quantidade = quantidade - NEW.quantidade, data_ultimo_movimento = CURRENT_DATE()
    WHERE produto_id = NEW.produto_id;
END$$

DELIMITER ;
