
/* SQL Server UNIQUE constraint to ensure the uniqueness of data contained in a column or a group of columns.*/

create table Uniq ( id int identity primary key , firstName varchar(50) , lastname varchar(50) , Email varchar(50) unique )

insert into uniq values ( 'Lucky','Tambe','lucky18tambe@gmail.com')
insert into uniq values ( 'Chetan', 'Khangar','CheatanRaut@gmail.com')
insert into uniq values ( 'Sujit','Raut','Cheatan1Raut@gmail.com')

select *from uniq

/* Some Other Techqnic */

create table uniq1( id int identity primary key , Name varchar(50) , Email varchar(50) , unique (Email))

insert into uniq values ( 'Lucky','Tambe','lucky18tambe@gmail.com','@gmail2.com')
insert into uniq values ( 'Chetan', 'Khangar','CheatanRaut@gmail.com', '@gmail1.com')
insert into uniq values ( 'Sujit','Raut','Cheatan1Raut@gmail.com', '@gmail3.com')

select *from uniq1

/* The following example creates a UNIQUE constraint that consists of two columns person_id and skill_id: */ 

create table uniqu ( id int identity primary key , person_id int  , skill_id int , update_at DateTime  , unique ( person_id, skill_id) )

insert into uniqu values ( 111, 10 ,'2023-10-11')
insert into uniqu values ( 112, 10 , '2023-10-12')
insert into uniqu values ( 113, 10 ,'2023-10-13')
insert into uniqu values ( 111, 10 , '2023-10-14')

select * from uniqu
drop table uniqu






