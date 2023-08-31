//function with parameter and not return value
#include<stdio.h>
void oddeven(int num,int rem)
{
	if(num%2==0)
	{
		printf("It is a even num");
	}
	else
	{
		printf("It is a odd num");
	}
}
void main()
{
	int rem=0,num;
	printf("Enter num :");
	scanf("%d",&num);
	oddeven(num,rem);
}
