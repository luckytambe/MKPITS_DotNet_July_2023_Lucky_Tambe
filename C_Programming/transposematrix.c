#include<stdio.h>
void main()
{
	int row,col;
	int arr1[2][2];
	int arr2[2][2];
	printf("Enter matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr1[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr2[row][col]=arr1[col][row];
		}
	}
	printf("Transpose of matrices\n");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("%d\t",arr2[row][col]);
		}
		printf("\n");
	}
}
