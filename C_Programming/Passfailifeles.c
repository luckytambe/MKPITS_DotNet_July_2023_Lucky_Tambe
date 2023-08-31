#include<stdio.h>
int main()
{
	int marks;
	printf("enter marks : ");
	scanf("%d",&marks);
   
   if(marks<30)
   
   {
   	printf("grade c+\n");
   }
   
   else if(marks >=70  &&  marks<90)
   {
   	printf("grade A\n");
   }
   
   else if(marks >=30 && marks<70)
   {
   	printf("grade B\n");
   }
   
   else 
   {
   	printf("A+ \n");
   }
   return 0;
   
}
