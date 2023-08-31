#include<stdio.h>
void main()
{
	int i,num,rem,sum=0;
	printf("enter num");
	scanf("%d",&num);
	for(i=num;num!=0;num=num/10)
	{
		rem=num%10;
		sum=sum+(rem*rem*rem);
	}
	if(sum==i)
	{
		printf("%d is amstrong");
		
	}
	else
	{
		printf("%d is not amstrong ",i);
	}
}

