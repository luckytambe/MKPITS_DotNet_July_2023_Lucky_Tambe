#include<stdio.h>
void main()
{
    char name[10];
    int salary,bonus=0;
    printf("enter name");
    scanf("%s",&name);
    printf("enter the salary");
    scanf("%d",&salary);
    if(salary>=10000)
    {
   	   bonus=5000;
    }
    else if(salary>=5000 && salary<10000)
    {
   	   bonus=2000;
    }
    else 
    {
       bonus=1000;
    }
    printf ("employer name=%s",name);
    printf("\n salary =%d",salary);
    printf("\n bonus=%d",bonus);
}
