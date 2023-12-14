
create table pro ( id int , proname varchar(50) , price int  , quantity int  )

select * from pro 

insert into  pro values ( 1 , 'tost' , 100 , 5 )
insert into pro values (2, 'biscut' , 120 , 10 )
insert into  pro values ( 3 , 'chocklate' , 125, 15 )
insert into  pro values ( 4 , 'kurkure' , 121, 11 )
insert into  pro values ( 5 , 'takatak' , 119, 09 )
insert into  pro values ( 6 , 'puff' , 125, 15 )

/*if we want top rows the use this*/
select top 3 proname , price from  pro  order by  price asc

/* if we want top rates n all then use this */
select price from pro where price > 101



