#include <stdio.h>

int main()
{
    int num;
    printf("enter num\n");
    scanf("%d",&num);

    switch (num % 2)
    {
        case 0:
        printf("it is even= %d\n",num);
        break;
        case 1:
        printf("it is odd = %d\n",num);
        break;
        return 0;
    }
}
