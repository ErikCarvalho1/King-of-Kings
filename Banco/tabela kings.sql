-- Tabela: niveis
CREATE TABLE IF NOT EXISTS `kings`.`niveis` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `sigla` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE = InnoDB;

-- Tabela: usuarios
CREATE TABLE IF NOT EXISTS `kings`.`usuarios` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `nivel_id` INT NOT NULL,
  `ativo` BIT(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC),
  INDEX `fk_usuarios_niveis1_idx` (`nivel_id` ASC),
  CONSTRAINT `fk_usuarios_niveis1`
    FOREIGN KEY (`nivel_id`)
    REFERENCES `kings`.`niveis` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB AUTO_INCREMENT = 1001 DEFAULT CHARACTER SET = utf8;

-- Tabela: caixas
CREATE TABLE IF NOT EXISTS `kings`.`caixas` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `usuario_id` INT(4) NOT NULL,
  `data_abertura` DATETIME NOT NULL,
  `saldo_inicial` DECIMAL(10,2) NOT NULL,
  `status` CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`id`),
  INDEX `fk_Caixa_Usuarios1_idx` (`usuario_id` ASC),
  CONSTRAINT `fk_Caixa_Usuarios1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `kings`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabela: categorias
CREATE TABLE IF NOT EXISTS `kings`.`categorias` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NOT NULL,
  `sigla` CHAR(3) NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE = InnoDB AUTO_INCREMENT = 1 DEFAULT CHARACTER SET = utf8;

-- Tabela: clientes
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
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC)
) ENGINE = InnoDB AUTO_INCREMENT = 10001 DEFAULT CHARACTER SET = utf8;

-- Tabela: enderecos
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
  INDEX `fk_table1_clientes_idx` (`cliente_id` ASC),
  CONSTRAINT `fk_table1_clientes`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `kings`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB AUTO_INCREMENT = 1 DEFAULT CHARACTER SET = utf8;

-- Tabela: produtos
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
  `descontinuado` BIT(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `idProduto_UNIQUE` (`id` ASC),
  UNIQUE INDEX `Produtocol_UNIQUE` (`cod_barras` ASC),
  INDEX `fk_Produto_Categorias1_idx` (`categoria_id` ASC),
  CONSTRAINT `fk_Produto_Categorias1`
    FOREIGN KEY (`categoria_id`)
    REFERENCES `kings`.`categorias` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB AUTO_INCREMENT = 7400001 DEFAULT CHARACTER SET = utf8;

-- Tabela: estoques
CREATE TABLE IF NOT EXISTS `kings`.`estoques` (
  `produto_id` INT(4) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `data_ultimo_movimento` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  INDEX `fk_Estoque_Produto1_idx` (`produto_id` ASC),
  CONSTRAINT `fk_Estoque_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabela: fornecedores
CREATE TABLE IF NOT EXISTS `kings`.`fornecedores` (
  `id` INT(4) NOT NULL,
  `razao_social` VARCHAR(100) NOT NULL,
  `fantasia` VARCHAR(40) NOT NULL,
  `cnpj` CHAR(14) NOT NULL,
  `contato` VARCHAR(60) NULL DEFAULT NULL,
  `telefone` VARCHAR(45) NULL DEFAULT NULL,
  `email` VARCHAR(60) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cnpj_UNIQUE` (`cnpj` ASC)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabela: pedidos
CREATE TABLE IF NOT EXISTS `kings`.`pedidos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `usuario_id` INT(4) NOT NULL,
  `cliente_id` INT(4) NOT NULL,
  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `status` CHAR(1) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Pedido_Usuarios1_idx` (`usuario_id` ASC),
  INDEX `fk_Pedido_Clientes1_idx` (`cliente_id` ASC),
  CONSTRAINT `fk_Pedido_Clientes1`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `kings`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pedido_Usuarios1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `kings`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB AUTO_INCREMENT = 100001 DEFAULT CHARACTER SET = utf8;

-- Tabela: itempedido
CREATE TABLE IF NOT EXISTS `kings`.`itempedido` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `pedido_id` INT(11) NOT NULL,
  `produto_id` INT(11) NOT NULL,
  `valor_unit` DECIMAL(10,2) NOT NULL,
  `quantidade` DECIMAL(10,3) NOT NULL,
  `desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_ItemPedido_Pedido1_idx` (`pedido_id` ASC),
  INDEX `fk_ItemPedido_Produto1_idx` (`produto_id` ASC),
  CONSTRAINT `fk_ItemPedido_Pedido1`
    FOREIGN KEY (`pedido_id`)
    REFERENCES `kings`.`pedidos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemPedido_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB AUTO_INCREMENT = 1 DEFAULT CHARACTER SET = utf8;

-- Tabela: produtofornecedor
CREATE TABLE IF NOT EXISTS `kings`.`produtofornecedor` (
  `produto_id` INT(4) NOT NULL,
  `fornecedores_id` INT(4) NOT NULL,
  PRIMARY KEY (`produto_id`, `fornecedores_id`),
  INDEX `fk_Produto_has_Fornecedores_Fornecedores1_idx` (`fornecedores_id` ASC),
  INDEX `fk_Produto_has_Fornecedores_Produto1_idx` (`produto_id` ASC),
  CONSTRAINT `fk_Produto_has_Fornecedores_Fornecedores1`
    FOREIGN KEY (`fornecedores_id`)
    REFERENCES `kings`.`fornecedores` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Produto_has_Fornecedores_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabela: revendedores
CREATE TABLE IF NOT EXISTS `kings`.`revendedores` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `cpf_cnpj` VARCHAR(18) NOT NULL,
  `telefone` VARCHAR(20),
  `email` VARCHAR(100),
  `ativo` BIT(1) DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cpf_cnpj_UNIQUE` (`cpf_cnpj`),
  UNIQUE INDEX `email_UNIQUE` (`email`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabela: cupons
CREATE TABLE IF NOT EXISTS `kings`.`cupons` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(100) NOT NULL,
  `codigo` VARCHAR(50) NOT NULL UNIQUE,
  `cupom_tipo` VARCHAR(20) NOT NULL,
  `data_criacao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `data_validade` DATE NOT NULL,
  `valor_pedido_minimo` DECIMAL(10,2),
  `valor_maximo_desconto` DECIMAL(10,2),
  `valor_maximo_pedido` DECIMAL(10,2),
  `valor_desconto` DECIMAL(10,2) NOT NULL,
  `descricao` TEXT,
  `tipo_desconto` BIT(1) NOT NULL,
  `cliente_id` INT,
  `pedido_id` INT,
  `revendedor_id` INT,
  PRIMARY KEY (`id`),
  INDEX `fk_cupons_clientes_idx` (`cliente_id` ASC),
  INDEX `fk_cupons_pedidos_idx` (`pedido_id` ASC),
  INDEX `fk_cupons_revendedores_idx` (`revendedor_id` ASC),
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
    ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
