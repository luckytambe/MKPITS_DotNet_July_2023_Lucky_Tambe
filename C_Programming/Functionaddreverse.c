#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("addition of two num = %d",result);
	
}
void main()
{
	char ch='y';
	do
	{
		int n1,n2;
		printf("enter num  : ");
		scanf("%d%d",&n1,&n2);
	    addition(n1,n2);
	    printf("\n do you want to contineu, press y ; ");
	    fflush(stdin);
	    scanf("%c",&ch);
	    	
	}
	while(ch=='y');
}
