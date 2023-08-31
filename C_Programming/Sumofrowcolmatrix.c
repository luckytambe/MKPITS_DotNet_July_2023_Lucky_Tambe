#include<stdio.h>
void main()
{
	int row,col,i;
	int arr1[2][2];
	int arr2[2][2];
	printf("Enter first matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr1[row][col]);
		}
	}
	printf("Enter second matrices");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr2[row][col]);
		}
	}
	i=1;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		  if(arr1[row][col]!=arr2[row][col])
		  i=0;
		  break;
		}
	}
	if(i==1)
	{
		printf("\nMatrices are equal");
		
	}
	else
	{
		printf("\nMatrices are not equal");
	}
}
