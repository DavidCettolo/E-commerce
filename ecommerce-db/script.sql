USE master
GO
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'ecommerce')
BEGIN
  CREATE DATABASE ecommerce;
END;
GO
USE ecommerce;
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Items')
BEGIN
  CREATE TABLE Items (
    C8 varchar(8) NOT NULL PRIMARY KEY,
    Name varchar(100), 
    Description varchar(max),
    Quantity int, 
  );
  INSERT INTO Items
  VALUES 
  (11111111,'Coca-cola','1 liter bottle',10),
  (22222222,'Fanta','1 liter bottle',15),
  (33333333,'Pepsi','1 liter bottle',7),
  (44444444,'Sprite','1 liter bottle',0),
  (55555555,'Getorade','1 liter bottle',2)
END;
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cart')
BEGIN
  CREATE TABLE Cart (
    OrderId int IDENTITY(1,1) PRIMARY KEY,
    UserId int NOT NULL,
    C8 varchar(8) NOT NULL,
    Quantity int NOT NULL,
    Date varchar(50) NOT NULL
  )
END;
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
  CREATE TABLE Users (
    UserId int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(100) NOT NULL
  );
  INSERT INTO Users
  VALUES ('Napoleone')
END;
GO
