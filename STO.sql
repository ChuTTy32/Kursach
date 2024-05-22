create database STO
use STO


CREATE TABLE ServiceStation (
ServiceStationID INT PRIMARY KEY,
OrganizationName VARCHAR(255),
Inn VARCHAR(20),
Country VARCHAR (50),
Address VARCHAR(255),
PhoneSTO VARCHAR(20),
PhonePlusSTO VARCHAR(20),
BankSTO VARCHAR(100),
BankIDSTO INT,
AccountSTO VARCHAR(30)
);

CREATE TABLE Goods (
GoodsID INT PRIMARY KEY,
GoodsName VARCHAR(255),
Vieww VARCHAR(255),
RepairPrice INT,
Sensors VARCHAR(255),
Manufacturer VARCHAR(255),
Unit VARCHAR(50),
CostUnit INT,
Countt INT
);

CREATE TABLE Client (
ClientID INT PRIMARY KEY,
Client VARCHAR(255),
PhoneClient VARCHAR(20),
AddressClient VARCHAR(255),
BankClient VARCHAR(100),
AccountClient VARCHAR(30),
MarkaAvto VARCHAR(50),
DateStart DATE,
DiscountCard VARCHAR(30)
);

CREATE TABLE avto (
    avtoId INT PRIMARY KEY,
	Client VARCHAR(255),
    avtoName VARCHAR(50),
    avtoType VARCHAR(50),
    avtoNumber VARCHAR(15),
    serviceDueDate DATE
);


CREATE TABLE Purchase (
PurchaseID INT PRIMARY KEY,
ClientID INT,
GoodsID INT,
Volume INT,
DateVolume DATE,
RepairPrice INT,
Vieww VARCHAR(255),
FOREIGN KEY (ClientID) REFERENCES Client(ClientID),
FOREIGN KEY (GoodsID) REFERENCES Goods(GoodsID)
);

CREATE TABLE register(
id_user int identity(1, 1) not null,
login_user varchar(50) not null,
password_user varchar (50) not null
);

INSERT INTO ServiceStation (ServiceStationID, OrganizationName, Inn, Country, Address, PhoneSTO, PhonePlusSTO, BankIDSTO, AccountSTO)
VALUES
(1, 'СТО «HELLO KITTY”', '123456789012', 'Россия', 'Город1, Улица1, Дом1', '123-456', '789-012', 1, '123456'),
(2, 'СТО «HELLO KITTY”', '123456789012', 'Россия', 'Город1, Улица2, Дом2', '123-456', '789-012', 1, '123456'),
(3, 'СТО «HELLO KITTY”', '123456789012', 'Россия', 'Город1, Улица3, Дом3', '123-456', '789-012', 1, '123456'),
(4, 'СТО «HELLO KITTY”', '123456789012', 'Россия', 'Город2, Улица4, Дом4', '123-456', '789-012', 1, '123456'),
(5, 'СТО «HELLO KITTY”', '123456789012', 'Россия', 'Город2, Улица5, Дом5', '123-456', '789-012', 1, '123456');


INSERT INTO Client(ClientID, Client, PhoneClient, AddressClient, AccountClient, BankClient, MarkaAvto, DateStart, DiscountCard)
VALUES
(1, 'Клиент 1', '111-222', 'Город1, Улица1, Дом1', 1, 'Банк 1', 'Avto1', '01-01-2024', 1),
(2, 'Клиент 2', '222-333', 'Город2, Улица2, Дом2', 2, 'Банк 2', 'Avto2', '02-02-2024', 2),
(3, 'Клиент 3', '333-444', 'Город3, Улица3, Дом3', 3, 'Банк 3', 'Avto3', '03-03-2024', 3),
(4, 'Клиент 4', '444-555', 'Город4, Улица4, Дом4', 4, 'Банк 4', 'Avto4', '04-04-2024', 4),
(5, 'Клиент 5', '555-666', 'Город5, Улица5, Дом5', 5, 'Банк 5', 'Avto5', '05-05-2024', 5),
(6, 'Клиент 6', '666-777', 'Город6, Улица6, Дом6', 6, 'Банк 6', 'Avto6', '06-06-2024', 6),
(7, 'Клиент 7', '777-888', 'Город7, Улица7, Дом7', 7, 'Банк 7', 'Avto7', '07-07-2024', 7),
(8, 'Клиент 8', '888-999', 'Город8, Улица8, Дом8', 8, 'Банк 8', 'Avto8', '08-08-2024', 8),
(9, 'Клиент 9', '999-000', 'Город9, Улица9, Дом9', 9, 'Банк 9', 'Avto9', '09-09-2024', 9),
(10, 'Клиент 10', '000-111', 'Город10, Улица10, Дом10', 10, 'Банк 10', 'Avto10', '10-10-2024', 10);

