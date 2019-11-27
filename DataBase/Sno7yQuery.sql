create database Sno7y
use Sno7y
create table car(
CID int IDENTITY(100,1),
num nvarchar(255) not null unique,
price decimal not null,
type_car nvarchar(255) not null,
num_seats int not null,
col nvarchar(255) not null,
pick nvarchar(MAX),
available  bit not null,
air_conditioning bit,
primary key(CID)
);
create table offer(
ID int not null,
name nvarchar not null,
startData date not null,
endDate date not null,
primary key(ID)
);

create table type_offer(
num int not null,
name nvarchar not null,
price decimal not null,
primary key(num)
);

create table of_type(
ID_offer int,
num_type int,
foreign key(ID_offer) references offer(ID),
foreign key(num_type) references type_offer(num)
);

create table client(
ssna int,
ID int IDENTITY(1,1) not null,
name nvarchar(255) not null,
ID_car int,
foreign key(ID_car) references car(CID) on delete cascade on update cascade,
startDate datetime not null,
endDate datetime not null,

t_ID int not null,
foreign key(t_ID) references type_client(type_ID),

);

create table type_client(
type_ID int ,
type_name nvarchar(255),
primary key(type_ID)
);
create table package(
ID int IDENTITY(1,1),
name nvarchar(255),
price decimal not null,
primary key(ID)
);
create table package_car(
car_ID int,
package_ID int,
primary key(car_ID,package_ID),
foreign key(car_ID) references car(CID),
foreign key(package_ID) references package(ID),

);
create table reservation_car(
car_ID int not null,
foreign key(car_ID) references car(CID),
start_Date dateTime not null,
end_date dateTime not null
);
create table setting_agency(
ssna nvarchar(14),
primary key(ssna),
Name nvarchar(250) not null,
admin_Name nvarchar(250) not null,
email nvarchar(250),
password nvarchar(Max) not null,
);
Alter table car add primary key(CID)
Alter table client alter column ssna nvarchar(14) not null
Alter table client add primary key(ssna)
Alter table client alter column ID_car int

Alter table client  Alter column  ssna nvarchar(14) not null
Alter table client add foreign key(ID_car) references car(CID) on delete cascade on update cascade
ALTER TABLE client	add balance decimal
ALTER TABLE client add number_of_reservation int
Alter table client add age int
ALter table client add phone nvarchar(11)
Alter table client add email nvarchar(MAX)
Alter table client add password nvarchar(MAX)
ALTER table package add start_date date 
ALTER table package add end_date date 
ALTER table package alter column start_date date not null
ALTER table package alter column end_date date not null
Alter table package add available bit
Alter table package alter column available bit not null

Alter table reservation_car add number int IDENTITY(1,1)   not null 
Alter table reservation_car add primary key(number) 
Alter table reservation_car alter column client_ID nvarchar(14)  not null
Alter table reservation_car add foreign key(client_ID) references client(ssna)
Alter table reservation_car add primary key(number) 
Alter table reservation_car add type_reservation nvarchar(255)
alter table reservation_car add package bit
alter table reservation_car add duration int
alter table reservation_car add price decimal
alter table reservation_car add package_ID int
alter table reservation_car add foreign key(package_ID) references package(ID)


INSERT INTO car (num,air_conditioning,available,num_seats,type_car,price,col,pick) VALUES ('A B C 1 2 3',1,0,5,'BMW',100,'Black','E:\Projects\ITI projects\Sno7y\imgs\BMW1.jpg')
INSERT INTO type_client (type_ID,type_name) VALUES (1,'business')
INSERT INTO type_client (type_ID,type_name) VALUES (2,'For fun')
INSERT INTO type_client (type_ID,type_name) VALUES (3,'wedding party')
INSERT INTO client (ssna,name,ID_car,startDate,endDate,t_ID) VALUES (219,'Mena Nabel',100,2019-08-03 ,2019-08-04 ,1)
INSERT INTO client (ssna,name,ID_car,startDate,endDate,t_ID) VALUES (29,'Mena Nabel',100,2019-08-03 ,2019-08-04 ,1)
INSERT INTO client (ssna,name,ID_car,startDate,endDate,t_ID) VALUES (2910,'Kero',100,2019-08-03  ,2019-08-04 ,1)
INSERT INTO client (ssna,name,ID_car,startDate,endDate,t_ID) VALUES (12345678912329,'Mena Nabel',100,2019-08-03 ,2019-08-04 ,1)
Insert INto reservation_car (car_ID, start_Date,end_date,number) values (1,2019-08-03,2019-08-03,1)
delete from car
select CID, package.name  , package.price from car
join package_car on car.CID = package_car.car_ID
join package on package.ID = package_car.package_ID