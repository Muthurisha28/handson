--write a SQL query to find the salesperson and customer who belongs to same city. Return Salesman, cust_name and city
select Salesman.name,Customer.city,Customer.cust_name
from Salesman
Inner Join Customer 
on Salesman.city=Customer.city



--write a SQL query to find those orders where order amount exists between 500 and 2000. Return ord_no, purch_amt, cust_name, city

Select Orders.ord_no,Orders.purch_amt,Customer.cust_name,Customer.city
From orders,Customer
Where Orders.customer_id=Customer.customer_id 
And orders.purch_amt between 500 and 2000

Select Orders.ord_no,Orders.purch_amt,Customer.cust_name,Customer.city
From orders INNER join Customer
on  Orders.customer_id=Customer.customer_id 
And orders.purch_amt between 500 and 2000

--write a SQL query to find the salesperson(s) and the customer(s) he handle. Return Customer Name, city, Salesman, commission
Select Customer.cust_name,Customer.city,salesman.salesman_id,salesman.commission
from Customer,Salesman
Where salesman.salesman_id=customer.salesman_id

Select Customer.cust_name,Customer.city,salesman.salesman_id,salesman.commission
from Customer INNER join Salesman
On salesman.salesman_id=customer.salesman_id


--write a SQL query to find those salespersons who received a commission from the company more than 12%. 
--Return Customer Name, customer city, Salesman, commission.
select  customer.cust_name,customer.city,customer.salesman_id,Salesman.commission
from Customer,Salesman
where customer.salesman_id=salesman.salesman_id
And Salesman.commission>0.12

select  customer.cust_name,customer.city,customer.salesman_id,Salesman.commission
from Customer inner join Salesman
on customer.salesman_id=salesman.salesman_id
And Salesman.commission>0.12





--write a SQL query to find those salespersons do not live in the same city where their customers live and
-- received a commission from the company more than 12%. Return Customer Name, customer city, Salesman, salesman city, commission

select customer.cust_name,customer.city,Salesman.salesman_id,salesman.city,Salesman.commission
from Salesman,Customer
where Salesman.salesman_id=customer.salesman_id and salesman.commission>0.12 and salesman.city!=customer.city

select customer.cust_name,customer.city,Salesman.salesman_id,salesman.city,Salesman.commission
from Salesman inner join Customer
on Salesman.salesman_id=customer.salesman_id and salesman.commission>0.12 and salesman.city!=customer.city
