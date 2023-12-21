create table stds1 ( id int primary key identity , Admission_no  varchar(50) , Full_Name Varchar(50) not null , Course Varchar(50) )

insert into stds1 values( 103 , 'Lucky Tambe' , '.Net')
insert into stds1 values (104 , 'Chetan Raut' , 'Java')
insert into stds1 values (105 , 'Devid kothe','.Net')
insert into stds1 values( 106 , 'Sujit Khangar' , '.Net')
insert into stds1 values (107 , 'Akash Gautam' , 'Java')
insert into stds1 values (108 , 'Chandu Raut','.Net')

select * from stds1 

create table feess ( Admission_no  varchar(50) ,full_Name varchar(50) , amt varchar(50))

insert into feess values( 106 , 'Sujit Khangar' , 5000)
insert into feess values (107 , 'Akash Gautam' , 2000)

select * from feess 

select stds1.Admission_no , stds1.Full_Name , stds1.course from stds1 cross join feess

drop table stds1
drop table feess
