#include<stdio.h>
#include<string.h>
struct student
{
	int rollno;
	char name[20];
	struct date
	{
		int date;
		int month;
		int year;
	}
	birthdate,addate;
};
void main()
{
	struct student stud[3];
	int counter,result;
	for(counter=0;counter<3;counter++)
	{
		printf("Enter Rollno., Name : ");
		scanf("%d%s",&stud[counter].rollno,&stud[counter].name);
		printf("Enter Birthday : ");
		scanf("%d-%d-%d",&stud[counter].birthdate.date,&stud[counter].birthdate.month,&stud[counter].birthdate.year);
		printf("Addmission Date : ");
		scanf("%d-%d-%d",&stud[counter].addate.date,&stud[counter].addate.month,&stud[counter].addate.year);
	}
	for(counter=0;counter<3;counter++)
	{
		result=stud[counter].addate.year - stud[counter].birthdate.year;
		printf("\nAge of student at the time of addmission : ");
		printf("\t%d years",result);
	}
}
