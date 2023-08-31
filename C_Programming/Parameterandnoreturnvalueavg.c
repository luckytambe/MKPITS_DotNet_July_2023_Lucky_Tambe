// function with parameter and no return value
#include<stdio.h>
void average(int n1,int n2,int n3,int n4,int n5)
{
	int add=n1+n2+n3+n4+n5;
    printf("addition is =%d\n",add);
	int avg=add/5;
	printf("average is =%d\n",avg);
}
void main()
{
	int n1,n2,n3,n4,n5;
	printf("enter num");
	scanf("%d%d%d%d%d",&n1,&n2,&n3,&n4,&n5);
	average(n1,n2,n3,n4,n5);
}

