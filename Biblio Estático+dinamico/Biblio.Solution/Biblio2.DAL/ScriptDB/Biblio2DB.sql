CREATE DATABASE Biblio2DB;
DROP DATABASE Biblio2DB;

USE Biblio2DB;

DROP TABLE IF EXISTS TipoUsuario;
CREATE TABLE TipoUsuario (
	IdTipoUsuario INT PRIMARY KEY IDENTITY (1,1),
	DescricaoTipoUsuario VARCHAR(150) NOT NULL
);

INSERT INTO TipoUsuario (DescricaoTipoUsuario)
VALUES 
	('Administrador'), ('Autor'), ('Comum');

SELECT * FROM TipoUsuario;
UPDATE TipoUsuario SET DescricaoTipoUsuario = 'Administrador'
WHERE IdTipoUsuario = 1;

DROP TABLE IF EXISTS Usuario;
CREATE TABLE Usuario (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    NomeUsuario VARCHAR(150) UNIQUE NOT NULL,
    EmailUsuario VARCHAR(150) UNIQUE NOT NULL,
    SenhaUsuario VARCHAR(8) NOT NULL,
	UrlFotoPerfil VARCHAR(150) NULL,
    UsuarioTipo INT NOT NULL,

    FOREIGN KEY (UsuarioTipo) REFERENCES TipoUsuario (IdTipoUsuario)
);

INSERT INTO Usuario (NomeUsuario, EmailUsuario, SenhaUsuario, UrlFotoPerfil, UsuarioTipo) 
VALUES 
	('admin', 'admin@email.com', 'admin', 'img/admin.jpg', 1),
	('autor', 'autor@gmail.com', 'autor', 'img/autor.jpg', 2),
	('comum', 'comum@email.com', 'comum', 'img/comum.jpg', 3)
;

-----------------------------------------------------------------------------------------------------------------------

-- CRUD Usuario --

-- CREATE (Inserção de Usuário)
INSERT INTO Usuario (NomeUsuario, EmailUsuario, SenhaUsuario, UrlFotoPerfil, UsuarioTipo) 
VALUES (@NomeUsuario, @EmailUsuario, @SenhaUsuario, @UrlFotoPerfil, @UsuarioTipo);

-- READ (Consulta de Usuários)
SELECT IdUsuario, NomeUsuario, EmailUsuario, SenhaUsuario, UrlFotoPerfil, DescricaoTipoUsuario FROM Usuario 
INNER JOIN TipoUsuario ON Usuario.UsuarioTipo = TipoUsuario.IdTipoUsuario;

-- UPDATE (Atualização de Usuário)
UPDATE Usuario
SET NomeUsuario = @NomeUsuario, 
    EmailUsuario = @EmailUsuario, 
    SenhaUsuario = @SenhaUsuario,
	UrlFotoPerfil = @UrlFotoPerfil,
    UsuarioTipo = @UsuarioTipo
WHERE IdUsuario = @IdUsuario;

-- DELETE (Remoção de Usuário)
DELETE FROM Usuario WHERE IdUsuario = @IdUsuario;

-- Funções extras

-- AUTHENTICATION (Verificar usuário para login)
SELECT IdUsuario, NomeUsuario, EmailUsuario, SenhaUsuario
FROM Usuario 
WHERE NomeUsuario = @NomeUsuario AND SenhaUsuario = @SenhaUsuario;

-- SEARCH BY ID (Buscar usuário pelo ID)
SELECT IdUsuario, NomeUsuario, EmailUsuario, UsuarioTipo 
FROM Usuario 
WHERE IdUsuario = @IdUsuario;

-----------------------------------------------------------------------------------------------------------------------

-- Reiniciar a tabela Livro
DROP TABLE IF EXISTS Genero;
CREATE TABLE Genero (
	IdGenero INT PRIMARY KEY IDENTITY (1,1),
	DescricaoGenero VARCHAR(150) NOT NULL
);

INSERT INTO Genero (DescricaoGenero) 
VALUES 
	('Ficção Científica'), ('Fantasia'), ('Romance'), ('Terror'), ('Mistério'), ('Aventura'), ('Ciência'), ('Tecnologia'),
	('Suspense'), ('Drama'), ('Biografia'), ('História'), ('Autoajuda'), ('Filosofia'), ('Psicologia');

