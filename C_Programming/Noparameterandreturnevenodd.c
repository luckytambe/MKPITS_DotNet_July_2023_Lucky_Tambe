//function with no parameter and no return 
#include<stdio.h>
void oddeven()
{
	int num,rem=0;
	printf("Enter num :");
	scanf("%d",&num);
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
	int num,rem=0;
	oddeven(num,rem);
}
