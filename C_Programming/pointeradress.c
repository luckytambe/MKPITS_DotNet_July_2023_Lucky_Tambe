#include<stdio.h>
int main()
{
	int num=5;
	int *ptr=&num;
	
    printf("address = %x",ptr);
    
    printf("value of address =%d",*ptr);
}
