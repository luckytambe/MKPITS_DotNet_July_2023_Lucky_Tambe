#include <stdio.h>
void main ()
{

    float basic,hra,da,tottle_sallery;
    printf("enter the hra");
    scanf("%f",&basic);
    hra=basic*0.35f;
    da=basic*0.45;
    tottle_sallery=hra*da*basic;
    printf("hra=%f\n",hra);
    printf("da=%f\n",da);
    printf("basic=%f\n",tottle_sallery);
    
    
}
