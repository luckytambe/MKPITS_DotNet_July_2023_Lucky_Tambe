create table payment(custid int , custname varchar(50) , mode varchar(50) , city varchar(50) )

select *from payment

insert into payment values (123, 'chetan', 'netbanking', 'nagpur')
insert into payment values (321, 'lucky', 'credit card', 'indore')
insert into payment values (263, 'devid', 'netbanking', 'jablpur')
insert into payment values (857, 'sarang', 'credit card', 'bhopal')
insert into payment values (874, 'akash', 'netbanking', 'kondhalii')
insert into payment values (747, 'sujit', 'credit card', 'revral')
insert into payment values (872, 'khangar', 'netbanking', 'pachpaoli')
insert into payment values (999, 'bhangar', 'credit card', 'kamal')

select mode , count(custname)from payment group by mode 
