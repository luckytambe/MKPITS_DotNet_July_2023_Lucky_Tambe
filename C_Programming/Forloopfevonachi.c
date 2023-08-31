#include<stdio.h>
void main()
{
	int i;
	int num1=0;
	int num2=1;
	int add=num1+num2;
	printf("%d,%d\n",num1,num2);
 	for(i=3;i<10;i++)
	{
		printf(",%d\n",add);
		num1=num2;
		num2=add;
		add=num1+num2;
	}
}
