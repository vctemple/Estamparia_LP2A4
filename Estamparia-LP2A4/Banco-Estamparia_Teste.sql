-- BANCO DE DADOS ESTAMPARIA -beta-

CREATE DATABASE Estamparia_teste
GO

USE Estamparia_teste
GO

CREATE TABLE Usuarios (
ID INT IDENTITY PRIMARY KEY,
Nome VARCHAR(80),
Email VARCHAR(80),
Telefone VARCHAR(20),
CPF VARCHAR(20),
Senha VARCHAR(250),
Perfil VARCHAR(10)
)
GO

CREATE TABLE Produtos (
ID_Prod INT IDENTITY PRIMARY KEY,
Marca VARCHAR (50),
Estampa VARCHAR (50),
Preco DECIMAL (5, 2),
Cor VARCHAR(10),
Tamanho VARCHAR(50),
Quantidade INT,
Imagem1 VARCHAR(200),
Imagem2 VARCHAR(200)
)
GO

CREATE TABLE Carrinho (
ID_Carr INT PRIMARY KEY IDENTITY,
FK_ID_Fat INT FOREIGN KEY REFERENCES Faturas(ID_Fat),
FK_ID_Prod INT FOREIGN KEY REFERENCES Produtos(ID_Prod),
QtdProd_Carr INT
)
GO

CREATE TABLE Faturas (
ID_Fat INT IDENTITY PRIMARY KEY,
FK_ID_User INT FOREIGN KEY REFERENCES Usuarios(ID),
Data_Fat DATE,
Total_Fat DECIMAL (5, 2),
Status_FAt VARCHAR(20)
)
GO