create table collage2 ( roll int primary key , name varchar(50) , Marks int , grade varchar(1)  , city varchar(20)) 

select * from collage2

insert into collage2 values (1 , 'cheaten' , 55 , 'A', 'Nagpur')
insert into collage2 values (2 , 'Lucky' , 56 ,  'D', 'Aurangabad')
insert into collage2 values (3 , 'Devid' , 57  , 'E', 'Kothe')
insert into collage2 values (4 , 'Akash' , 90 , 'H', 'Nagpur')
insert into collage2 values (5 , 'lucky' , 97 ,  'W', 'Aurangabad')
insert into collage2 values (6 , 'Chandu' , 90  , 'Q', 'Kothe')


select * from Collage2 order by city Asc 


select city, avg (marks) from collage2 group by city  order by avg(marks)


/*if we want to show tabel in descending order then we have to write below condition */
select city, avg (marks) from collage2 group by city  order by avg(marks) desc