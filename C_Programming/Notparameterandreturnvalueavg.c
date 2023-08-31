// function not parameter and return value 
#include<stdio.h>
int average()
{
	float n1,n2,n3,n4,n5,add;
	float avg;
	printf("Enter the num : ");
	scanf("%d%d%d%d%d",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("addi is = %f\n",add);
	avg=add/5;
	return avg;
}
void main()
{
	float avg;
	avg=average();
	printf("addi is = %f\n",avg);
}

