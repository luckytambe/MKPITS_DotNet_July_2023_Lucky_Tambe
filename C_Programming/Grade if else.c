#include <stdio.h>
int main ()
{
	int m1,m2,m3,total;
	float per;
	printf("enter the subject marks");
	scanf("%d%d%d",&m1,&m2,&m3);
	total=m1+m2+m3;
	printf("tottle=%d\n",total);
	per=(total/300.0f)*100.0f;
	printf("per=%f\n",per);
	if (per>=75)
	{
		printf("grade=topper");
	}
	else if(per>=60 && per<75)
	{
		printf("\n grade=first");
	}
	else if (per>=50 && per<60)
	{
		printf("\ngrade=second");
	}
	else
	{
		printf("fail");
	}
}
