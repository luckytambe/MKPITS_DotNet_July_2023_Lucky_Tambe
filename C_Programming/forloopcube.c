#include<stdio.h>
void main()
{
	int i;
	int num;
	int cube;
	printf("enter num");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n %d is a cube %d",i,cube,num);
	}
}
