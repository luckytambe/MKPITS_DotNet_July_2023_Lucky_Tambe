create table stds2 ( id int primary key identity , Admission_no  varchar(50) , Full_Name Varchar(50) not null , Course Varchar(50))

insert into stds2 values( 103 , 'Lucky Tambe' , '.Net')
insert into stds2 values (104 , 'Chetan Raut' , 'Java')
insert into stds2 values (105 , 'Devid kothe','.Net')
insert into stds2 values( 106 , 'Sujit Khangar' , '.Net')
insert into stds2 values (107 , 'Akash Gautam' , 'Java')
insert into stds2 values (108 , 'Chandu Raut','.Net')


create table fees1 ( Admission_no  varchar(50) ,full_Name varchar(50) , amt varchar(50))

insert into fees1 values( 106 , 'Sujit Khangar' , 5000)
insert into fees1 values (107 , 'Akash Gautam' , 2000)

select * from stds2 
select * from fees1 

select stds2.Admission_no , stds2.Full_Name , stds2.course , fees1.amt from stds2 FULL OUTER JOIN  fees1 on
stds2.Admission_no = fees1.Admission_no 