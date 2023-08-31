#include<stdio.h>
int square(int num)
{
	int result=num*num;
	return result;
	
}
void main()
{
	char ch='y';
	do 
	{
		int num,result;
		printf ("Area of square : ");
		scanf("%d",&num);
		result=square(num);
		printf("%d is result \n ",result);
		printf("do you want to contineu : y\n");
		fflush(stdin);
		scanf("%c",&ch);
		
	}
	while (ch=='y');
}
