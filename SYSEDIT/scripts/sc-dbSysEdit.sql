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

create table tblUsuarios(
	UserID			int				not null	primary key,
	UserCPF			decimal(11,0)	not null,
	UserNome		varchar(70)		not null,
	UserSenha		varchar(20)		not null,
	UserEmail		varchar(80)		not null,
	UserTelefone	decimal(11,0)	not null,
	UserObs			varchar(100)		null
);