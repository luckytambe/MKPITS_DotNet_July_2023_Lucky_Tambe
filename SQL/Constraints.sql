
create table orders ( orderid1 int identity primary key , custname varchar(20) )

create table orderdetails ( orderid2 int, name varchar(50) , quantity int , 
 constraint od foreign key (orderid2) references orders(orderid1)  )
 

 insert into orders values('kurkure')
  insert into orders values('Chips')
  insert into orders values (' mol')

  insert into orderdetails values( 1 , 'lucky' , 5) 
   insert into orderdetails values( 1 , 'sujit' , 3) 
    insert into orderdetails values( 1 , 'sarang' , 7) 
	 insert into orderdetails values( 1 , 'chetan' , 7) 
	 insert into orderdetails values ( 1 , 'hahah', 7)

	 insert into orderdetails values ( 2 , 'hahah', 7)
	 insert into orderdetails values ( 2 , 'hahah', 7)

	   insert into orderdetails values ( 3 , 'hahah', 7)
	   insert into orderdetails values ( 3 , 'hahah', 7)

select * from orders
select * from orderdetails 


 drop table orderdetails
 drop table orders

