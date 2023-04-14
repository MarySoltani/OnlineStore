--drop database OnlineStore

CREATE TABLE Users
(
	Id INT NOT NULL,
	FName VARCHAR(50) NULL,
	LName VARCHAR(50) NULL,
	UseraName VARCHAR(50),
	Password VARCHAR(20),
	Mobile VARCHAR(11) NULL,
	Email VARCHAR(50) NULL,
	Address VARCHAR(200),
	Admin TINYINT NOT NULL DEFAULT 0,
	RegisteredAt DATETIME NOT NULL,
	PRIMARY KEY (Id)
)

CREATE TABLE Orders
(
	Id INT NOT NULL,
	UserId INT NULL,
	Status SMALLINT NOT NULL,
	SubTotal FLOAT NOT NULL, --قیمت یه آیتم خاص
	ItemDiscount FLOAT NOT NULL DEFAULT 0, --تخفیف یک آیتم خاص
	Shipping FLOAT NOT NULL DEFAULT 0, --هزینه ارسال
	Total FLOAT NOT NULL DEFAULT 0, --قیمت کل با مالیات و هزینه ارسال بدون تخفیف
	Discount FLOAT NOT NULL DEFAULT 0, --تخفیف روی کل فاکتور
	GrandTotal FLOAT NOT NULL DEFAULT 0, --مبلغ قابل پرداخت
	Quantity INT NOT NULL,
	CreateDate VARCHAR(10) NOT NULL,
	Description NVARCHAR(300) NULL DEFAULT NULL,
	PRIMARY KEY (Id),
	INDEX idx_Orders_Users (UserId ASC),
	CONSTRAINT fk_Orders_Users
	FOREIGN KEY (UserId)
	REFERENCES Users (Id)
)

CREATE TABLE Categories
(
	Id INT NOT NULL,
	ParentId INT NULL,
	Title VARCHAR(75) NOT NULL,
	Description VARCHAR(400) NULL DEFAULT NULL,
	PRIMARY KEY (Id)
)

--ALTER TABLE Categories 
--ADD INDEX idx_Categories_Parent (ParentId ASC);
--ALTER TABLE Categories 
--ADD CONSTRAINT fk_Categories_Parent
--	FOREIGN KEY (ParentId)
--	REFERENCES Categories (Id);

CREATE TABLE Products
(
	Id INT NOT NULL,
	CategoryId INT,
	UserId INT NOT NULL,
	Name VARCHAR(75) NOT NULL,
	Description VARCHAR(200) NULL,
	Unit VARCHAR(100) NOT NULL,  --واحد نگهداری مثل کارتن، بسته و ...
	Price FLOAT NOT NULL,
	Discount FLOAT NOT NULL DEFAULT 0,
	Quantity SMALLINT NOT NULL,
	CreateDate VARCHAR(10) NOT NULL,
	PRIMARY KEY (Id)
)

CREATE TABLE OrderItem
(
	Id INT NOT NULL,
	ProductId INT NOT NULL,
	OrderId INT NOT NULL,
	Unit SMALLINT NOT NULL, --واحد نگهداری مثل کارتن، بسته و ...
	Price FLOAT NOT NULL DEFAULT 0,
	Discount FLOAT NOT NULL DEFAULT 0,
	Quantity SMALLINT NOT NULL DEFAULT 0,
	CreateDate VARCHAR(10) NOT NULL,
	Description nvarchar NULL DEFAULT NULL,
	PRIMARY KEY (Id),
	INDEX idx_OrderItem_Products (productId ASC),
	CONSTRAINT fk_OrderItem_Products
		FOREIGN KEY (ProductId)
		REFERENCES Products (Id)
)

--ALTER TABLE Orders
--ADD INDEX idx_OrderItem_Order (OrderId ASC);
--ALTER TABLE OrderItem 
--ADD CONSTRAINT fk_OrderItem_Order
--	FOREIGN KEY (OrderId)
--	REFERENCES Orders (Id);

--create table Basket
--(
--	ProductId INT,
--	Amount INT,
--	Price DECIMAL(38, 10)
--)