-- Reiniciar a tabela Livro
DROP TABLE IF EXISTS Livro;
CREATE TABLE Livro (
	IdLivro INT PRIMARY KEY IDENTITY(1,1),
	TituloLivro VARCHAR(150) UNIQUE NOT NULL,
	GeneroLivro INT NOT NULL,
	SinopseLivro VARCHAR(150) NOT NULL,
	AutorLivro VARCHAR(150) NOT NULL,
	DataPublicacaoLivro DATE NOT NULL,
	UrlCapaLivro VARCHAR(150) NOT NULL,
	UrlIconLivro VARCHAR(150) NOT NULL,
	UrlBannerLivro VARCHAR(150) NULL,
	UrlPDFLivro VARCHAR(150) NOT NULL,

	FOREIGN KEY (GeneroLivro) REFERENCES Genero (IdGenero)
);

	CREATE TABLE LivroFavorito (
    IdFavorito INT PRIMARY KEY IDENTITY (1,1),
    UsuarioId INT NOT NULL,
    LivroId INT NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES dbo.Usuario(IdUsuario),
    FOREIGN KEY (LivroId) REFERENCES dbo.Livro(IdLivro),
    UNIQUE (UsuarioId, LivroId)
);
-----------------------------------------------------------------------------------------------------------------------

/* CRUD Livro */

-- CREATE (Inserção de Livro)
INSERT INTO Livro (
    TituloLivro, 
    GeneroLivro, 
    SinopseLivro, 
    AutorLivro, 
    DataPublicacaoLivro, 
    UrlCapaLivro, 
    UrlIconLivro, 
    UrlBannerLivro, 
    UrlPDFLivro
) 
VALUES (
    @TituloLivro, 
    @GeneroLivro, 
    @SinopseLivro, 
    @AutorLivro, 
    @DataPublicacaoLivro, 
    @UrlCapaLivro, 
    @UrlIconLivro, 
    @UrlBannerLivro, 
    @UrlPDFLivro
);

-- READ (Consulta de Livros)
SELECT 
    L.IdLivro, 
    L.TituloLivro, 
    G.DescricaoGenero AS Genero, 
    L.SinopseLivro, 
    L.AutorLivro, 
    L.DataPublicacaoLivro, 
    L.UrlCapaLivro, 
    L.UrlIconLivro, 
    L.UrlBannerLivro, 
    L.UrlPDFLivro
FROM 
    Livro L
INNER JOIN 
    Genero G ON L.GeneroLivro = G.IdGenero;

-- UPDATE (Atualização de Livro)
UPDATE Livro
SET 
    TituloLivro = @TituloLivro, 
    GeneroLivro = @GeneroLivro, 
    SinopseLivro = @SinopseLivro, 
    AutorLivro = @AutorLivro, 
    DataPublicacaoLivro = @DataPublicacaoLivro, 
    UrlCapaLivro = @UrlCapaLivro, 
    UrlIconLivro = @UrlIconLivro, 
    UrlBannerLivro = @UrlBannerLivro, 
    UrlPDFLivro = @UrlPDFLivro
WHERE IdLivro = @IdLivro;

-- DELETE (Remoção de Livro)
DELETE FROM Livro WHERE IdLivro = @IdLivro;

/* Funções extras */

-- SEARCH BY ID (Buscar livro pelo ID)
SELECT 
    L.IdLivro, 
    L.TituloLivro, 
    G.DescricaoGenero AS Genero, 
    L.SinopseLivro, 
    L.AutorLivro, 
    L.DataPublicacaoLivro, 
    L.UrlCapaLivro, 
    L.UrlIconLivro, 
    L.UrlBannerLivro, 
    L.UrlPDFLivro
FROM Livro L
INNER JOIN Genero G ON L.GeneroLivro = G.IdGenero
WHERE L.IdLivro = @IdLivro;

-- SEARCH BY TITLE (Buscar livros pelo título)
SELECT 
    L.IdLivro, 
    L.TituloLivro, 
    G.DescricaoGenero AS Genero, 
    L.SinopseLivro, 
    L.AutorLivro, 
    L.DataPublicacaoLivro, 
    L.UrlCapaLivro, 
    L.UrlIconLivro, 
    L.UrlBannerLivro, 
    L.UrlPDFLivro
FROM Livro L
INNER JOIN Genero G ON L.GeneroLivro = G.IdGenero
WHERE L.TituloLivro LIKE '%' + @TituloLivro + '%';

