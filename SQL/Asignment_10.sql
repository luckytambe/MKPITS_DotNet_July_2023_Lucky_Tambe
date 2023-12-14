/* 10 From the following table, write a SQL query to find the Nobel Prize winner 'Bernard Katz'. Return year,
subject.*/

create table winners ( years int ,sub varchar(50) , Winner varchar(50) , country varchar(50) , category varchar(50) )

select * from winners

insert into winners values ( '1970' ,'Physics' , 'Hannes Alfven' , 'Sweden' , 'Scientist')
insert into winners values ( '1970 ', 'Physics' ,  'Louis Neel' ,  'France' , 'Scientist' )
insert into winners values( '1972 ','Chemistry' ,'Luis Federico' , 'Leloir France' , 'Scientist')
insert into winners values ('1970 ','Physiology' ,  'Ulf von Euler', 'Sweden' ,'Scientist')
insert into winners values ('1973 ', 'Physiology', 'Bernard Katz', 'Germany' ,'Scientist')
insert into winners values ( '1970' ,' Literature' ,'Aleksandr Solzhenitsyn' ,'Russia' ,'Linguist')
insert into winners values ('1970 ', 'Economics' ,  'Paul Samuelson' ,'USA' , 'linguist')

select years , sub from  winners where Winner = ' Bernard Katz'


drop table winners