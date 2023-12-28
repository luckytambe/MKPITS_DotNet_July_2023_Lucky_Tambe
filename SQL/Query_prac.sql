
create table Express ( id int primary key , nammes nvarchar(50) , quantity int , price int ) 

insert into express values (   1 , 'lucky tambe' , 5 , 5000)
insert into express values (   2 , 'sujit bhangar', 6 , 7000)
insert into express values (   3 , 'chetan bhange', 5 , 5000)
insert into express values (   4 , 'raut dada' , 7 , 8547)

select * from Express

declare 
@id int , 
@nammes varchar(max),
@quantity int ,
@price int 

declare C cursor 
for select
id ,
nammes,
quantity,
price from Express ;

open C;
fetch next from C into 
@id ,
@nammes ,
@quantity ,
@price ;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT  CAST (@id AS varchar) + ' ' + @nammes + ' '  + CAST (@quantity As varchar) + ' ' + CAST (@price As varchar) ;
        FETCH NEXT FROM C INTO 
            @id,
			@nammes ,
			@quantity,
			@price ;
			End;

			close C;
	deallocate C;