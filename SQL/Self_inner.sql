

create table sttt ( id int primary key identity , First_name varchar(50) , Last_Name varchar(50) , City varchar(50))

insert into sttt values ( 'Lucky' , 'Tambe' , 'Nagpur')
insert into sttt values ('Chetan' , 'Raut' , 'Amravati')
insert into sttt values ('Akash' , 'Gautam' , 'Nagpur')
insert into sttt values ('Sarang' ,'Praja','Shahu mholla')
insert into sttt values ('Mohit' , 'momos' , 'motibag')

select * from sttt

     select s1.first_name,s2.last_name,s2.city
     from sttt s1,sttt s2
     where s1.id <> s2.id 
     and s1.city=s2.city
     order by s2.city

	 /* Same City K Dekhna ho to */ 
