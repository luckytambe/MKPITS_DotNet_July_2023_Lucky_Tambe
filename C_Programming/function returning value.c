#include<stdio.h>

	int addition (int num1, int num2)
	{
		int result=num1+num2;
		return result;
		
	}
	void main()
	{
	
	char ch='y';
	do 
	{
		int num1,num2,result;
		printf("enter two num");
		scanf("%d%d",&num1,&num2);
		result=addition(num1,num2);
		printf("result is %d\n ",result);
		printf("do you want to contineu : y \ n ");
		fflush(stdin);
		scanf("%c",&ch);
	}
	
	while(ch=='y');
	
    }
   
