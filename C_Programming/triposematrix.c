#include<stdio.h>
int main()
{
	int arr1[2][2]={{4,5},{7,8}};
	int arr2[2][2]={{1,3},{2,9}};
	int arr3[2][2];
	int row,col;
	for(row=0,row<3,row++)
	{
		for(col=0;col<3;col++)
		{
			arr3=(arr1=arr2);
		}
		
	}
	for(row=0,row<3,row++)
    {
    	for(col=0;col<3;col++)
    	{
    		printf("%d\t",arr[row][col]);
		}
	}
	printf("\n");
}
