#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[3];
	marks[0]=99;
	marks[1]=88;
	marks[2]=87;
	for(i=0;i<3;i++)
	{
		printf("marks =%d\n ",marks[i]);
		sum=sum+marks[i];
	}
	printf("totle is =%d ",sum);
}
