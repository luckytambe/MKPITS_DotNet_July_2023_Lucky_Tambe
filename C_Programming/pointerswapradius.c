#include<stdio.h>
int calculate(int r, float *a, float *c)
{
	*a=3.14f*r*r;
	*c=2*3.14*r;
	
}
void main()
{
	float radius,area,circumference;
	printf("enter radius : ");
	scanf("%f",&radius);
	calculate(radius,&area,&circumference);
	printf("area is =%f\n",area);
	printf("circumference of circle =%f\n",circumference);
	
}
