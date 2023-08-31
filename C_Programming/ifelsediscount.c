#include<stdio.h>
void main()
{
    char product_name[10],customer_name[10];
    int prize,quantity,total_amount,discount;
    printf("customer_name");
    scanf("%s",&customer_name);
    printf("product_name");
    scanf("%s",&product_name);
    printf("enter prize");
    scanf("%d",&prize);
    printf("enter quantity");
    scanf("%d",&quantity);
    total_amount=prize*quantity;
    if(total_amount>=1000)
    {
        discount=total_amount*0.40;
    }
    else if (total_amount>=500)
    {
        discount=total_amount*0.25;
    }
    else
    {
        discount=total_amount*0.10;
    }
    printf("product_name=%s\n",product_name);
    printf("customer_name=%s\n",customer_name);
    printf("prize=%d\n",prize);
    printf("quantity=%d\n",quantity);
    printf("discount=%d\n",discount);
    total_amount=total_amount-discount;
    printf("total_amount=%d\n",total_amount);
}
