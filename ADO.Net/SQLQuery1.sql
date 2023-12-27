
create table pro ( pro_id int primary key , pro_Name nvarchar(50) not null  , pro_prize int not null, pro_Quantity int )

insert into pro values (1 , 'Parle-G' , 5000 , 8),
                       ( 2 , 'Kur-kure' , 6000 , 7),
					   (3,'Lays',3000 ,7)
					   
DECLARE 
    @product_name VARCHAR(MAX),
    @list_price   DECIMAL;

DECLARE cursor_product1 CURSOR
FOR SELECT 
        pro_Name, 
        pro_prize
    FROM 
        pro;
OPEN cursor_product1;

FETCH NEXT FROM cursor_product1 INTO 
    @product_name, 
    @list_price;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @product_name +CAST(@list_price AS varchar)  ;
        FETCH NEXT FROM cursor_product1 INTO 
            @product_name, 
            @list_price;
    END;

