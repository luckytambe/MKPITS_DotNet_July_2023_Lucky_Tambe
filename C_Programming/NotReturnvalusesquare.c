#include<stdio.h>
void square()
{
	int result=num*num;
	printf("area=%d",result);
	
}
 void main()
 {
 	int num,result=0;
 	printf("Area of square : ");
 	scanf("%d",&num);
 	square(num);
 	printf("close \n");
 }

