create table candidate2 ( id int primary key , Names nvarchar(50) , prices decimal ,
quantity int )

insert into candidate2 values (1 , 'Mouese' , 500, 5 )
insert into candidate2 values (2 , 'keybord' , 400, 7 )
insert into candidate2 values (3 , 'cpu' , 1000, 3 )

select * from candidate2

declare 
@id int ,
@Names varchar(max),
@prices int ,
@quantity int ;

declare can3 cursor
for select
 id, Names ,prices , quantity from candidate2 where Names = 'Mouese' ;

open can3 ;

fetch next from can3 into 

@id  ,
@Names,
@prices ,
@quantity  ;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT CAST (@id as varchar) + ' '+ @Names + ' ' + Cast(@prices as varchar) + ' ' +cast( @quantity AS varchar)
        fetch next from can2 into 

@id  ,
@Names,
@prices ,
@quantity  ;
    END;

	close can3;
	deallocate can3;