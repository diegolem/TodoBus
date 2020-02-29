--BDD para el proyecto de Analisis y Dise�o de Sistemas
CREATE DATABASE TodoBus;

use TodoBus;

CREATE TABLE Users(
	UserId int NOT NULL,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	Email varchar(50) NOT NULL,
	Age int,
	Password varchar(max),
	PRIMARY KEY(UserId)
);

CREATE TABLE Clients(
	ClientId int NOT NULL,
	ClientName varchar(50) NOT NULL,
	ContactName varchar(50) NOT NULL,
	Phone varchar(50) NOT NULL,
	AlternativePhone varchar(50),
	Adress varchar(255),
	Email varchar(50) NOT NULL,
	AlternativeEmail varchar(50),
	UnitsTotal int NOT NULL,
	UserId int NOT NULL,
	PRIMARY KEY(ClientId),
	FOREIGN KEY(UserId) REFERENCES Users(UserId)
);

CREATE TABLE Brands(
	BrandId int NOT NULL,
	Name varchar(50) NOT NULL,
	Description varchar(max),

	PRIMARY KEY(BrandId)
);

CREATE TABLE SpareTypes(
	SparePartsTypesID int NOT NULL,
	Name varchar(150) NOT NULL,
	Code varchar(25) NOT NULL,
	Description varchar(255),

	PRIMARY KEY(SparePartsTypesID)
);


CREATE TABLE Spare(
	SparePartsId varchar(50) NOT NULL,
	Name varchar(255) NOT NULL,
	SpareImage varchar(255) NOT NULL,
	SpareTypeId int NOT NULL,

	PRIMARY KEY(SparePartsId),
	FOREIGN KEY(SpareTypeId) REFERENCES SpareTypes(SparePartsTypesID),
);

CREATE TABLE Units(
	UnitId int NOT NULL,
	BrandId int NOT NULL,
	ClientId int NOT NULL,
	UnitsDescription varchar(255),
	MeasureDescription varchar(255),
	Total int NOT NULL,
	PRIMARY KEY(UnitId),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
	FOREIGN KEY (ClientId) REFERENCES Clients(ClientId)
);

CREATE TABLE Units_Spare(
	UnitsSpareId int NOT NULL,
	UnitId int NOT NULL,
	SpareId varchar(50) NOT NULL

	PRIMARY KEY(UnitsSpareId),
	FOREIGN KEY(UnitId) REFERENCES Units(UnitId),
	FOREIGN KEY(SpareId) REFERENCES Spare(SparePartsId)
);

ALTER TABLE SpareTypes
ADD CONSTRAINT unique_code
UNIQUE(Code)