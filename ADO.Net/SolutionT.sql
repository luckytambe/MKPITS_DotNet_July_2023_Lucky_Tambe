
CREATE TABLE TableNation1(Nation_Id int primary key,
                         Nation_Name varchar(100))
insert into TableNation1 Values ( 101 ,'India'),
                               (102,'Pakistan')


CREATE TABLE TableState1(State_Id int primary key,
                        State_Name varchar(100),
						Nation_Id int,
						foreign key(Nation_Id) references TableNation1(Nation_Id))
Insert into TableState1 Values ( 11,'Maharashtra',101 ),
                              (12,'Gujrat',101),
							  (13,'Sindh', 102),
							  (14, 'Eslamabad',102)


CREATE TABLE TableCity1(City_Id int primary key,
                        City_Name varchar(100), 
						State_Id int,
						foreign key(State_Id) references TableState1(State_Id))
Insert into TableCity1 Values ( 1001 , 'Mumbai',11),
                             (1002 , 'Pune' ,11),
							 (1003 , 'Rajkot',12),
							 (1004 , 'Surat', 12),
							 (1005 , 'NayeBasti',13),
							 (1006 , 'Mominpua',13),
							 (1007 , 'Gittikhadan',14),
							 (1008 ,'Teka-Naka',14)


CREATE TABLE TableCourseRegDetail1(CourseRegId int identity primary key,
                                  CategoryId int,
								  FullName varchar(100),
								  GenderId int)



CREATE TABLE TableRegAddress1(RegAddressId int identity,
                              CourseRegId int ,
							  Nation_Id int,
							  State_Id int,
							  City_Id int,
							  foreign key(CourseRegId) references TableCourseRegDetail1(CourseRegId),
							  foreign key(Nation_Id) references TableNation1(Nation_Id),
							  foreign key(State_Id) references TableState1(State_Id),
							  foreign key(City_Id) references TableCity1(City_Id))



CREATE TABLE TableFeeDetail1(FeeId int identity,
                            CourseRegId int,
							TotalAmount decimal,
							MiniPer decimal,
							PaidAmount decimal,
							BalAmount decimal,
							PaidDate DateTime,
							foreign key(CourseRegId) references TableCourseRegDetail1(CourseRegId))

select * from TableNation1
Select * From TableState1
Select * From TableCity1
select * from TableCourseRegDetail1
select * from TableRegAddress1
Select * from TableFeeDetail1
