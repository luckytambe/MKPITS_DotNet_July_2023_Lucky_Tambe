#include <stdio.h>
void main()
{
	char name[20];
	char designation;
	int salary;
	printf("enter emplyname");
	scanf("%s",&name);
	fflush(stdin);
	printf("enter designation(m,c,p)");
	scanf("%c",&designation);
	switch(designation)
	{
	 case'm':
	 salary=50000;
   	 break;
	 
	 case'c':
	 salary=20000;
	 break;
	 	
	 case'p':
	 salary=10000;
	 break;
	 
	 default:
	 printf("invalid");
	 break;
	  
	  
	}
	printf("emplyname=%s",name);
	printf("salary=%d",salary);
}
