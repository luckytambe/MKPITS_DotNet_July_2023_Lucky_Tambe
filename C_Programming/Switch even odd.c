#include <stdio.h>
int main()
{
    int num;
    printf("Enter an integer: ");
    scanf("%d", &num);

    
    switch(num % 2 == 0)
   {
   	  case 1:
        printf("%d is even.",&num);
        break;
        
     case 2:
        printf("%d is odd.",&num);
        break;
        
     default:
        printf("error");
        break;
   }
}
    
 
