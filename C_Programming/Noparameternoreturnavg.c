// function not parameter and not returning value or avrage
#include<stdio.h>
void average()
{
	int n1,n2,n3,n4,n5;
	printf("Enter the num : ");
	scanf("%d%d%d%d%d",&n1,&n2,&n3,&n4,&n5);
	int add=n1+n2+n3+n4+n5;
	printf("addi is = %d\n",add);
	int avg=add/5;
	printf("Average is = %d\n",avg);
}
void main()
{
	int n1,n2,n3,n4,n5,add,avg;
	average(n1,n2,n3,n4,n5,avg,add);
}
