--SQL SERVER 2019

CREATE DATABASE Certificado

USE Certificado

CREATE TABLE login_sistema
(
id_usuario    varchar (20) not null primary key,
nome_usuario  varchar (50) not null,
login_usuario varchar (30) not null,
senha_usuario varchar (20) not null,
tipo_usuario  varchar (2)  not null,
);

SELECT *
	FROM login_sistema e

--TIPO 1 - ALUNO
--TIPO 2 - PROFESSOR / DIRETOR



CREATE TABLE professor
(
professor_id      varchar(5)  not null primary key,
professor_nome    varchar(50) not null,
professor_materia varchar(50) not null,
);


CREATE TABLE alunos
(
aluno_id        varchar(5)  not null primary key,
aluno_matricula varchar(5)  not null,
aluno_nome		varchar(50) not null,
aluno_cpf		varchar(11) not null,
);

select * 
	from alunos;


CREATE TABLE alunos_documentos;
(
id_documento varchar(5) not null,
aluno_id varchar(5) not null, --primary key da tabela alunos
aluno_nome_documento varchar(50) not null,
aluno_tipo_atividade varchar(20) not null,
aluno_qt_horas varchar(10) not null,
aluno_status varchar(20) not null,
aluno_documento varbinary(max) not null
);


SELECT *
	FROM alunos_documentos;


--CRIO UMA CHAVE ESTRANGEIRA(FOREIGN KEY) NA TABELA alunos_documentos
--A CHAVE ESTRANGEIRA É A CHAVE PRIMARIA (PRIMARY KEY) TA TABELA alunos
alter table alunos_documentos
add constraint fk_aluno_id foreign key (aluno_id)
references alunos (aluno_id);