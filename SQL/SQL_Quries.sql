
create table students1 ( Roll Bigint primary key , name varchar(50) ,  Course varchar(50) , fees int )

select * from students1

insert into  students1 values( 1 , ' Lucky Tambe ' , '.NET' , 5000 )
insert into  students1 values( 2 , ' devid kothe ' , '.NET' , 5000 )
insert into  students1 values( 3 , ' sarang prajapati', 'JaVa' , 8000 )
insert into  students1 values( 4 , ' Akash Gautam ' , 'python' , 7000 )
insert into  students1 values( 5 , ' sujit bhangar ' , '.NET' , 5000 )
insert into  students1 values( 6 , ' Chetan khangar' , '.NET' , 5000 )
insert into  students1 values( 7 , ' Ashwin sothe ' , 'JAVa' , 8000 )


select  name from students1	
/* Only One Column Seen this Method */

select * from students1 where Course ='.NET' 
 /*if we see only one thing reapeatly the use above condition */

select * from students1 where Course <> '.NET'
/* If we want to Except this course or anything we Use to This */

select top  40 PERCENT * from students1 
/* if we want sum records as per lists then use to this condition */

SELECT name , course from students1 order by name, course 
/*if we want some individual columns Then we use to above condition */
   


