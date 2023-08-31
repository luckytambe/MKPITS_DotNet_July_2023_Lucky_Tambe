#include<stdio.h>
void main()
{
	int n,i,num[100];
	printf("enter n ");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("enter num");
		scanf("%d",&num[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\n revers is= %d",num[i]);
	}
}
