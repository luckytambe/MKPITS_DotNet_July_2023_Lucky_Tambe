#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf(" sum of two num is = %d",result);
}
void main()

{
	int n1,n2;
	printf("Enter two num");
	scanf("%d%d",&n1,&n2);
	addition(n1,n2);
	printf("\n bye");
}

