CREATE DATABASE RetailDB;
GO

USE RetailDB;
GO

CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Categoria VARCHAR(50),
    Precio DECIMAL(10,2),
    Stock INT
);