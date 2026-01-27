/* Criar a tabela de utilizadores */
create table utilizadores(
	id int identity primary key,
	email varchar(100) not null unique 
		check (email like '%@%.%'),
	nome varchar(100) not null,
	palavra_passe varchar(64),
	sal int,
	token varchar(100),
	data_validade date,
	perfil int --0 admin, 1 cliente, 2 funcionario
)
/* Criar um admin */
INSERT INTO utilizadores(email,nome,palavra_passe,sal,perfil)
VALUES ('admin@gmail.com','admin',HASHBYTES('SHA2_512','123450'),0,0);

select * from utilizadores
