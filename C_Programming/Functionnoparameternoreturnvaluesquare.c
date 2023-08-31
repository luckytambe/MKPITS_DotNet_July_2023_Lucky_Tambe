#include<stdio.h>
int square()
{
	int num;
	printf("enetr num");
	scanf("%d",&num);
	int result=num*num;
	printf("result is %d",result);
}
void main()
{
	int result=0,num;
	square(result,num);
}
