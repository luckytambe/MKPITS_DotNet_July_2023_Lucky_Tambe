

create table groupA( id int identity primary key , name varchar(50) not null)

create table groupB ( id int , Bname varchar(50) not null , groupB_id int not null ,
CONSTRAINT AB_group foreign key (id)
references groupA(id) )

insert into groupA values ( 'lucky')
insert into groupB  values ( 1 ,'lucky',2)
insert into groupB  values ( 1 ,'Sujit',4)

select * from groupA 
select * from groupB

drop table groupB
drop table groupA

