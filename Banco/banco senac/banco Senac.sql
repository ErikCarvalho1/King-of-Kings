-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema kings
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema kings
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `kings` DEFAULT CHARACTER SET utf8mb4 ;
USE `kings` ;

-- -----------------------------------------------------
-- Table `kings`.`niveis`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`niveis` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `sigla` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `kings`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`usuarios` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `nivel_id` INT(11) NOT NULL,
  `ativo` BIT(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE,
  INDEX `fk_usuarios_niveis1_idx` (`nivel_id` ASC) VISIBLE,
  CONSTRAINT `fk_usuarios_niveis1`
    FOREIGN KEY (`nivel_id`)
    REFERENCES `kings`.`niveis` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1006;


-- -----------------------------------------------------
-- Table `kings`.`caixas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`caixas` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `usuario_id` INT(4) NOT NULL,
  `data_abertura` DATETIME NOT NULL,
  `saldo_inicial` DECIMAL(10,2) NOT NULL,
  `status` CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`id`),
  INDEX `fk_Caixa_Usuarios1_idx` (`usuario_id` ASC) VISIBLE,
  CONSTRAINT `fk_Caixa_Usuarios1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `kings`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`categorias` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NOT NULL,
  `sigla` CHAR(3) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2;


-- -----------------------------------------------------
-- Table `kings`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`clientes` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `cpf` CHAR(11) NOT NULL,
  `telefone` CHAR(14) NULL DEFAULT NULL,
  `email` VARCHAR(60) NOT NULL,
  `data_nasc` DATE NULL DEFAULT NULL,
  `data_cad` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `ativo` BIT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 10090;


-- -----------------------------------------------------
-- Table `kings`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`pedidos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `usuario_id` INT(4) NOT NULL,
  `cliente_id` INT(4) NOT NULL,
  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `status` CHAR(1) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Pedido_Usuarios1_idx` (`usuario_id` ASC) VISIBLE,
  INDEX `fk_Pedido_Clientes1_idx` (`cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_Pedido_Clientes1`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `kings`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pedido_Usuarios1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `kings`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 100001;


-- -----------------------------------------------------
-- Table `kings`.`revendedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`revendedores` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `cpf_cnpj` VARCHAR(18) NOT NULL,
  `telefone` VARCHAR(20) NULL DEFAULT NULL,
  `email` VARCHAR(100) NULL DEFAULT NULL,
  `ativo` BIT(1) NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cpf_cnpj_UNIQUE` (`cpf_cnpj` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`cupons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`cupons` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(100) NOT NULL,
  `codigo` VARCHAR(50) NOT NULL,
  `cupom_tipo` VARCHAR(20) NOT NULL,
  `data_criacao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `data_validade` DATE NOT NULL,
  `valor_pedido_minimo` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_maximo_desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_maximo_pedido` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_desconto` DECIMAL(10,2) NOT NULL,
  `descricao` TEXT NULL DEFAULT NULL,
  `tipo_desconto` BIT(1) NOT NULL,
  `cliente_id` INT(11) NULL DEFAULT NULL,
  `pedido_id` INT(11) NULL DEFAULT NULL,
  `revendedor_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `codigo` (`codigo` ASC) VISIBLE,
  INDEX `fk_cupons_clientes_idx` (`cliente_id` ASC) VISIBLE,
  INDEX `fk_cupons_pedidos_idx` (`pedido_id` ASC) VISIBLE,
  INDEX `fk_cupons_revendedores_idx` (`revendedor_id` ASC) VISIBLE,
  CONSTRAINT `fk_cupons_clientes`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `kings`.`clientes` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_cupons_pedidos`
    FOREIGN KEY (`pedido_id`)
    REFERENCES `kings`.`pedidos` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_cupons_revendedores`
    FOREIGN KEY (`revendedor_id`)
    REFERENCES `kings`.`revendedores` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`enderecos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`enderecos` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `cliente_id` INT(4) NOT NULL,
  `cep` CHAR(8) NOT NULL,
  `logradouro` VARCHAR(100) NULL DEFAULT NULL,
  `numero` VARCHAR(40) NOT NULL,
  `complemento` VARCHAR(60) NULL DEFAULT NULL,
  `bairro` VARCHAR(60) NOT NULL,
  `cidade` VARCHAR(60) NOT NULL,
  `uf` CHAR(2) NOT NULL,
  `tipo_endereco` CHAR(3) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_table1_clientes_idx` (`cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_table1_clientes`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `kings`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 55;


-- -----------------------------------------------------
-- Table `kings`.`produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`produtos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `cod_barras` VARCHAR(60) NOT NULL,
  `descricao` VARCHAR(60) NOT NULL,
  `valor_unit` DECIMAL(10,2) NOT NULL,
  `unidade_venda` VARCHAR(12) NOT NULL,
  `categoria_id` INT(4) NOT NULL,
  `estoque_minimo` DECIMAL(10,2) NOT NULL,
  `classe_desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  `imagem` BLOB NULL DEFAULT NULL,
  `data_cad` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `descontinuado` BIT(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `idProduto_UNIQUE` (`id` ASC) VISIBLE,
  UNIQUE INDEX `Produtocol_UNIQUE` (`cod_barras` ASC) VISIBLE,
  INDEX `fk_Produto_Categorias1_idx` (`categoria_id` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_Categorias1`
    FOREIGN KEY (`categoria_id`)
    REFERENCES `kings`.`categorias` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 7400007;


-- -----------------------------------------------------
-- Table `kings`.`estoques`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`estoques` (
  `produto_id` INT(4) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `data_ultimo_movimento` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  INDEX `fk_Estoque_Produto1_idx` (`produto_id` ASC) VISIBLE,
  CONSTRAINT `fk_Estoque_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`fornecedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`fornecedores` (
  `id` INT(4) NOT NULL,
  `razao_social` VARCHAR(100) NOT NULL,
  `fantasia` VARCHAR(40) NOT NULL,
  `cnpj` CHAR(14) NOT NULL,
  `contato` VARCHAR(60) NULL DEFAULT NULL,
  `telefone` VARCHAR(45) NULL DEFAULT NULL,
  `email` VARCHAR(60) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cnpj_UNIQUE` (`cnpj` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`itempedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`itempedido` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `quantidade` DECIMAL(10,3) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  `valor_unit` DECIMAL(10,2) NOT NULL,
  `Observacao` VARCHAR(200) NOT NULL,
  `pedido_id` INT(11) NOT NULL,
  `produto_id` INT(11) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_ItemPedido_Pedido1_idx` (`pedido_id` ASC) VISIBLE,
  INDEX `fk_ItemPedido_Produto1_idx` (`produto_id` ASC) VISIBLE,
  CONSTRAINT `fk_ItemPedido_Pedido1`
    FOREIGN KEY (`pedido_id`)
    REFERENCES `kings`.`pedidos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemPedido_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`mesas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`mesas` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `numero` CHAR(50) NOT NULL,
  `status` ENUM('livre', 'ocupada', 'inativa') NOT NULL DEFAULT 'livre',
  `setor` INT(32) NULL DEFAULT NULL,
  `audio` VARCHAR(32) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `kings`.`produtofornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`produtofornecedor` (
  `produto_id` INT(4) NOT NULL,
  `fornecedores_id` INT(4) NOT NULL,
  PRIMARY KEY (`produto_id`, `fornecedores_id`),
  INDEX `fk_Produto_has_Fornecedores_Fornecedores1_idx` (`fornecedores_id` ASC) VISIBLE,
  INDEX `fk_Produto_has_Fornecedores_Produto1_idx` (`produto_id` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_has_Fornecedores_Fornecedores1`
    FOREIGN KEY (`fornecedores_id`)
    REFERENCES `kings`.`fornecedores` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Produto_has_Fornecedores_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `kings` ;

-- -----------------------------------------------------
-- procedure sp_alterar_usuario
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_alterar_usuario`(
-- parâmetros da procedure
spid int, spnome varchar(60), spsenha varchar(32), spnivel int)
begin
	update usuarios 
	set nome = spnome, senha = md5(spsenha), nivel_id = spnivel where id = spid;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_atualizar_cupom
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_atualizar_cupom`(
    spid INT,
    sptitulo VARCHAR(255),
    spcodigo VARCHAR(100),
    spcupomtipo VARCHAR(100),
    spdatacriacao DATETIME,
    spdatavalidade DATETIME,
    spvalorpedidominimo DECIMAL(18, 2),
    spvalormaximodesconto DECIMAL(18, 2),
    spvalormaximopedido DECIMAL(18, 2),
    spvalordesconto DECIMAL(18, 2),
    spdescricao VARCHAR(100),
    sptipodesconto FLOAT,
    spclienteid INT,
    sppedidoid INT,
    sprevendedorid INT)
BEGIN
    UPDATE Cupons
    SET
        Titulo = sptitulo,
        Codigo = spcodigo,
        CupomTipo = spcupomtipo,
        DataCriacao = spdatacriacao,
        DataValidade = spdatavalidade,
        ValorPedidoMinimo = spvalorpedidominimo,
        ValorMaximoDeDesconto = spvalormaximodesconto,
        ValorMaximoPedido = spvalormaximopedido,
        ValorDesconto = spvalordesconto,
        Descricao = spdescricao,
        TpoDesconto = sptipodesconto,
        ClienteId = spclienteid,
        PedidoId = sppedidoid,
        RevendedorId = sprevendedorid
    WHERE Id = spid;

    SELECT ROW_COUNT() AS RegistrosAtualizados;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_atualizar_fornecedores
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_atualizar_fornecedores`( 
    IN sp_id INT,
    IN sp_razao_social VARCHAR(100),
    IN sp_fantasia VARCHAR(40),
    IN sp_cnpj CHAR(14),
    IN sp_contato VARCHAR(60),
    IN sp_telefone VARCHAR(45),
    IN sp_email VARCHAR(60)
)
BEGIN
    UPDATE fornecedores
    SET
        razao_social = sp_razao_social,
        fantasia     = sp_fantasia,
        cnpj         = sp_cnpj,
        contato      = sp_contato,
        telefone     = sp_telefone,
        email        = sp_email
    WHERE id = sp_id;

    SELECT ROW_COUNT() AS RegistrosAtualizados;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_atualizar_nivel
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_atualizar_nivel`(
    IN spid INT,
    IN spnome VARCHAR(45),
    IN spsigla VARCHAR(45)
)
BEGIN
    UPDATE nivel
    SET nome = spnome,
        sigla = spsigla
    WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_delete
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_delete`(spid int)
BEGIN
    DELETE FROM categorias WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_insert`(spnome varchar(40), spsigla char(3))
BEGIN
    INSERT INTO categorias VALUES (0, spnome, spsigla);
    SELECT LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_update`(spid int, spnome varchar(40), spsigla char(3))
BEGIN
    UPDATE categorias SET nome = spnome, sigla = spsigla WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_cliente_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_cliente_insert`(
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
-- procedure sp_clientes_delete
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_clientes_delete`(IN p_id INT)
BEGIN
    DELETE FROM clientes WHERE id = p_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_clientes_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_clientes_insert`(
spnome varchar(100), 
spcpf char(11), 
sptelefone char(14), 
spemail varchar(60), 
spda_tanasc date
)
begin 
	insert into clientes 
    values (0,spnome, spcpf, sptelefone, spemail, spdata_nasc,default,1);
    select  last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_clientes_select_all
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_clientes_select_all`()
BEGIN
    SELECT * FROM clientes;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_clientes_select_by_id
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_clientes_select_by_id`(IN p_id INT)
BEGIN
    SELECT * FROM clientes WHERE id = p_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_clientes_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_clientes_update`(
    IN p_id INT,
    IN p_nome VARCHAR(100),
    IN p_cpf CHAR(11),
    IN p_telefone CHAR(14),
    IN p_email VARCHAR(60),
    IN p_data_nasc DATE,
    IN p_ativo BIT(1)
)
BEGIN
    UPDATE clientes
    SET nome = p_nome,
        cpf = p_cpf,
        telefone = p_telefone,
        email = p_email,
        data_nasc = p_data_nasc,
        ativo = p_ativo
    WHERE id = p_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_deletar_cupom
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_deletar_cupom`(
    IN spid INT
)
BEGIN
    DELETE FROM Cupons
    WHERE Id = spid;

    SELECT ROW_COUNT() AS RegistrosDeletados;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_deletar_nivel
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_deletar_nivel`(
    IN spid INT
)
BEGIN
    DELETE FROM nivel
    WHERE id = spid;

    SELECT ROW_COUNT() AS RegistrosDeletados;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_editar_nivel
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_editar_nivel`(
    IN spid INT,
    IN spnome VARCHAR(45),
    IN spsigla VARCHAR(45)
)
BEGIN
    UPDATE nivel
    SET nome = spnome,
        sigla = spsigla
    WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_endereco_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_endereco_insert`(
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
-- procedure sp_enderecos_delete
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_enderecos_delete`(IN p_id INT)
BEGIN
    DELETE FROM enderecos WHERE id = p_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_enderecos_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_enderecos_insert`(
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
-- procedure sp_enderecos_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_enderecos_update`(
    IN p_id INT,
    IN p_cliente_id INT,
    IN p_cep CHAR(8),
    IN p_logradouro VARCHAR(100),
    IN p_numero VARCHAR(40),
    IN p_complemento VARCHAR(60),
    IN p_bairro VARCHAR(60),
    IN p_cidade VARCHAR(60),
    IN p_uf CHAR(2),
    IN p_tipo_endereco CHAR(3)
)
BEGIN
    UPDATE enderecos
    SET cliente_id = p_cliente_id,
        cep = p_cep,
        logradouro = p_logradouro,
        numero = p_numero,
        complemento = p_complemento,
        bairro = p_bairro,
        cidade = p_cidade,
        uf = p_uf,
        tipo_endereco = p_tipo_endereco
    WHERE id = p_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_inserir_cupom
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_inserir_cupom`(
    spid INT,
    sptitulo VARCHAR(255),
    spcodigo VARCHAR(100),
    spcupomtipo VARCHAR(100),
    spdatacriacao DATETIME,
    spdatavalidade DATETIME,
    spvalorpedidominimo DECIMAL(18, 2),
    spvalormaximodesconto DECIMAL(18, 2),
    spvalormaximopedido DECIMAL(18, 2),
    spvalordesconto DECIMAL(18, 2),
    spdescricao VARCHAR(100),
    sptipodesconto Float,
    spclienteid INT,
    sppedidoid INT,
    sprevendedorid INT)
BEGIN
   
    INSERT INTO Cupons (
        Id,
        Titulo,
        Codigo,
        CupomTipo,
        DataCriacao,
        DataValidade,
        ValorPedidoMinimo,
        ValorMaximoDeDesconto,
        ValorMaximoPedido,
        ValorDesconto,
        Descricao,
        TpoDesconto,
        ClienteId,
        PedidoId,
        RevendedorId
    )
    VALUES (
        spid,
        sptitulo,
        spcodigo,
        spcupomtipo,
        spdatacriacao,
        spdatavalidade,
        spvalorpedidominimo,
        spvalormaximodesconto,
        spvalormaximopedido,
        spvalordesconto,
        spdescricao,
        sptipodesconto,
        spclienteid,
        sppedidoid,
        sprevendedorid
    );

    -- Retorna o ID inserido, se necessário (opcional)
    SELECT SCOPE_IDENTITY() AS NovoCupomId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_inserir_enderecos
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_inserir_enderecos`(
-- parâmetros da procedure
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
-- procedure sp_inserir_usuario
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_inserir_usuario`(
-- parâmetros da procedure
spnome varchar(60), spemail varchar(60), spsenha varchar(32), spnivel int)
begin
	insert into usuarios 
	values (0,spnome, spemail, md5(spsenha), spnivel, default);
    select * from usuarios where id = last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_fornecedores
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_insert_fornecedores`(
    IN sp_razao_social VARCHAR(100),
    IN sp_fantasia VARCHAR(40),
    IN sp_cnpj CHAR(14),
    IN sp_contato VARCHAR(60),
    IN sp_telefone VARCHAR(45),
    IN sp_email VARCHAR(60)
)
BEGIN
    INSERT INTO fornecedores (
        razao_social,
        fantasia,
        cnpj,
        contato,
        telefone,
        email
    )
    VALUES (
        sp_razao_social,
        sp_fantasia,
        sp_cnpj,
        sp_contato,
        sp_telefone,
        sp_email
    );
    
    SELECT LAST_INSERT_ID() AS NovoFornecedorId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_nivel
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_insert_nivel`(
    IN spnome VARCHAR(45),
    IN spsigla VARCHAR(45)
)
BEGIN
    INSERT INTO nivel (nome, sigla)
    VALUES (spnome, spsigla);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_pedido_insert`(
    IN sp_usuario_id INT,
    IN sp_cliente_id INT,
    IN sp_data TIMESTAMP,
    IN sp_status CHAR(1),
    IN sp_desconto DECIMAL(10,2)
)
BEGIN
    INSERT INTO pedido (
        usuario_id,
        cliente_id,
        data,
        status,
        desconto
    ) VALUES (
        sp_usuario_id,
        sp_cliente_id,
        sp_data,
        sp_status,
        sp_desconto
    );
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_pedido_update`(
    IN sp_id INT,
    IN sp_usuario_id INT,
    IN sp_cliente_id INT,
    IN sp_data TIMESTAMP,
    IN sp_status CHAR(1),
    IN sp_desconto DECIMAL(10,2)
)
BEGIN
    UPDATE pedido
    SET
        usuario_id = sp_usuario_id,
        cliente_id = sp_cliente_id,
        data = sp_data,
        status = sp_status,
        desconto = sp_desconto
    WHERE id = sp_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_produto_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
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
-- procedure sp_usuario_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_usuario_insert`(
  spnome VARCHAR(100),
  spemail VARCHAR(240),
  sp_id_nivel int,
  spsenha VARCHAR(32)
)
BEGIN
   INSERT INTO usuarios (nome,  email, id_nivel ,senha)
    VALUES (spnome, spemail, sp_id_nivel,  MD5(spsenha));
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_usuario_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_usuario_update`(
	sp_id INT,
	sp_nome VARCHAR(100),
	sp_id_nivel INT,
    sp_ativo BOOLEAN
)
BEGIN
    UPDATE usuarios
    SET nome = sp_nome,
		id_nivel = sp_id_nivel,
        ativo = sp_ativo
    WHERE id = sp_id;
END$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
