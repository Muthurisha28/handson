Create Table Salesman(salesman_id numeric(5) Primary key,
name  varchar(30),
city varchar(15),
commission decimal(5,2))

Insert into Salesman values(5001 , 'James Hoog ' , ' New York ',0.15)
Insert into Salesman values(5002 ,' Nail Knite ', 'Paris',    0.13)
Insert into Salesman values(5005 , 'Pit Alex', 'london', 0.11);
Insert into Salesman values(5003 , 'Lauson Hen','San Jose ', 0.12);
Insert into Salesman values(5006 , 'Mc Lyon ','Paris ', 0.14);
Insert into Salesman values(5007 , 'Paul Adam ' ,' Rome' ,0.13);

Select* from Salesman

Create Table Customer(customer_id numeric(5) Primary key,cust_name  varchar(30),city varchar(15),grade numeric(3), salesman_id numeric(5))


insert into Customer values(3002 ,' Nick Rimando ',' New York ',100 , 5001)
insert into Customer values(3007 , 'Brad Davis ','New York'  ,200 ,5001)
insert into Customer values(3005 ,'Graham Zusi ',' California' , 200 , 5002)
insert into Customer values(3008 , 'Julian Green',  'London ',300 , 5002)
insert into Customer values(3004 , 'Fabian Johnson', 'Paris ',300 ,5006)
insert into Customer values(3009 , 'Geoff Cameron'  ,'Berlin ' , 100 ,5003)
insert into Customer values(3003 , 'Jozy Altidor ' , ' Moscow ' ,    200 ,5007)
--insert into Customer values(3001 , 'Brad Guzan ' ,' London' ,  ,5005)


select * from Customer
create table orders
(
ord_no numeric(5)Primary key,
purch_amt decimal(8,5),
ord_date date,
customer_id numeric(5)FOREIGN KEY REFERENCES Customer (customer_id) ,
salesman_id numeric(5)FOREIGN KEY REFERENCES Salesman (salesman_id) )
 drop table orders

insert into orders values (70001 ,150.5 ,'2012-10-05' ,3005, 5002)
insert into orders values (70009 ,270.65, '2012-09-10' ,3001, 5005)
insert into orders values (70002, 65.26 ,'2012-10-05', 3002 ,5001)
insert into orders values (70004 ,110.5 ,'2012-08-17' ,3009 ,5003)
insert into orders values (70007 ,948.5, '2012-09-10' ,3005, 5002)
insert into orders values (70005 ,24.6 ,'2012-07-27', 3007, 5001)
insert into orders values(70008 ,576 ,'2012-09-10' , 3002 ,5001)
insert into orders values(70013 ,304.6 ,'2012-04-25' , 3002 ,5001)
select * from orders
