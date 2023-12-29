create table TableNation( NationID int primary key , NationName Varchar(500))
insert into TableNation Values ( 1 , 'INDIA' ),
                               ( 2 , 'Pakistan' ),
							   ( 3 , 'Brazil' ),
							   ( 4 , 'America' )


/*-------------------*/

Create Table TableState( StateID int primary key , NationID int foreign key (NationID) references TableNation (NationID),
StateName varchar(500) )
insert into TableState values (  48, 1 , 'Maharashtra'),
                              ( 78 ,2 , 'buldana'),
							  (89 , 3 , 'Gujrat'),
							  (12 , 4 , 'Madhya Pradesh') 


/*-------------------*/

Create table TableCity ( CityId int , StateID int foreign key (StateID) references TableState (StateID), 
CityName Varchar(500) ) 

insert into TableCity Values ( 11 , 48 , 'Nagpur' ),
                             (13, 78 , 'Ajni'),
							 (14 , 89 , 'Bhandara'),
							 (15 , 12 , 'Kammeshwar')



/*-------------------*/

create table TableCourseRegDetails ( CourseRegID int primary key , Categorylnd int , FullName varchar(50) , Genderlnd int )

insert into TableCourseRegDetails values ( 33 , 3 , 'Chandan Kumar' , 2),
                                         ( 32 , 4 , 'Rahul Kumar' , 3),
										 ( 37 , 8 , 'Rakesh Kumar' , 7),
										 ( 39 , 1 , 'Sujit Kumar' , 5)




/*-------------------*/

create table TableRegAddress ( RegAddressId int , 
CourseRegID int foreign key (CourseRegID) references TableCourseRegDetails (CourseRegID) , 
NationID int foreign Key (NationID)references TableNation , StateId int , CityId int ) 

insert into TableRegAddress values ( 001 , 33 ,  1 , 48 , 11 ) ,
                                   ( 002 , 32 ,  2 , 78 , 12 ),
								   ( 003 , 37 ,  3 , 89 , 13 ),
								   ( 004 , 39 ,  4 , 12 , 14 )



/*-------------------*/


create table TableFeeDetails ( FeeID int , CourseRegID int foreign key (CourseRegID) references TableCourseRegDetails (CourseRegID) ,
TotalAmount Decimal , MinPer Decimal , PaidAmount Decimal ,BalAmount decimal, PaidDate DateTime ) 

insert into TableFeeDetails values ( 101, 33,  65000,   5000 ,5000 ,'2013-12-12'),
                                   ( 102 , 32 , 19000 , 1700 ,1000 , '2023-12-13'),
								   ( 103 , 37 , 25000 , 1800 ,2000 , '2023-10-14'),
								   ( 104 , 39 , 34000 , 1200 ,3000 , '2023-11-15')

Select * from TableNation
select * from TableState
Select* from TableCity
select * from TableCourseRegDetails
select * from TableRegAddress
select * from TableFeeDetails












