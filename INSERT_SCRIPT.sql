USE GESTAO_HOTEL
GO

/*USE [master]
GO
ALTER DATABASE [GESTAO_HOTEL] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
USE [master]
GO
DROP DATABASE [GESTAO_HOTEL]
GO*/

--COMANDOS PARA INSER��O

--SEXO  --1�
INSERT INTO SEXO VALUES(1,'Feminino')
INSERT INTO SEXO VALUES(2,'Masculino')

-- CLIENTE  --7�
INSERT INTO CLIENTE VALUES('Marcos Antonio','19854267923',1,'1995-06-17','marcoant@hotmail.com','99981506471','Rua dos Jumentos')
INSERT INTO CLIENTE VALUES('Larissa Silva','95586257412',2,'1994-12-19','larissasilva@gmail.com','82963145789','Aveniva Presidente Dutra')
INSERT INTO CLIENTE VALUES('Larnivaldo Souza','48215974536',1,'1999-07-01','lsouza_23@hotmail.com','94982653415','Rua dos Jatob�s')

-- DIARIA  --12�
INSERT INTO DIARIA VALUES(500.30,'2022-08-09',1,1,2,'2022-08-17')
INSERT INTO DIARIA VALUES(1500.30,'2022-09-02',2,1,1,'2022-09-26')
INSERT INTO DIARIA VALUES(600.30,'2022-12-15',1,2,1,'2023-01-02')
INSERT INTO DIARIA VALUES(600.30,'2022-12-15',1,2,1,'2023-01-02')
INSERT INTO DIARIA VALUES(5000.82,'2022-10-13',3,2,2,'2022-11-13')

-- QUARTO  --11�
INSERT INTO QUARTO VALUES(1,1,'Quarto de solteiro',90.00,1)

--DIARIA_QUARTO  --13�
INSERT INTO DIARIA_QUARTO VALUES(1,1)

-- STATUS  --8�
INSERT INTO STATUS VALUES(1,'Vago')
INSERT INTO STATUS VALUES(2,'Ocupado')

-- CLASSE  --9�
INSERT INTO CLASSE VALUES(1,'Standard')
INSERT INTO CLASSE VALUES(2,'Master')
INSERT INTO CLASSE VALUES(3,'Deluxe')

--PAGAMENTO  --10�
INSERT INTO PAGAMENTO VALUES('Cart�o de Cr�dito')
INSERT INTO PAGAMENTO VALUES('� vista (Boleto)')
INSERT INTO PAGAMENTO VALUES('PIX')

--FUNCIONARIO  --2�
INSERT INTO FUNCIONARIO VALUES('08432576522','Administrador','admin@gmail.com','63984581203','Rua A1, 010','admin','admin',1,1,GETDATE())
INSERT INTO FUNCIONARIO VALUES('94587124563','Laila Silva','lailassantos@gmail.com','63991587425','Avenida dos Cedros, 45','Laila Santos','wads135',2,1,GETDATE())

--GRUPO_FUNCIONARIO  --3�
INSERT INTO GRUPO_FUNCIONARIO(NOME_GRUPO)VALUES('Administrador')
INSERT INTO GRUPO_FUNCIONARIO(NOME_GRUPO)VALUES('Gerente')
INSERT INTO GRUPO_FUNCIONARIO(NOME_GRUPO)VALUES('Recepsionista')
INSERT INTO GRUPO_FUNCIONARIO(NOME_GRUPO)VALUES('Gorvenanta')

--PERMISSAO  --4�
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Visualizar funcion�rio') --1
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Cadastrar funcion�rio') --2
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Alterar funcion�rio') --3
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Excluir funcion�rio') --4
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Visualizar grupo de funcion�rio') --5
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Cadastrar grupo de funcion�rio') --6
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Alterar grupo de funcion�rio') --7
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Excluir grupo de funcion�rio') --8
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Visualizar cliente') --9
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Cadastrar cliente') --10
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Alterar cliente') --11
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Excluir cliente') --12
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Visualizar di�ria') --13
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Cadastrar di�ria') --14
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Alterar di�ria') --15
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Excluir di�ria') --16
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Visualizar quarto') --17
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Cadastrar quarto') --18
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Alterar quarto') --19
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Excluir quarto') --20
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Adicionar permiss�o a um grupo de funcion�rio') --21
INSERT INTO PERMISSAO(DESCRICAO)VALUES('Adicionar grupo de funcion�rio a um funcion�rio') --22

--PERMISSAO_GRUPO_FUNCIONARIO  --5�
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,1)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,2)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,3)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,4)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,5)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,6)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,7)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,8)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,9)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,10)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,11)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,12)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,13)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,14)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,15)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,16)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,17)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,18)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,19)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,20)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,21)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(1,22)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,1)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,2)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,3)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,4)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,5)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,6)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,7)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,8)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,9)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,10)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,11)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,12)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,13)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,14)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,15)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,16)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,17)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,18)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,19)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,20)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,21)
INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO,ID_PERMISSAO)VALUES(2,22)

--FUNCIONARIO_GRUPO_FUNCIONARIO  --6�
INSERT INTO FUNCIONARIO_GRUPO_FUNCIONARIO(ID_FUNCIONARIO,ID_GRUPO_FUNCIONARIO)VALUES(1,1)
INSERT INTO FUNCIONARIO_GRUPO_FUNCIONARIO(ID_FUNCIONARIO,ID_GRUPO_FUNCIONARIO)VALUES(2,2)


-----------------------------------------------------------------------------------------------------------------

--COMANDOS PARA SELECT
SELECT * FROM FUNCIONARIO
SELECT * FROM GRUPO_FUNCIONARIO
SELECT * FROM FUNCIONARIO_GRUPO_FUNCIONARIO
SELECT * FROM CLIENTE
SELECT * FROM SEXO
SELECT * FROM DIARIA
SELECT * FROM DIARIA_QUARTO
SELECT * FROM QUARTO
SELECT * FROM CLASSE
SELECT * FROM STATUS

SELECT * FROM PERMISSAO
SELECT * FROM PERMISSAO_GRUPO_FUNCIONARIO

-----------------------------------------------------------------------------------------------------------------

-- CODIGO INNER JOIN DE BUSCAR POR NOME 
SELECT D.ID, C.NOME, C.CPF, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE, D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
FROM DIARIA D
INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
WHERE C.NOME LIKE '%Lar%'

-- CODIGO INNER JOIN DE BUSCAR POR CPF 
SELECT D.ID, C.NOME, C.CPF, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE, D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
FROM DIARIA D
INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
WHERE C.CPF LIKE '19854267923'

--CODIGO INNER JOIN BUSCAR POR NOMEUSUARIO EM FUNCIONARIO
SELECT F.ID, F.NOME, F.NOME_USUARIO, GF.NOME_GRUPO, F.EMAIL ,F.SENHA ,F.CPF, F.ATIVO, F.DATA_NASCIMENTO,F.ENDERECO, F.CELULAR, F.ID_SEXO 
FROM FUNCIONARIO F
INNER JOIN FUNCIONARIO_GRUPO_FUNCIONARIO FGF ON F.ID = FGF.ID_FUNCIONARIO
INNER JOIN GRUPO_FUNCIONARIO GF ON FGF.ID_GRUPO_FUNCIONARIO = GF.ID
WHERE NOME_USUARIO LIKE 'Laila Santos'