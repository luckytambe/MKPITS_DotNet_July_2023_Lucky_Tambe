

create table empp ( id int primary key , ENAME Varchar(50) ) 


create table Emplog ( log_id int identity (1,1) , emp_id int , ENAME Varchar(50) ,  operation varchar(50) , updateDate datetime )

select * from empp
select * from Emplog

create trigger tr2
on empp for insert as 

insert into Emplog ( emp_id , operation , updateDate ) 
select id ,'insert' , GETDATE() from inserted  

insert into empp values ( 1 , 'lucky') 
drop table Emplog
drop table empp

