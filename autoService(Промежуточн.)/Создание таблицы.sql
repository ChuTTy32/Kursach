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

INSERT INTO ServiceStation(ServiceStationID, OrganizationName, Inn, Country, Address, PhoneSTO, PhonePlusSTO, BankIDSTO, AccountSTO)
VALUES
(1, N'Service Station "HELLO KITTY"', N'123456789012', N'Russia', N'City1, Street1, House1', N'123-456', '789-012', 1, '123456'),
(2, N'Service Station "HELLO KITTY"', N'123456789012', N'Russia', N'City1, Street2, House2', N'123-456', '789-012', 1, '123456'),
(3, N'Service Station "HELLO KITTY"', N'123456789012', N'Russia', N'City1, Street3, House3', N'123-456', '789-012', 1, '123456'),
(4, N'Service Station "HELLO KITTY"', N'123456789012', N'Russia', N'City2, Street4, House4', N'123-456', '789-012', 1, '123456'),
(5, N'Service Station "HELLO KITTY"', N'123456789012', N'Russia', N'City2, Street5, House5', N'123-456', '789-012', 1, '123456');


INSERT INTO Client(ClientID, Client, PhoneClient, AddressClient, AccountClient, BankClient, MarkaAvto, DateStart, DiscountCard)
VALUES
(1, N'Client 1', '111-222', N'City1, Street1, House1', 1, N'Bank 1', N'Car1', '01-01-2024', 1),
(2, N'Client 2', '222-333', N'City2, Street2, House2', 2, N'Bank 2', N'Car2', '02-02-2024', 2),
(3, N'Client 3', '333-444', N'City3, Street3, House3', 3, N'Bank 3', N'Car3', '03-03-2024', 3),
(4, N'Client 4', '444-555', N'City4, Street4, House4', 4, N'Bank 4', N'Car4', '04-04-2024', 4),
(5, N'Client 5', '555-666', N'City5, Street5, House5', 5, N'Bank 5', N'Car5', '05-05-2024', 5),
(6, N'Client 6', '666-777', N'City6, Street6, House6', 6, N'Bank 6', N'Car6', '06-06-2024', 6),
(7, N'Client 7', '777-888', N'City7, Street7, House7', 7, N'Bank 7', N'Car7', '07-07-2024', 7),
(8, N'Client 8', '888-999', N'City8, Street8, House8', 8, N'Bank 8', N'Car8', '08-08-2024', 8),
(9, N'Client 9', '999-000', N'City9, Street9, House9', 9, N'Bank 9', N'Car9', '09-09-2024', 9),
(10, N'Client 10', N'000-111', N'City10, Street10, House10', 10, N'Bank 10', N'Car10', '10-10-2024', 10);


INSERT INTO Goods (GoodsID, GoodsName, Vieww, RepairPrice, Manufacturer, Unit, Sensors, Countt)
VALUES
(1, N'Item1', N'Maintenance1', 1500, N'Manufacturer 1', N'pcs', N'Sensor1', 10),
(2, N'Item2', N'Maintenance2', 1300, N'Manufacturer 2', N'pcs', N'Sensor2', 80),
(3, N'Item3', N'Maintenance3', 1180, N'Manufacturer 3', N'pcs', N'Sensor3', 50),
(4, N'Item4', N'Maintenance4', 1240, N'Manufacturer 4', N'pcs', N'Sensor4', 12),
(5, N'Item5', N'Maintenance5', 1150, N'Manufacturer 5', N'pcs', N'Sensor5', 30),
(6, N'Item6', N'Maintenance6', 1120, N'Manufacturer 6', N'pcs', N'Sensor6', 60),
(7, N'Item7', N'Maintenance7', 1210, N'Manufacturer 7', N'pcs', N'Sensor7', 90),
(8, N'Item8', N'Maintenance8', 1180, N'Manufacturer 8', N'l', N'Sensor8', 15),
(9, N'Item9', N'Maintenance9', 1365, N'Manufacturer 9', N'l', N'Sensor9', 20),
(10, N'Item10', N'Maintenance10', 1240, N'Manufacturer 10', N'l', N'Sensor10', 40);


INSERT INTO Purchase (PurchaseID, ClientID, GoodsID, Volume, DateVolume, Vieww, RepairPrice)
VALUES
(1, 1, 1, 6, '2024-01-15', N'Maintenance1', 1500),
(2, 2, 2, 5, '2024-02-20', N'Maintenance2', 1300),
(3, 3, 3, 4, '2024-03-25', N'Maintenance3', 1180),
(4, 4, 4, 2, '2024-04-30', N'Maintenance4', 1240),
(5, 5, 5, 7, '2024-05-15', N'Maintenance5', 1150),
(6, 6, 6, 8, '2024-06-20', N'Maintenance6', 1120),
(7, 7, 7, 3, '2024-07-25', N'Maintenance7', 1210),
(8, 8, 8, 1, '2024-08-30', N'Maintenance8', 1180),
(9, 9, 9, 10, '2024-09-15', N'Maintenance9', 1365),
(10, 10, 10, 9, '2024-10-20', N'Maintenance10', 1240);

INSERT INTO register(login_user, password_user) 
VALUES (N'admin', N'admin');
