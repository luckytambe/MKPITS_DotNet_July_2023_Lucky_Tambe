

create table student12 ( rno int primary key , name varchar(20) , address varchar(20))
create table fees( feesid int  , rno int constraint Vk foreign key (feesid) references student12(rno) , amount int , datee date ) 


insert into student12 values ( 1, 'lucky' , 'Nagpur') 
insert into student12 values ( 2, 'Sarang' , 'Pachpili') 



insert into fees values (1, 12 , 5000 , '2023-10-16')
insert into fees values (1, 12 , 5000 , '2023-10-16')
insert into fees values (2, 12 , 6000 , '2023-10-18')
insert into fees values (2, 12 , 7000 , '2023-10-18')

select * from student12
select * from fees 