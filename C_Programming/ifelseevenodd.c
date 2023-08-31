#include<stdio.h>
int main()
{
    int num;
    printf("enter the num : ");
    scanf("%d",&num);
    if(num%2==0)
    {
        printf("%d it is even : ",num);
    }
    else
    {
        printf("%d it is odd : ",num);
    }
}
