#include <stdio.h>

void main()
{
    int counter=10;
    int sum=0;
    while(counter<=20)
    {
        sum=sum+counter;
        counter=counter+1;
    }
    printf("sum=%d",sum);
}

