
create table Collage1 ( roll int primary key , name varchar(50) , Marks Int , grade varchar(1)  , city varchar(20)) 

select * from Collage1

insert into collage1 values (1 , 'cheaten' , 55 , 'A', 'Nagpur')
insert into collage1 values (2 , 'Lucky' , 56 ,  'D', 'Aurangabad')
insert into collage1 values (3 , 'Devid' , 57  , 'E', 'Kothe')

select name , marks from collage1
/*select distinct city  from Collage1 / isse apne ko repeat nhihote  */

select * from Collage1 where marks >55
/* where ye condition apne ko ye btati hai ki apne ko agr kissi k bhi kuch kam jada dekhna raha toh where ka use hota hai */

select * from Collage1 where city = 'Nagpur'
/* if we want to all same cityies in table then we take to Above condition */

select * from Collage1 where marks > 55  and city = 'Nagpur'
/* if we want above 55 marks and we mension that city to wants us */

select * from Collage1 where marks+10  > 70

select * from Collage1 order by city Asc 
/* Assending */

select * from collage1 order by name desc
/* decendion */


