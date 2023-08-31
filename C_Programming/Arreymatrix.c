#include<stdio.h>
void main()
{
	int arr[2][2];
	int row,col;
	int n1,n2;
	printf("enter num : ");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		n1=n2=0;
	    for(col=0;col<2;col++)
	    {
	    	n1=n1+arr[row][col];
	    	n1=n2+arr[col][row];
		}
		
		printf("sum row=%d\n",n1);
		printf("column sum=%d\n",n2);
		
	}
}
