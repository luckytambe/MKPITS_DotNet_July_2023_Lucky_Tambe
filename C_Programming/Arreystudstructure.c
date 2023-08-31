#include<stdio.h>
#include<string.h>
struct student
{
	int rolln;
	char name[50];
};
void main()
{
	struct student stud[5];
	int i;
	for(i=0;i<5;i++)
	{
		printf("enter rolln & num :");
		scanf("%d",&stud[i].rolln);
		scanf("%s",&stud[i].name);
	}
	printf("student detail");
	for(i=0;i<5;i++)
	{
		printf("\n rolln = %d",stud[i].rolln);
		printf("\n name = %s",stud[i].name);
	}
	
}
