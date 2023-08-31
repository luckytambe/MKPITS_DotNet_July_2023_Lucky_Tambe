#include<stdio.h>
void main()
{
	int temp;
	int n1=10;
	int n2=20;
	int *p1=&n1;
	int *p2=&n2;
	
	printf("before swap *p1=%d,*p2=%d \n ",*p1,*p2);
	temp=*p1;
	*p1=*p2;
	*p2=temp;
	printf("after swap *p1=%d,*p2=%d \n ",*p1,*p2);
	
}
