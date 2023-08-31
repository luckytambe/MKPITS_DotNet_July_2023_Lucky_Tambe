#include<stdio.h>
int main()
{
	int arr1[2][2]={{1,2},{5,3}};
	int arr2[2][2]={{5,6},{7,5}};
	int arr3[2][2];
	int row,col;
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			arr3[row][col]=arr2[row][col]-arr1[row][col];
		}
	}
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("%d\t",arr3[row][col]);
		}
		 printf("\n");
	} 
	
}
