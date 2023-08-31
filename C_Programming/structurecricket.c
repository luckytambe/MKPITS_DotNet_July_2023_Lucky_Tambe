#include <stdio.h>
#include<string.h>
struct cricket
{
    char name [20];
    int run; 
};
   void main()
  {
   struct cricket cric[11];
   int i;
   int total=0;
   for(i=0;i<11;i++)
   {
    printf("Enter player name and run : ");
    scanf("%s",&cric[i].name);
    scanf("%d",&cric[i].run);
    }
    for(i=0;i<11;i++)
    {
        total=total+cric[i].run;
    }
    printf("total score run on team=%d",total);
    
}
