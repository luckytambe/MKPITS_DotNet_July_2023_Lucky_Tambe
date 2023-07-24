#include<stdio.h>
int main()
{
	int num;
	printf("enter the num");
	scanf("%d",&num);
//	printf("%d",num);
	if(num<0)
	{
	  printf("num is negative");
	}
    else if(num==0)
    {
      printf("num is equal to 0");
	}
	else
	{
	  printf("num is positive");
	}
	return 0;
}
