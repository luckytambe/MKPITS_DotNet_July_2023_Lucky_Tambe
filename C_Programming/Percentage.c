#include <stdio.h>
void main ()
{

   float sub1,sub2,sub3,total,per;
   printf("enter the sub");
   scanf("%f,%f,%f",&sub1,sub2,sub3);
   total=sub1+sub2+sub3;
   per=total/300.0f*100;
   printf("total=%f\n",total);
   printf("per=%f",per);
    
}
