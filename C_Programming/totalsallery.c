#include<stdio.h>
int main()
{
    float hra,da,basic,total;
    printf("enter hra : ");
    scanf("%f",&basic);
    hra=basic+0.35;
    da=basic+0.45;
    total=hra+da+basic;
    printf("hra=%f\n",hra);
    printf("da=%f\n",da);
    printf("basic=%f\n",total);
}
