create table TableProductGSTDetails
( product_Gst_ID int primary key, 
Gst_Detail_Name varchar(500) ,
CGST Decimal , SGST Decimal , 
IGST Decimal )

create table Table_product_Category 
( product_category_ID int primary key  ,
Product_Type_Name Varchar(500) ,
Product_Gst_ID int foreign key ( product_Gst_ID ) references TableProductGSTDetails (  product_Gst_ID ))

create table Table_product ( ProductID int primary key , productTypeID int ,ProductName Varchar(500) )

create table TableInvoiceDetails ( invoice_Details_ID int 
, Customer_Name varchar(500) , 
customer_contact varchar(500) , 
product_Category_ID int  foreign key (product_Category_ID) references Table_product_Category  (product_Category_ID),
ProductID int foreign key(ProductID)references Table_product (ProductID),
Residentials_TYpe_ID int , 
Invoice_Date Datetime , 
Quantity Decimal , 
price Decimal , 
CGST Decimal , 
SGST decimal , 
IGST DECIMAL , 
CGST_value decimal , 
SGST_Value decimal ,
IGST_value decimal ,
TotalAmount decimal )


insert into TableProductGSTDetails values ( 1 , 'Jeans' , 1001 , 1002 ,100 ) ,
                                          ( 2 , 'T-Shirt' , 1003 , 1004 ,90 ), 
										  ( 3 , 'Mouse' , 1005 , 1006 ,80 ) ,
										  ( 4 , 'KeyBoard' , 1007 , 1008 ,70 )

									 

insert into Table_product_Category values ( 11 , 'Beanch' , 1 ),
                                          ( 12 , 'PEN' , 2 ),
										  ( 13 , 'Ladder' , 3 ),
										  ( 14 , 'Shoes' , 4 )
										  


insert into Table_product values ( 101 , 31 , 'Lappy'),
                                 ( 102 , 32 , 'Monitor'),
					     		 ( 103 , 33 , 'Cpu'),
								 ( 104 , 34 , 'Board')
								


insert into TableInvoiceDetails values 
( 21 , 'Sujit' , '8485' , 11  , 101 , 41 , '2023-11-02' , 6 , 1001 , 51 , 91 , 81 , 71 , 100 , 112 , 1000),
( 22 , 'Chandu', '8485' , 12  , 102 , 42 , '2023-11-03' , 6 , 1002 , 52 , 92 , 82 , 72 , 101 , 113 , 2000),
( 23 , 'devid' , '8486' , 13  , 103 , 43 , '2023-11-03' , 7 , 1003 , 53 , 93 , 83 , 73 , 102 , 114 , 3000),
( 24 , 'mujit' , '8484' , 14  , 104 , 44 , '2023-11-04' , 8 , 1004 , 54 , 94 , 83 , 74 , 103 , 115 , 4000)


select * from TableProductGSTDetails
select * from Table_product_Category
select * from Table_product
select * from TableInvoiceDetails