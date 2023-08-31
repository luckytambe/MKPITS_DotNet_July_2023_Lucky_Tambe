#include<stdio.h>
void main()
{
	int n1=20;
	int n2=30;
	int *p1=&n1;
	int *p2=&n2;
	printf("before swap *p1=%d,*p2=%d\n",*p1,*p2);
	
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("after swap *p1=%d,*p2=%d\n",*p1,*p2);
}
