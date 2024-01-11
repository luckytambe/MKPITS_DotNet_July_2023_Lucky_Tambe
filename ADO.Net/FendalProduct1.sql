
Create Table TableProductGSTDetails ( Product_GST_ID int Primary Key ,
                                      Gst_Detail_Name Varchar(500) ,
									  CGST Decimal , 
									  SGST Decimal , 
									  IGST Decimal )

Create Table TableProductCategory( Product_Category_ID int Primary key ,
                                    Product_Type_Name Varchar (500) ,
                                    Product_Gst_ID Int Foreign key (Product_Gst_ID) References TableProductGSTDetails (Product_GST_ID) )

Create Table Product ( ProductID int Primary Key ,
                       ProductName Varchar(500) ,
                       Product_Category_ID int Foreign key (Product_Category_ID) References TableProductCategory (Product_Category_ID), 
					   Product_Price int 
                       )


Create Table TableINvoiceDetails ( Invoice_Details_ID int ,
                                 Customer_Name Varchar(500),
								 Customer_Contact Varchar(15),
								 Product_Category_ID int Foreign Key (Product_Category_ID) References TableProductCategory ,
								 ProductID int Foreign Key (ProductID) References Product ,
								 Residential_Type_ID int ,
								 Invoice_Date DateTime , 
								 Quantity Decimal ,
								 Price Decimal , 
								 CGST Decimal,
								 SGST Decimal,
								 CGST_Value Decimal,
								 SGST_Value Decimal,
								 IGST_Value Decimal,
								 Total_Amount Decimal )

Insert into TableProductCategory Values ( 1001 , 'Computers' , 602),
                                        ( 1002 , 'Mobile' , 604 ),
										(1003 , 'Printers' , 603),
										(1004 , 'Ac And Fridge' , 601)


Insert into Product Values (210 , 'Apple' , 1002 , 40000),
                           (211 , 'Lenevo' , 1002 , 25000),
						   (212 , 'Samsung', 1003 , 50000),
						   (213 , 'IFB' , 1004 , 20000),
						   (214 , 'LG' , 1004 , 52410),
						   (215 , 'Sony' , 1001 , 60000)

Insert into TableProductGSTDetails Values (601,'AC AnD fridge',14,14,4),
                                          (602 , 'Computers' , 9,9,9),
										  (603 ,'Printer' , 8,8,8),
										  (604 , 'Mobile' , 7,7,7)


										

Select * From TableProductCategory
Select * From Product
Select * from TableProductGSTDetails
Select * From TableINvoiceDetails

	
drop table TableProductCategory
drop table Product
drop table TableProductGSTDetails
drop table TableINvoiceDetails