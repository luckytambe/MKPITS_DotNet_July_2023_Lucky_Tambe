
/* If Agar Apne ko koi bhi ek colum dekhna hai to apne ko select Wali use krni padegi */

/* if agar apne ko accending mangta hai to apne ko order by */

/* if agar apne ko decending order hona to apne ko desc lagana padhta */


create table customertable (  first_name varchar(50) , last_name varchar(50) , Phone int , Email varchar(50) , Address varchar(50))

select * from customertable

insert into customertable values ('Lucky' , 'Tambe' , 848588 , 'lucky18tambe@gmail.com' , 'Nagpur')
insert into customertable values ('Devid' , 'Kothe' , 848588 , 'lucky18tambe@gmail.com' , 'Nagpur')
insert into customertable values ('Chetan' , 'Raut' , 848588 , 'lucky18tambe@gmail.com' , 'Nagpur')
insert into customertable values ('Sujit' , 'bhangar',848588,'lucky18tambe@gmail.com','Nagpur')

select last_name , first_name , Phone From customertable

select * from customertable order by last_name

select * from customertable order by first_name desc