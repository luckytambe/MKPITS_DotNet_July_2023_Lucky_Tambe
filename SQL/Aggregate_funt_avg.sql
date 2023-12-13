
create table collage2 ( roll int primary key , name varchar(50) , Marks Int , grade varchar(1)  , city varchar(20)) 

select * from collage2

insert into collage2 values (1 , 'cheaten' , 55 , 'A', 'Nagpur')
insert into collage2 values (2 , 'Lucky' , 56 ,  'D', 'Aurangabad')
insert into collage2 values (3 , 'Devid' , 57  , 'E', 'Kothe')
insert into collage2 values (4 , 'Akash' , 90 , 'H', 'Nagpur')
insert into collage2 values (5 , 'lucky' , 97 ,  'W', 'Aurangabad')
insert into collage2 values (6 , 'Chandu' , 90  , 'Q', 'Kothe')


select max (Marks) from collage2
/* If we want max marks to student then we use Above condition */

select city , name ,count (grade) from collage2 group by city , name 
/* if we want to count to any colom then we use above condition */

 


 drop table Collage2