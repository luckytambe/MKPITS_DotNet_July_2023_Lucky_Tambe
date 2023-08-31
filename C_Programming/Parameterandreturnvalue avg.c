//function with parameter and return value
#include<stdio.h>
int average(float n1,float n2,float n3,float n4,float n5,float add)
{ 
	float avg=add/5;
	return avg;
}
void main()
{
	float n1,n2,n3,n4,n5,add,avg;
	printf("enter five num");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("Average is = %f\n",add);
	avg=average(n1,n2,n3,n4,n5,add);
	printf("Average is = %f\n",avg);
}

