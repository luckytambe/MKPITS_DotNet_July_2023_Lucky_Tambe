#include<stdio.h>
int main()
{
	char num;
	printf("enter num : ");
	scanf("%d",&num);
	
	if (num >= 0)
	{
	 
		 printf("positive\n");
		 if (num %2 ==0)
		 {
		 	printf("even num\n");
		 	
		 }
		 else
		 {
		 	printf("odd num\n");
		 }
	 
	}
	else 
	{
		 printf("negative\n");
		 		
	}
	
	return 0;
}
