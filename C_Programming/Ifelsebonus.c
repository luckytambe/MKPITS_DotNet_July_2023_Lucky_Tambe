#include <stdio.h>
int main()
{
    char name[20];
    int salary,bonus=0;
    printf("enter name");
    scanf("%s",name);
    printf("enter salary");
    scanf("%d",&salary);
    if(salary>=10000)
    {
        bonus=5000;
    }
    else if(salary<10000 && salary>=5000)
    {
        bonus=2000;
    }
    else 
    {
        bonus=1000;
    }
    printf("name=%s\n",name);
    printf("salary=%d\n",salary);
    printf("bonus=%d\n",bonus);
    return 0;
}
