CREATE DATABASE VirtuaLearn;

GO

USE VirtuaLearn;

CREATE TABLE Login(
	Id_Login			INT IDENTITY,
	Usuario				VARCHAR(50) NOT NULL UNIQUE,
	Senha				VARCHAR(200) NOT NULL,
	Tipo				INT			NOT NULL,  -- 1 == Aluno; 2 == Professor; 3 == administrador
	CONSTRAINT PK_Login_Id_Login PRIMARY KEY(Id_Login)
);

insert into Login(Usuario, Senha, Tipo) values('Butter1', 'e10adc3949ba59abbe56e057f20f883e', 3);

select * from Login;

CREATE TABLE Aluno(
	Id_Aluno	INT IDENTITY,
	Nome		VARCHAR(50) NOT NULL,
	Email		VARCHAR(50) NOT NULL,
	Cpf			CHAR(11)	NOT NULL UNIQUE,
	Rg			VARCHAR(10)	NOT NULL,
	Nascimento	DATE		NOT NULL,
	Telefone	VARCHAR(11) NOT NULL,
	Rua_Av		VARCHAR(50) NOT NULL,
	Numero		VARCHAR(10) NOT NULL,
	Bairro		VARCHAR(50) NOT NULL,
	Cidade		VARCHAR(50) NOT NULL,
	Estado		CHAR(2)		NOT NULL,
	Cep			CHAR(8)		NOT NULL,
	Id_Login	INT			NOT NULL,
	CONSTRAINT PK_Aluno_Id_Aluno PRIMARY KEY(Id_Aluno),
	CONSTRAINT FK_Aluno_Login FOREIGN KEY(Id_Login) REFERENCES Login(Id_Login)
	--tem que se conectar a assinatura
);

select * from Aluno;

CREATE TABLE Professor(
	Id_Professor	INT IDENTITY,
	Nome			VARCHAR(50)		NOT NULL,
	Email			VARCHAR(50)		NOT NULL,		
	Telefone		VARCHAR(11)		Not NULL,
	Descricao		VARCHAR(500)	NOT NULL,
	Foto			VARCHAR(50),
	Cpf				CHAR(11)		NOT NULL UNIQUE,	
	Id_Login		int				NOT NULL,
	CONSTRAINT PK_Professor_Id_Professor PRIMARY KEY(Id_Professor),
	CONSTRAINT FK_Professor_Login FOREIGN KEY(Id_Login) REFERENCES Login(Id_Login)
);

select * from Professor;

CREATE TABLE Administrador(
	Id_Adm			INT IDENTITY,
	Nome			VARCHAR(20)		NOT NULL,
	Email			VARCHAR(30)		NOT NULL,
	Foto			VARCHAR(50),
	Id_Login		INT				NOT NULL,
	CONSTRAINT PK_Administrador_Id_Adm PRIMARY KEY(Id_Adm),
	CONSTRAINT FK_Administrador_Id_Login FOREIGN KEY(Id_Login) REFERENCES Login(Id_Login)
);

insert into Administrador(Nome, Email, Foto, Id_Login) VALUES ('Rodrigo de Souza', 'fabiano.ryukendo@hotmail.com', 'GAMBIARRA', 1);

select * from Administrador;

CREATE TABLE Curso(
	Id_Curso		INT IDENTITY,
	Imagem			VARCHAR(50),
	Nome			VARCHAR(50)		NOT NULL,
	Valor			MONEY			NOT NULL,
	Horas			VARCHAR(10)		NOT NULL,
	Descricao		VARCHAR(500)	NOT NULL,
	Id_Professor	INT,
	Id_Adm			INT,
	CONSTRAINT PK_Curso_Id_Curso PRIMARY KEY(Id_Curso),
	CONSTRAINT FK_Curso_Professor FOREIGN KEY(Id_Professor) REFERENCES Professor(Id_Professor),
	CONSTRAINT FK_Curso_Administrador FOREIGN KEY(Id_Adm) REFERENCES Administrador(Id_Adm)
	--tem que se conectar a assinatura
);

--insert into Curso(Imagem, Nome, Valor, Horas, Descricao) VALUES ('img/open-book.png', 'TÉCNICAS DE NEGOCIAÇÃO', 80 , '20', 'Neste curso você verá as técnicas mais adequadas para empregar em processos de negociação, de tal forma que potencialize suas chances de sucesso.');

--delete from Curso;

select * from Curso;

/*CREATE TABLE Carrinho(
	Id_Carrinho		INT IDENTITY,
	Produto			VARCHAR(50),
	Fotinha			VARCHAR(50),
	Preco			MONEY,
	Quantidade		INT,
	Total			MONEY,
	Id_Curso		INT,
	Id_Aluno		INT,
	CONSTRAINT PK_Id_Carrinho PRIMARY KEY(Id_Carrinho),
	CONSTRAINT FK_Curso_Carrinho FOREIGN KEY(Id_Curso) REFERENCES Curso(Id_Curso),
	CONSTRAINT FK_Aluno_Carrinho FOREIGN KEY(Id_Aluno) REFERENCES Aluno(Id_Aluno)
);

select * from Carrinho;*/

CREATE TABLE Contato(
	Id_Contato		INT IDENTITY,
	Nome			VARCHAR(20),
	Sobrenome		VARCHAR(30),
	Email			VARCHAR(30),
	Duvida			VARCHAR(500),
	CONSTRAINT PK_Contato_Id_Contato PRIMARY KEY(Id_Contato)
);

