
create table Table1 ( order_id int , product Varchar(50) , total int , Customer_id int primary key  )


create table table2 ( id int FOREIGN key ( id ) references Table1 , First_Name Varchar(50) , Last_Name Varchar(50) , Age int , Country Varchar(50) )

insert into table1 values ( 1 , 'Pen' , 20 , 1 ) , 
                          ( 2 , 'Pen' , 20 , 2 ) , 
						  ( 3 , 'Pen' , 20 , 3 )

						  	  

insert into Table2 Values ( 1 , 'Chetan' , 'Raut' , 22 , 'USA'), 
                          ( 2 , 'Devid' , 'Raut' , 23 , 'MP')

						  Select * from Table1
						  Select * from table2