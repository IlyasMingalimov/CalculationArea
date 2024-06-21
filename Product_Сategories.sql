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
	product.[Name] AS [ProductName], 
	category.[Name] AS [СategoryName]
FROM [ProductsToСategories] productToСategory
	RIGHT JOIN [Products] product ON product.[Id] = productToСategory.[ProductId]
	LEFT JOIN [Сategories] category ON category.[Id] = productToСategory.[СategoryId]
