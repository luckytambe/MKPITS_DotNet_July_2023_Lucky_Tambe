create table product0 ( pri_id int identity primary key , pro_Name varchar(100) not null , unit_price dec(10,2) check (unit_price > 0) )


select * from product0

insert into product0 values('FaceWash',120)
insert into product0 values ('Soap',1)

Drop table product0

/*-------------------------------------------------*/

create table produ1 ( rno int primary key , marks int check ( marks>0))
select * from produ1
insert into produ1 values ( 1,55)
insert into produ1 values ( 2, 0)

Drop table produ1
/*-------------------------------------------------*/

/*You can also assign the constraint a separate name by using the CONSTRAINT keyword as follows:*/


create table produc( id int identity primary key , Name varchar(50) not null , unit_prices dec (10,1) CONSTRAINT positive_P check ( unit_prices > 0))

select * from produc
insert into produc values('BED', 05)
insert into produc values('RED', 10)

insert into produc (name,unit_prices)
values ('gool gappa',10)
insert into produc (name,unit_prices)
values ('Tata' , 88)
insert into produc( name , unit_prices)
values ('lembo' , null )


drop table produc

/*-------------------------------------------------*/

/* unit price And Discount ( CHECK constraint referring to multiple columns) */

create table pro ( id int identity primary key , Pro_name varchar(50) not null , Amount_price dec(10,3) check ( Amount_price >0 ), 
discount dec( 10,3) check (discount > 0) , check (discount < Amount_price  ) )

insert into pro values ( 'Himalaya' ,5000 , 500 )
insert into pro values ( 'meta' , 500,50)
insert into pro values ('dot' ,0,0)

select * from pro 

/* unit price multiple prob Example */

create table prod ( id int identity primary key , name varchar(50) not null , Amount dec (10,4) , discount dec (10,4) ,
check (Amount > 0) , check (discount > 0) , check ( discount < Amount ) )

insert into prod values ( 'punjab' , 100 , 10)
insert into prod values ('val' , 0 , 0)

select * from prod

/* If Add any column then we use to this*/
alter table prod
add discounted dec(10,4)
insert into prod values ('val' , 1000 , 100 ,300)
/*To remove a CHECK constraint, you use the ALTER TABLE DROP CONSTRAINT statement:*/





