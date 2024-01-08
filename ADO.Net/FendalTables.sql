
Create Table TableNation (NationID INT PRIMARY Key , NationName Varchar(500) )

Create Table TableState ( StateID int primary key , NationID  int foreign key ( NationID) References TableNation , StateName Varchar(500) )

create Table TableCity ( CityID int primary key , StateID int foreign key (StateID) References TableState , CityName Varchar(500) )