create database dbSysEdit

use dbSysEdit

create table tblEditoras(
	EdiID			int			not null	primary key,
	EdiNome			varchar(50)	not null,
	EdiSigla		varchar(25)	not null,
	EdiObservacoes	varchar(500)	null
);

create table tblLivros(
	LivID				int			not null	primary key,
	LivNome				varchar(50)	not null,
	LivAnoPublicacao	int			not null,
	LivISBN				decimal(14)	not null,
	LivObservacoes		varchar(500)	null,
	EdiID				int			not null,
	foreign key(EdiID) references tblEditoras(EdiID)
);

create table tblAutores(
	AutID			int			not null	primary key,
	AutNome			varchar(50)	not null,
	AutPseudonimo	varchar(50)	not null,
	AutObservacoes	varchar	(500)	null
);

create table tblAutoresLivros(
	LivID			int			not null,
	AutID			int			not null,
	primary key(LivID,AutID),
	foreign key(LivID) references tblLivros(LivID),
	foreign key(AutID) references tblAutores(AutID)
);