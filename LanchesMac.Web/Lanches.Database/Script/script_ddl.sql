CREATE DATABASE [LanchesDataBase]

USE LanchesDataBase

CREATE TABLE [dbo].[Categorias](
	[CategoriaId] [int] PRIMARY KEY IDENTITY NOT NULL,
	[CategoriaNome] [nvarchar](100) NOT NULL,
	[Descricao] [nvarchar](200) NOT NULL,
);

CREATE TABLE [dbo].[Lanches](
	[LancheId] [int] PRIMARY KEY IDENTITY NOT NULL,
	[Nome] [nvarchar](80) NOT NULL,
	[DescricaoCurta] [nvarchar](200) NOT NULL,
	[DescricaoDetalhada] [nvarchar](200) NOT NULL,
	[Preco] [decimal](10,2) NOT NULL,
	[ImagemUrl] [nvarchar](200) NULL,
	[ImagemThumbnailUrl] [nvarchar](200) NULL,
	[IsLanchePreferido] [bit] NOT NULL,
	[EmEstoque] [bit] NOT NULL,
	[CategoriaId] [int] NOT NULL,
	CONSTRAINT FK_Categoria_Lanche FOREIGN KEY (CategoriaId) REFERENCES [dbo].[Categorias](CategoriaId)
);

CREATE TABLE [dbo].[CarrinhoCompraItens](
	[CarrinhoCompraItemId] [int] PRIMARY KEY IDENTITY NOT NULL,
	[LancheId] [int] NULL,
	[Quantidade] [int] NOT NULL,
	[CarrinhoCompraId] [UNIQUEIDENTIFIER] NULL,
	CONSTRAINT FK_Lanche_CarrinhoCompraItem FOREIGN KEY (LancheId) REFERENCES [dbo].[Lanches](LancheId)
);