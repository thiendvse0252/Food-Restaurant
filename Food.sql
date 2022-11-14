create database FoodRestaurant

create table FoodTable
(   Id int identity primary key,
	Name nvarchar(100) not null default N'Unnamed',
	Status nvarchar(100) not null default N'Empty'     --empty/full
)
go

create table Account
(   
	DisplayName nvarchar(100) not null default N'Kathy',
	Username nvarchar(100) primary key, 
	Password nvarchar(1000) not null default 0,
	Type int not null default 0
)
go

Create table FoodCategory
(   Id int identity primary key,
	Name nvarchar(100) not null default N'Unnamed',	
)
go

Create table Food
(   FoodId int identity primary key,
	FoodName nvarchar(100) not null default N'Unnamed',
	IdCategory int not null,
	Price float not null default 0

	foreign key (IdCategory) references dbo.FoodCategory(Id)
)
go

Create table Bill
(   BillId int identity primary key,
	DateCheckIn Date not null default GETDATE(),
	DateCheckOut Date,
	IdTable int not null,
	Status int not null default 0

	Foreign key (IdTable) references dbo.FoodTable (Id)
)
go

Create table BillDetail
(   BillId int identity primary key,
	IdBill int not null,
	IdFood int not null,
	Count int not null default 0,
	
	foreign key (IdBill) references dbo.Bill(BillId),
	foreign key (IdFood) references dbo.Food(FoodId)
)
go

insert into dbo.Account
(Username, DisplayName, Password, Type)
values (N'admin', N'Van Thien', N'1', 1)
go

insert into dbo.Account
(Username, DisplayName, Password, Type)
values (N'staff', N'staff', N'1', 0)
go


declare @i int = 0

--add table
while @i <=10
begin
	insert dbo.FoodTable (Name) values (N'Table ' + CAST(@i as nvarchar(100)))
	set @i = @i +1;
end
go

create procedure USP_GetTableList
AS select * from dbo.FoodTable
GO

--add category
insert dbo.FoodCategory (Name) values (N'Seafood')
insert dbo.FoodCategory (Name) values (N'Bread and cereal')
insert dbo.FoodCategory (Name) values (N'Fast Food')
insert dbo.FoodCategory (Name) values (N'Salad')
insert dbo.FoodCategory (Name) values (N'Dessert')
go

--add food
insert dbo.Food(FoodName, IdCategory, Price) values (N'Ice-cream', 5, 12000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Curry Bread', 2, 50000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Hamburger', 3, 25000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Whole grain cereal', 2, 36000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Bell peppers', 4, 120000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Hot Dogs', 3, 20000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Pizza', 3, 40000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Lobster', 1, 150000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Snails fried with coconut', 1, 76000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Steamed squid', 1, 80000)
insert dbo.Food(FoodName, IdCategory, Price) values (N'Beef salad with vinegar', 4, 60000)
go

--add bill
insert dbo.Bill (DateCheckIn, DateCheckOut, IdTable, Status) values (GETDATE(), null, 3, 0)
insert dbo.Bill (DateCheckIn, DateCheckOut, IdTable, Status) values (GETDATE(), null, 5, 0)
insert dbo.Bill (DateCheckIn, DateCheckOut, IdTable, Status) values (GETDATE(), GETDATE(), 4, 1)
go

--add bill info
insert dbo.BillDetail (IdBill, IdFood, Count) values (2,1,2)
insert dbo.BillDetail (IdBill, IdFood, Count) values (1,3,4)
insert dbo.BillDetail (IdBill, IdFood, Count) values (3,5,1)
insert dbo.BillDetail (IdBill, IdFood, Count) values (3,6,2)
insert dbo.BillDetail (IdBill, IdFood, Count) values (2,5,2)
go

