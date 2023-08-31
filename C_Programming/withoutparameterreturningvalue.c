#include<stdio.h>
int addition()
{
	int n1,n2;
	printf("enter two num");
	scanf("%d %d",&n1,&n2);
    int	result=n1+n2;
	return result;
	
}
  void main()
{
	char ch='y';
	do 
	{
		int result;
		result=addition();
		printf("result is %d\n",result);
		printf("do you want contineu value : y\n");
		fflush(stdin);
		scanf("%c",&ch);
			
	}
	while (ch=='y');
}
