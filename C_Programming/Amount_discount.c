#include <stdio.h>
void main()
{
	char customer_name[10],product_name[10];
	int price,quantity,total_amount,discount;
	printf("enter customer_name:");
	scanf("%s",&customer_name);
	printf("product_name:");
	scanf("%s",&product_name);
	printf("price:");
	scanf("%d",&price);
	printf("quantity:");
	scanf("%d",&quantity);
	
    total_amount=price*quantity;
    if(total_amount>=1000)
    {
    	discount=total_amount*0.04;
	}
	else if( total_amount=500)
	{
		discount=total_amount*0.025;
	}
	
	else 
	{
		discount=total_amount*0.10;
	}
	
	printf("customer name;=%s",customer_name);
	printf("\nproduct name=%s",product_name);
	printf("\nprice=%d",price);
	printf("\nquantity=%d",quantity);
	printf("\ndiscount=%d",discount);
	total_amount=total_amount-discount;
	printf("\ntotal_amount=%d",total_amount);
}
