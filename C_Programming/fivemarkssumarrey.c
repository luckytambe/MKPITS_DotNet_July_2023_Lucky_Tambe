#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[5];
	for(i=0;i<5;i++)
	{
		printf("Enter marks : ");
		scanf("%d",&marks[i]);
	}
	
	for(i=1;i=5;i++)
	{
		
		printf("marks is = %d\n",marks[i]);
		sum=sum+marks[i];
	}
	printf("total is =%d",sum);
	
}
