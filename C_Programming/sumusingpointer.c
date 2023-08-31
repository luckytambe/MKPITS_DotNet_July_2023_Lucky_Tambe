#include<stdio.h>
int main()
{
	int *x,*y,b,c,sum;
	printf("enter num : ");
	scanf("%d%d",&b,&c);
	x=&b;
	y=&c;
	sum=*x+*y;
	{
		printf("Enter two num = %d\n ",sum);
	}
}
