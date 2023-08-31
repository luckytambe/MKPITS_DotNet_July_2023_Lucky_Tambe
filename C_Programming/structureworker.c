#include<stdio.h>
#include<string.h>
struct workers
{
	char name[50];
	int wage,workday,salary;
};
void main()
{
   struct workers work[2];
   int counter,salary,wage,workday;
   for(counter=0;counter<2;counter++)
   {
	printf("Enter workers name ,daily wage and workdays : ");
	scanf("%s",&work[counter].name);
	scanf("%d",&work[counter].wage);
	scanf("%d",&work[counter].workday);
   }
   printf("\nworker details");
   for(counter=0;counter<2;counter++)
   {
	  work[counter].salary=work[counter].wage*work[counter].workday;
   }
    for(counter=0;counter<2;counter++)
    {
    	printf("\ntotal salary=%d",work[counter].salary);
	}

}
