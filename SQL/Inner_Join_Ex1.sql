
/* This JOIN returns all records from multiple tables that satisfy the specified join condition. */

create table std ( id int primary key identity , admisstion_no varchar(50)  , First_Name varchar(50) Not Null,
Last_Name varchar(50) Not Null , age int , City varchar(50) )


create table fee ( admisstion_no varchar(50) , First_Name varchar(50) Not Null,
Last_Name varchar(50) Not Null , Fees int )


insert into std values ( 1551 , 'lucky' , 'Tambe' , 25 , 'Nagpur')
insert into std values ( 1552 , 'Cheaten' , 'Raut', 22 , 'Amravati')
insert into std values ( 1553 , 'Sujit' , 'Khangar' , 22, 'Bhandara')
insert into std values (1554 , 'Sarang' , 'Prajapati' , 22 , 'Nagpur')
insert into std values (1555 , 'Devid' , 'Kothe' , 23 , 'Mauda')
insert into std values ( 1556 , 'Akash' , 'Gautam' , 22 , 'Nagpur')
insert into std values ( 1557 , 'Sahil' , 'Raut', 28 , 'Nagpur')
insert into std values ( 1558 , 'Huzefa' , 'Khan' , 25, 'Gondia')
insert into std values (1559 , 'Ashwin' , 'mothe' , 29 , 'Nagpur')
insert into std values (1560 , 'Chandu' , 'Meshram' , 27 , 'Takli')



insert into fee values (1559 , 'Ashwin' , 'mothe' , 2000)
insert into fee values ( 1551 , 'lucky' , 'Tambe' , 3000)
insert into fee values ( 1558 , 'Huzefa' , 'Khan' , 5000)
insert into fee values (1554 , 'Sarang' , 'Prajapati' , 5000)
insert into fee values (1560 , 'Chandu' , 'Meshram' , 5000)


Select * from std
select * from fee

select std.admisstion_no , std.First_Name ,std.Last_Name , fees from std inner join fee 
on std.admisstion_no = fee.admisstion_no

 