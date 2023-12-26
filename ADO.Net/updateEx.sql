create table tale1 ( id int primary key , Full_name varchar(50) , Emailid nvarchar(50) , managerid int  , hiredate date )

create table tale2 ( empid int identity (1,1) , Eid int , operator varchar(50) , dates datetime )

select * from tale1
select * from tale2


create trigger tt 
on tale1
after update
as insert tale2 (eid , operator , dates )
select id , 'update' , GETDATE() from deleted 

insert into tale1 values ( 1 , 'Lucky Tambe' , 'Luckytambe@gmail.com' , 1 , '2023-12-12') 
insert into tale1 values ( 2 , 'sujit mate' , 'Luckytambe@gmail.com' , 2 , '2023-12-12') 
insert into tale1 values ( 3 , 'chetan moye moye' , '@gmail.com' , 3 , '2023-12-12') 

update tale1 set full_name = 'Devid' where id = 3 