CREATE DATABASE ProductsToСategoriesTask;

USE ProductsToСategoriesTask;

CREATE TABLE [Products]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(1) NULL
)

CREATE TABLE [Сategories]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(1) NULL
)


--Create Many-to-Many Relationships--
CREATE TABLE [ProductsToСategories]
(
	[ProductId] INT NOT NULL,
	[СategoryId] INT NOT NULL,
	PRIMARY KEY ([ProductId], [СategoryId]),
	FOREIGN KEY ([ProductId]) REFERENCES [Products](Id),
	FOREIGN KEY ([СategoryId]) REFERENCES [Сategories](Id)
)

SELECT 
	p.[Name] AS [ProductName], 
	C.[Name] AS СategoryName 
FROM [Products] p
	LEFT JOIN [ProductsToСategories] PtC ON p.[Id] = PtC.[ProductId]
	INNER JOIN [Сategories] C ON c.[Id] = PtC.[СategoryId]
