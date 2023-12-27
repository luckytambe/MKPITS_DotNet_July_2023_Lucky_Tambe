create table candidate1 ( id int primary key , Names nvarchar(50) , prices decimal ,
quantity int )

insert into candidate1 values (1 , 'Mouese' , 500, 5 )
insert into candidate1 values (2 , 'keybord' , 400, 7 )
insert into candidate1 values (3 , 'cpu' , 1000, 3 )

select * from candidate1

declare 
@id int ,
@Names varchar(max),
@prices int ,
@quantity int ;

declare can1 cursor
for select
 id, Names,prices , quantity from candidate1 where prices > 300 ;

open can1;

fetch next from can1 into 

@id  ,
@Names,
@prices ,
@quantity  ;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT CAST (@id as varchar) + ' '+ @Names + ' ' + Cast(@prices as varchar) + ' ' +cast( @quantity AS varchar)
        fetch next from can1 into 

@id  ,
@Names,
@prices ,
@quantity  ;
    END;

	close can1;
	deallocate can1;