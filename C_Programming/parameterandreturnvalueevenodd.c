//function with parameter and return value
#include<stdio.h>
int oddeven(int num,int rem)
{
	if(num%2==0)
	{
		printf("It is a even num");
	}
	else
	{
		printf("It is a odd num");
	}
	return 0;
}
void main()
{
	int rem=0,num;
	printf("Enter num :");
	scanf("%d",&num);
	oddeven(num,rem);
}
