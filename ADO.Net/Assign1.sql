
create table candidate ( id int primary key , Names nvarchar(50) , prices decimal ,
quantity int )

insert into candidate values (1 , 'Mouese' , 500, 5 )
insert into candidate values (2 , 'keybord' , 400, 7 )
insert into candidate values (3 , 'cpu' , 1000, 3 )

select * from candidate

declare 
@id int ,
@Names varchar(max),
@prices int ,
@quantity int ;

declare can cursor
for select
 id, Names,prices , quantity from candidate where id < 3 ;

open can;

fetch next from can into 

@id  ,
@Names,
@prices ,
@quantity  ;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT CAST (@id as varchar) + ' '+ @Names + ' ' + Cast(@prices as varchar) + ' ' +cast( @quantity AS varchar)
        fetch next from can into 

@id  ,
@Names,
@prices ,
@quantity  ;
    END;

	close can;
	deallocate can;
