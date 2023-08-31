#include<stdio.h>
int main()
{
	int arr1[3][3]={{1,2,5},{5,3,5}};
	int arr2[3][3]={{5,6,9},{7,5,8}};
	int arr3[3][3];
	int row,col;
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			arr3[row][col]=arr1[row][col]*arr2[row][col];
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
