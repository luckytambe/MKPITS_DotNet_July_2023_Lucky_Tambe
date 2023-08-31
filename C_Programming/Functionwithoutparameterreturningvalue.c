#include<stdio.h>
int square()
{
	int num;
	printf("enter num");
	scanf("%d",&num);
	int result=num*num;
	return result;
	
}
void main()
{
	char ch='y';
	do
	{
		int result;
		result=square();
		printf("area of square =%d\n" ,result);
		printf("do you want to contineu :y ");
		fflush(stdin);
		scanf("%c",&ch);
		
	}
	while (ch=='y');
}
