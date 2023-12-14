
/*6 . From the following table, write a SQL query to find those customers whose grade is 200. Return
customer_id, cust_name, city, grade, salesman_id.*/

create table people ( id int , name varchar(50) , city varchar(50) , commission varchar(50)) 

select * from people

insert into people values (5001 , 'James Hoog' ,  'New York' , 0.15 )
insert into people values ( 5002 ,  'Nail Knite' ,  'Paris' , 0.13 )
insert into people values(5005 , 'Pit Alex' , 'London' , 0.11)
insert into people values(5006 , 'Mc Lyon' , 'Paris' , 0.14 )
insert into people values ( 5007 , 'Mc Lyon' , 'Paris' , 0.14)
insert into people values (5003 , 'Lauson Hen' , 'San Jose' , 0.12)

select name, city  from people where city = 'paris' 