-- SEARCH BY GENRE (Buscar livros por gênero)
SELECT 
    L.IdLivro, 
    L.TituloLivro, 
    G.DescricaoGenero AS Genero, 
    L.SinopseLivro, 
    L.AutorLivro, 
    L.DataPublicacaoLivro, 
    L.UrlCapaLivro, 
    L.UrlIconLivro, 
    L.UrlBannerLivro, 
    L.UrlPDFLivro
FROM Livro L
INNER JOIN Genero G ON L.GeneroLivro = G.IdGenero
WHERE L.GeneroLivro = @GeneroLivro;

-- SEARCH BY AUTHOR (Buscar livros por autor)
SELECT 
    L.IdLivro, 
    L.TituloLivro, 
    G.DescricaoGenero AS Genero, 
    L.SinopseLivro, 
    L.AutorLivro, 
    L.DataPublicacaoLivro, 
    L.UrlCapaLivro, 
    L.UrlIconLivro, 
    L.UrlBannerLivro, 
    L.UrlPDFLivro
FROM Livro L
INNER JOIN Genero G ON L.GeneroLivro = G.IdGenero
WHERE L.AutorLivro LIKE '%' + @AutorLivro + '%';

-----------------------------------------------------------------------------------------------------------------------

-- Os livros upados pelos autores são postos aqui, esperando a confirmação de um administrador pra poder aparecer para os usuários comuns
DROP TABLE IF EXISTS LivroRequisicao;
CREATE TABLE LivroRequisicao (
    IdLivroRequisicao INT PRIMARY KEY IDENTITY(1,1),
    TituloLivroRequisicao VARCHAR(150) UNIQUE NOT NULL,
    GeneroLivroRequisicao INT NOT NULL,
    SinopseLivroRequisicao VARCHAR(150) NOT NULL,
    AutorLivroRequisicao VARCHAR(150) NOT NULL,
    DataPublicacaoLivroRequisicao DATE NOT NULL,
    UrlCapaLivroRequisicao VARCHAR(150) NOT NULL,
    UrlIconLivroRequisicao VARCHAR(150) NOT NULL,
    UrlBannerLivroRequisicao VARCHAR(150) NULL,
    UrlPDFLivroRequisicao VARCHAR(150) NOT NULL,

    FOREIGN KEY (GeneroLivroRequisicao) REFERENCES Genero (IdGenero)
);

-----------------------------------------------------------------------------------------------------------

/* CRUD LivroRequisicao */

-- CREATE (Inserção de Livro Pendente)
INSERT INTO LivroRequisicao (
    TituloLivroRequisicao, 
    GeneroLivroRequisicao, 
    SinopseLivroRequisicao, 
    AutorLivroRequisicao, 
    DataPublicacaoLivroRequisicao, 
    UrlCapaLivroRequisicao, 
    UrlIconLivroRequisicao, 
    UrlBannerLivroRequisicao, 
    UrlPDFLivroRequisicao
)
VALUES (
    @TituloLivroRequisicao, 
    @GeneroLivroRequisicao, 
    @SinopseLivroRequisicao, 
    @AutorLivroRequisicao, 
    @DataPublicacaoLivroRequisicao, 
    @UrlCapaLivroRequisicao, 
    @UrlIconLivroRequisicao, 
    @UrlBannerLivroRequisicao, 
    @UrlPDFLivroRequisicao
);

-- READ (Consulta de Livros Pendentes)
SELECT 
    LR.IdLivroRequisicao, 
    LR.TituloLivroRequisicao, 
    G.DescricaoGenero AS Genero, 
    LR.SinopseLivroRequisicao, 
    LR.AutorLivroRequisicao, 
    LR.DataPublicacaoLivroRequisicao, 
    LR.UrlCapaLivroRequisicao, 
    LR.UrlIconLivroRequisicao, 
    LR.UrlBannerLivroRequisicao, 
    LR.UrlPDFLivroRequisicao
FROM 
    LivroRequisicao LR
INNER JOIN 
    Genero G ON LR.GeneroLivroRequisicao = G.IdGenero;

