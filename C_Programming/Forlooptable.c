#include<stdio.h>
void main()
{
	int num;
	int counter;
	int result=0;
	printf("enter the num");
	scanf("%d",&num);
	for(counter=1;counter<=10;counter++)
	
    {   result=num*counter;
    	printf("%d*%d=%d\n",num,counter,result);
	}	
}
