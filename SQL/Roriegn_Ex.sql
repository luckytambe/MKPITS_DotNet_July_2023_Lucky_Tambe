


create table orders ( id  int primary key , orderdate date , orderid int ) 

create table ordersdetails ( id int  , name varchar(20) , orderid int constraint YK foreign key (id) references  orders (id) )


insert into orders values ( 1 , '2023-10-17' , 5)
insert into orders values ( 2 , '2023-11-18',6)

insert into ordersdetails values (1, 'lucky ', 4)
insert into ordersdetails values (1, 'Sujit ', 1)
insert into ordersdetails values (2 ,'rohit' , 5)
insert into ordersdetails values (2 ,'Radhe' , 9)


select * from orders 
select * from ordersdetails