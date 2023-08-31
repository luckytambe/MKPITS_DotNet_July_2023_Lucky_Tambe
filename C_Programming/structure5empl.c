#include<stdio.h>
#include<string.h>
struct employee
{
	char name[50];
	char desi[50];
	char dep[50];
	int sal;
	int empid;
	
};
void main()
{
	struct employee emp[2];
	int counter;
	for(counter=0;counter<2;counter++)
	{
		printf("enter  emp id , name, desi , dep , sal , : ");
		scanf("%d",&emp[counter].empid);
		scanf("%s",&emp[counter].name);
		scanf("%s",&emp[counter].desi);
		scanf("%s",&emp[counter].dep);
		scanf("%d",&emp[counter].sal);
	}
	printf("enter emp detail ;\n ");
	for(counter=0;counter<2;counter++)
	{
		printf("\n%d=emp\t",emp[counter].empid);
		printf("\n%s=name\t",emp[counter].name);
		printf("\n%s=desi\t",emp[counter].desi);
		printf("\n%s=dep\t",emp[counter].dep);
		printf("\n%d=sal\t",emp[counter].sal);
		
	}
}