select * from Contato;



--------------------------------------------------------------------------------------------------------------

/*CREATE TABLE Assinatura(
	Id_Ass				INT IDENTITY,
	Status_Curso		VARCHAR(20)	NOT NULL,
	Status_Certificado	VARCHAR(20) NOT NULL,
	Data_Comeco			DATE		NOT NULL,
	Data_Termino		DATE		NOT NULL,
	Curso				VARCHAR(50) NOT NULL,
	Pagamento			MONEY		NOT NULL,
	Id_Aluno			INT,
	Id_Curso			INT,
	CONSTRAINT PK_Assinatura_Id_Ass PRIMARY KEY(Id_Ass),
	CONSTRAINT FK_curso_Curso FOREIGN KEY(Id_Curso) REFERENCES Curso(Id_Curso),
	CONSTRAINT FK_Assinatura_Aluno FOREIGN KEY(Id_Aluno) REFERENCES Aluno(Id_Aluno)
); 

select * from Assinatura;*/

CREATE TABLE Quizz(
	Id_Quizz		INT IDENTITY,	
	Nome			VARCHAR(30)		NOT NULL,
	Id_Curso		INT				NOT NULL,
	Id_Professor	INT,
	Id_Adm			INT				NOT NULL,
	CONSTRAINT PK_Quizz_IdQuizz PRIMARY KEY(Id_Quizz),
	CONSTRAINT FK_Quizz_Curso FOREIGN KEY(Id_Curso) REFERENCES Curso(Id_Curso),
	CONSTRAINT FK_Quizz_Professor FOREIGN KEY(Id_Professor) REFERENCES Professor(Id_Professor),
	CONSTRAINT FK_Quizz_Administrador FOREIGN KEY(Id_Adm) REFERENCES Administrador(Id_Adm)
);

select * from Quizz;

CREATE TABLE Pergunta(
	Id_Pergunta		INT IDENTITY,
	Questao			VARCHAR(500)	NOT NULL,
	Res1			VARCHAR(300)	NOT NULL,
	Res2			VARCHAR(300)	NOT NULL,
	Res3			VARCHAR(300)	NOT NULL,
	Res4			VARCHAR(300)	NOT NULL,
	Certa			INT				NOT NULL,
	Id_Quizz		INT				NOT NULL,
	Id_Professor	INT,
	Id_Adm			INT				NOT NULL,
	CONSTRAINT PK_Pergunta_Id_Pergunta PRIMARY KEY(Id_Pergunta),
	CONSTRAINT FK_Pergunta_Quizz FOREIGN KEY(Id_Quizz) REFERENCES Quizz(Id_Quizz),
	CONSTRAINT FK_Pergunta_Professor FOREIGN KEY(Id_Professor) REFERENCES Professor(Id_Professor),
	CONSTRAINT FK_Pergunta_Administrador FOREIGN KEY(Id_Adm) REFERENCES Administrador(Id_Adm)
);

select * from Pergunta;

CREATE TABLE ResUsu(
	Id_ResUsu		INT IDENTITY,
	Resposta		INT				NOT NULL,
	Id_Pergunta		INT				NOT NULL,
	Id_Quizz		INT				NOT NULL,
	Id_Aluno		INT				NOT NULL,
	CONSTRAINT PK_ResUsu_Id_ResUsu PRIMARY KEY(Id_ResUsu),
	CONSTRAINT FK_ResUsu_Pergunta FOREIGN KEY(Id_Pergunta) REFERENCES Pergunta(Id_Pergunta),
	CONSTRAINT FK_ResUsu_Aluno FOREIGN KEY(Id_Aluno) REFERENCES Aluno(Id_Aluno),
	CONSTRAINT FK_ResUsu_Quizz FOREIGN KEY(Id_Quizz) REFERENCES Quizz(Id_Quizz)		
);

select * from ResUsu;

CREATE TABLE Aula(
	Id_Aula			INT IDENTITY,
	Nome			VARCHAR(50)		NOT NULL,
	Video			VARCHAR(100)	NOT NULL,
	Material		VARCHAR(50)		NOT NULL,
	Descricao		VARCHAR(300)	NOT NULL,
	Id_Curso		INT				NOT NULL,
	Id_Professor	INT,
	Id_Adm			INT				NOT NULL,
	CONSTRAINT PK_Aula_Id_Aula PRIMARY KEY(Id_Aula),
	CONSTRAINT FK_Aula_Curso FOREIGN KEY(Id_Curso) REFERENCES Curso(Id_Curso),
	CONSTRAINT FK_Aula_Professor FOREIGN KEY(Id_Professor) REFERENCES Professor(Id_Professor),
	CONSTRAINT FK_Aula_Administrador FOREIGN KEY(Id_Adm) REFERENCES Administrador(Id_Adm)
);

select * from Aula;

CREATE TABLE Termos(
	Id_Termos		INT IDENTITY,
	Termos			VARCHAR(50)		NOT NULL,
	CONSTRAINT PK_Termos_Id_Termos PRIMARY KEY(Id_Termos)
);

select * from Termos;

/*INSERT INTO  Respostas(Respostas) VALUES ('AAA');

DROP TABLE Respostas;

DELETE FROM Respostas WHERE Id_Respostas = 1;
*/ 