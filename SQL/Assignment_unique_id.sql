create table orders ( ord_no int , punch_Amt float , ord date , id int primary key , salesman_id int )  

select * from orders

insert into orders values (70001 , 150.5 , '2012-10-05' ,  3005 , 5002 )
insert into orders values (70009 , 270.65 ,  '2012-09-10' , 3001 ,  5005)
insert into orders values (70002 , 65.26 , '2012-10-05' ,  3002 , 5001 )
insert into orders values (70004 , 110.5 ,  '2012-08-17' , 3009 , 5003 )
insert into orders values (70007 , 948.5 , '2012-09-10' , 3005 , 5002)
insert into orders values (70005 , 2400.6,  '2012-07-27' , 3007 , 5001)
insert into orders values (70008 , 5760 , '2012-09-10' , 3002 , 5001)




drop table orders 
