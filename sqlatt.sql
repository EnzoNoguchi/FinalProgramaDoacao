
create database DoacaoBD;
use DoacaoBD;




-- =============================================================================================================================================================================================================




select * from Cliente;





-- =============================================================================================================================================================================================================




create table Cliente(
codigoCliente int not null auto_increment primary key,
email varchar(100) not null,
nome varchar(100) not null,
telefone varchar(12) not null,
endereco varchar(100) not null,
brinquedos varchar(4) not null,
roupas varchar(4) not null,
dinheiro varchar(4) not null,
alimento varchar(4) not null
)Engine = InnoDB;


-- =============================================================================================================================================================================================================



drop table Cliente;