INSERT INTO avto(avtoId, Client, avtoName, avtoType, avtoNumber, serviceDueDate)
VALUES
(1, 'Клиент 1', 'avtoName1', 'vehicleType1', 'AAA111', '2024-05-11'),
(2, 'Клиент 2', 'avtoName2', 'vehicleType2', 'AAA222', '2024-05-12'),
(3, 'Клиент 3', 'avtoName3', 'vehicleType3', 'AAA333', '2024-05-13'),
(4, 'Клиент 4', 'avtoName4', 'vehicleType4', 'AAA444', '2024-05-14'),
(5, 'Клиент 5', 'avtoName5', 'vehicleType5', 'AAA555', '2024-05-15'),
(6, 'Клиент 6', 'avtoName6', 'vehicleType6', 'AAA666', '2024-05-16'),
(7, 'Клиент 7', 'avtoName7', 'vehicleType7', 'AAA777', '2024-05-17'),
(8, 'Клиент 8', 'avtoName8', 'vehicleType8', 'AAA888', '2024-05-18'),
(9, 'Клиент 9', 'avtoName9', 'vehicleType9', 'AAA999', '2024-05-19'),
(10, 'Клиент 10', 'avtoName10', 'vehicleType10', 'AAA000', '2024-05-10');


INSERT INTO Goods (GoodsID, GoodsName, Vieww, RepairPrice, Manufacturer, Unit, Sensors, Countt)
VALUES
(1, 'товар1','техобслуживание1', 1500, 'Производитель 1', 'шт', 'датчик1', 10),
(2, 'товар2','техобслуживание2', 1300, 'Производитель 2', 'шт', 'датчик2', 80),
(3, 'товар3','техобслуживание3', 1180, 'Производитель 3', 'шт', 'датчик3', 50),
(4, 'товар4','техобслуживание4', 1240, 'Производитель 4', 'шт', 'датчик4', 12),
(5, 'товар5','техобслуживание5', 1150, 'Производитель 5', 'шт', 'датчик5', 30),
(6, 'товар6','техобслуживание6', 1120, 'Производитель 6', 'шт', 'датчик6', 60),
(7, 'товар7','техобслуживание7', 1210, 'Производитель 7', 'шт', 'датчик7', 90),
(8, 'товар8','техобслуживание8', 1180, 'Производитель 8', 'л', 'датчик8', 15),
(9, 'товар9','техобслуживание9', 1365, 'Производитель 9', 'л', 'датчик9', 20),
(10, 'товар10','техобслуживание10', 1240, 'Производитель 10', 'л', 'датчик10', 40);


INSERT INTO Purchase (PurchaseID, ClientID, GoodsID, Volume, DateVolume, Vieww, RepairPrice)
VALUES
(1, 1, 1, 6, '2024-01-15', 'техобслуживание1', 1500),
(2, 2, 2, 5, '2024-02-20', 'техобслуживание2', 1300),
(3, 3, 3, 4, '2024-03-25', 'техобслуживание3', 1180),
(4, 4, 4, 2, '2024-04-30', 'техобслуживание4', 1240),
(5, 5, 5, 7, '2024-05-15', 'техобслуживание5', 1150),
(6, 6, 6, 8, '2024-06-20', 'техобслуживание6', 1120),
(7, 7, 7, 3, '2024-07-25', 'техобслуживание7', 1210),
(8, 8, 8, 1, '2024-08-30', 'техобслуживание8', 1180),
(9, 9, 9, 10, '2024-09-15', 'техобслуживание9', 1365),
(10, 10, 10, 9, '2024-10-20', 'техобслуживание10', 1240);

INSERT INTO register(login_user, password_user) 
values ('admin', 'admin')