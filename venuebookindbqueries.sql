create database VenueBookingDB
drop database VenuBookingDB
use VenueBookingDB


[14:36] Naga Venkata Sushmanth (Guest)
create database project
--Admin table
create table Admin(
uName varchar(50) primary key,
pWord varchar(50))
insert into Admin values('admin','admin')
--event table
create table Eventtab(
Eventname varchar(50) primary key,
Details varchar(250))
--venue table
create table VenueTab(
eventname varchar(50),
venuename varchar(50),
price int,
address varchar(250))
--food table
create table FoodTab(
Eventname varchar(50),
foodname varchar(50),
cost int,
details varchar(250))
--decoration table
create table Decoration(
eventName varchar(40),
Price int)
--customer table
create table CustomerTab(
uname varchar(50) primary key,
pwd varchar(50),
custname varchar(50),
custadd varchar(50),
mobileno varchar(50),
email varchar(100))
--customer event table
create table CustEventTab(
EventName varchar(50) primary key,
eventType  varchar(50),
people varchar(50),
eventdate datetime,
details varchar(60),
uName varchar(50))
--booking table
create table BookinTab(
bno float,
bDate datetime,
eventname varchar(50) primary key,
uName varchar(50),
price int,
seltype varchar(50),
selname varchar(50))
---payment table
create table PaymentTab(
bno int,
bDate datetime,
amt int,
eventtype varchar(50),
uname varchar(50),
paytype varchar(50),
details varchar(50))



-- Add some more table
--give the relationship between the tables