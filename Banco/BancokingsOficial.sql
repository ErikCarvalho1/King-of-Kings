drop database kings;

create database kings;

use kings;

create table clientes(
id int(5) auto_increment,
nome varchar(50) not null,
cpf varchar(11) not null,
primary key(id)
);

create table enderecos(
id int(5) auto_increment,
rua varchar(40) not null,
num int(4) not null,
cidade varchar(30) not null,
estado varchar(2) not null,
cep varchar(8) not null,
id_cliente int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id)
);

create table complementos(
id int(5) auto_increment,
complemento varchar(50) not null,
id_endereco int(5) not null,
primary key(id),
foreign key(id_endereco) references enderecos(id)
);

create table emails(
id int(5) auto_increment,
email varchar(60) not null,
id_cliente int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id)
);

create table telefones(
id int(5) auto_increment,
telefone varchar(9) not null,
id_cliente int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id)
);

create table enderecos_clientes(
id int(5) auto_increment,
id_cliente int(5) not null,
id_endereco int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id),
foreign key(id_endereco) references enderecos(id)
);

create table emails_clientes(
id int(5) auto_increment,
id_cliente int(5) not null,
id_email int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id),
foreign key(id_email) references emails(id)
);

create table telefones_clientes(
id int(5) auto_increment,
id_cliente int(5) not null,
id_telefone int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id),
foreign key(id_telefone) references telefones(id)
);

create table clientes_fiado(
id int(5) auto_increment,
id_fiado int(5) not null,
primary key(id),
foreign key(id_fiado) references clientes(id)
);

create table funcionarios(
id int(5) auto_increment,
nome varchar(50) not null,
cpf varchar(11) not null,
id_emails_funcionarios int (5) not null,
primary key(id),
foreign key(id_emails_funcionarios) references (id_

);

create table enderecos_funcionarios(
id int(5) auto_increment,
id_funcionario int(5) not null,
id_endereco int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id),
foreign key(id_endereco) references enderecos(id)
);

create table emails_funcionarios(
id int(5) auto_increment,
id_funcionario int(5) not null,
id_email int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id),
foreign key(id_email) references enderecos(id)
);

create table telefones_funcionarios(
id int(5) auto_increment,
id_funcionario int(5) not null,
id_telefone int(5) not null,
id_cliente int (5) not null,
id_email int(5) not null,
primary key(id),
foreign key(id_cliente) references clientes(id),
foreign key(id_telefone) references telefones(id)
);