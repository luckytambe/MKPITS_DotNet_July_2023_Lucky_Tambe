
create table customer2 (custid int, custname varchar(50) , telno bigint )

insert into customer2 values (101,'Lucky Tambe' , 8485889337 )
insert into customer2 values (102,'Chetan Raut' , 8485889777 )
insert into customer2 values (103,'Devid Kothe' , 8785749337 )
insert into customer2 values (104,'Sarang Bhau' , 8895889337)
insert into customer2 values (105,'Akash Badmash', 8485889337 )


create table orders2 ( custid int , orderdate Date  ,ordername varchar(20) )
insert into orders2 values ( 101,'2023-10-20', 'Savlon' )
insert into orders2 values (102, '2023-10-21', 'Detol')
insert into orders2 values ( 103,'2023-10-20', 'Savlon')


select * from customer2
select * from orders2

 select customer2.custid, customer2.custname, customer2.telno,orders2.orderdate,orders2.ordername from customer2  inner join orders2 on customer2.custid=orders2.custid
drop table customer2