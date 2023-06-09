USE [LanchesDataBase]
GO

INSERT INTO [dbo].[Categorias] ([CategoriaNome],[Descricao])
     VALUES('Normal','Lanche feito com ingredientes normais'),
		   ('Natural','Lanche feito com ingredientes integrais e naturais');

INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) 
	VALUES(1,'P�o, hamb�rger, ovo, presunto, queijo e batata palha','Delicioso p�o de hamb�rger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0 ,'Cheese Salada', 12.50),
		  (1,'P�o, presunto, mussarela e tomate','Delicioso p�o franc�s quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.',1,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',0,'Misto Quente', 8.00),
		  (1,'P�o, hamb�rger, presunto, mussarela e batalha palha','P�o de hamb�rger especial com hamb�rger de nossa prepara��o e presunto e mussarela; acompanha batata palha.',1,'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',0,'Cheese Burger', 11.00),
          (2,'P�o Integral, queijo branco, peito de peru, cenoura, alface, iogurte','P�o integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural.',1,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',1,'Lanche Natural Peito Peru', 15.00);

GO


