#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[3]={98,88,87};
	for(i=0;i<3;i++)
	{
		printf("marks is = %d",marks[i]);
		sum=sum+marks[i];
	}
	printf("total is =%d",sum);
}
