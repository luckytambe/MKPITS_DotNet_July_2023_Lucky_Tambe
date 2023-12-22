/*create a table student having columns rno,name,email,city,courseid
insert some records into student table
create a table fees having columns feesid,rno,feesdate,amount,courseid
write a query to display fees details of those student whose city=nagpur
write a query to display fees details of those student whose city=mumbai
write a query to display fees details of those student whose city=delhi
*/

create table stude ( roll int primary key identity  , Full_Name varchar(50) , Emails varchar(50) , City varchar(50) , courseid varchar(50) )

insert into stude values (  'Lucky Tambe' , 'Lucky@gmail.com' , 'Nagpur' , 10) 
insert into stude values (  'Cheatan Raut' , 'Cheatan@gmail.com' , 'Nagpur' , 10 ) 
insert into stude values (  'sarang pra' , 'sarang@gmail.com' , 'mumbai' , 11 ) 
insert into stude values (  'Devid Kothe' , 'Devid@gmail.com' , 'mumbai' , 11) 
insert into stude values (  'Akash gautam' , 'Akash@gmail.com' , 'delhi' , 12 ) 
insert into stude values (  'Sahil gautam' , 'Sahil@gmail.com' , 'delhi' , 12 ) 

/*create a table fees having columns feesid,rno,feesdate,amount,courseid*/

create table fe ( feesid int , fessdate date , amt varchar(50) , courseid varchar(50) )

insert into fe values ( 1 , '2023-10-01' , 5000 , 10 )
insert into fe values ( 2 , '2023-10-02' , 5000 , 10 )
insert into fe values ( 3 , '2023-10-03' , 6000 , 11 )
insert into fe values ( 4 , '2023-10-04' , 6000 , 11 )
insert into fe values ( 5 , '2023-10-05' , 7000 , 12 )
insert into fe values ( 6 , '2023-10-06' , 7000 , 12 )

select * from stude
select * from fe

select * from fe where courseid in ( select courseid from stude where city = 'nagpur')