-- UPDATE (Atualização de Livro Pendente)
UPDATE LivroRequisicao
SET 
    TituloLivroRequisicao = @TituloLivroRequisicao, 
    GeneroLivroRequisicao = @GeneroLivroRequisicao, 
    SinopseLivroRequisicao = @SinopseLivroRequisicao, 
    AutorLivroRequisicao = @AutorLivroRequisicao, 
    DataPublicacaoLivroRequisicao = @DataPublicacaoLivroRequisicao, 
    UrlCapaLivroRequisicao = @UrlCapaLivroRequisicao, 
    UrlIconLivroRequisicao = @UrlIconLivroRequisicao, 
    UrlBannerLivroRequisicao = @UrlBannerLivroRequisicao, 
    UrlPDFLivroRequisicao = @UrlPDFLivroRequisicao
WHERE 
    IdLivroRequisicao = @IdLivroRequisicao;

-- DELETE (Remoção de Livro Pendente)
DELETE FROM LivroRequisicao 
WHERE IdLivroRequisicao = @IdLivroRequisicao;

/* Funções extras */

-- SEARCH BY ID (Buscar livro pendente pelo ID)
SELECT 
    LR.IdLivroRequisicao, 
    LR.TituloLivroRequisicao, 
    G.DescricaoGenero AS Genero, 
    LR.SinopseLivroRequisicao, 
    LR.AutorLivroRequisicao, 
    LR.DataPublicacaoLivroRequisicao, 
    LR.UrlCapaLivroRequisicao, 
    LR.UrlIconLivroRequisicao, 
    LR.UrlBannerLivroRequisicao, 
    LR.UrlPDFLivroRequisicao
FROM 
    LivroRequisicao LR
INNER JOIN 
    Genero G ON LR.GeneroLivroRequisicao = G.IdGenero
WHERE 
    LR.IdLivroRequisicao = @IdLivroRequisicao;

-- SEARCH BY TITLE (Buscar livros pendentes pelo título)
SELECT 
    LR.IdLivroRequisicao, 
    LR.TituloLivroRequisicao, 
    G.DescricaoGenero AS Genero, 
    LR.SinopseLivroRequisicao, 
    LR.AutorLivroRequisicao, 
    LR.DataPublicacaoLivroRequisicao, 
    LR.UrlCapaLivroRequisicao, 
    LR.UrlIconLivroRequisicao, 
    LR.UrlBannerLivroRequisicao, 
    LR.UrlPDFLivroRequisicao
FROM 
    LivroRequisicao LR
INNER JOIN 
    Genero G ON LR.GeneroLivroRequisicao = G.IdGenero
WHERE 
    LR.TituloLivroRequisicao LIKE '%' + @TituloLivroRequisicao + '%';

-- SEARCH BY AUTHOR (Buscar livros pendentes por autor)
SELECT 
    LR.IdLivroRequisicao, 
    LR.TituloLivroRequisicao, 
    G.DescricaoGenero AS Genero, 
    LR.SinopseLivroRequisicao, 
    LR.AutorLivroRequisicao, 
    LR.DataPublicacaoLivroRequisicao, 
    LR.UrlCapaLivroRequisicao, 
    LR.UrlIconLivroRequisicao, 
    LR.UrlBannerLivroRequisicao, 
    LR.UrlPDFLivroRequisicao
FROM 
    LivroRequisicao LR
INNER JOIN 
    Genero G ON LR.GeneroLivroRequisicao = G.IdGenero
WHERE 
    LR.AutorLivroRequisicao LIKE '%' + @AutorLivroRequisicao + '%';

-- APPROVE BOOK (Aprovar um livro pendente e movê-lo para a tabela de livros)
INSERT INTO Livro (
    TituloLivro, 
    GeneroLivro, 
    SinopseLivro, 
    AutorLivro, 
    DataPublicacaoLivro, 
    UrlCapaLivro, 
    UrlIconLivro, 
    UrlBannerLivro, 
    UrlPDFLivro
)
SELECT 
    TituloLivroRequisicao, 
    GeneroLivroRequisicao, 
    SinopseLivroRequisicao, 
    AutorLivroRequisicao, 
    DataPublicacaoLivroRequisicao, 
    UrlCapaLivroRequisicao, 
    UrlIconLivroRequisicao, 
    UrlBannerLivroRequisicao, 
    UrlPDFLivroRequisicao
FROM 
    LivroRequisicao
WHERE 
    IdLivroRequisicao = @IdLivroRequisicao;

-- Remover da tabela LivroRequisicao
DELETE FROM LivroRequisicao 
WHERE IdLivroRequisicao = @IdLivroRequisicao;

-----------------------------------------------------------------------------------------------------------------------