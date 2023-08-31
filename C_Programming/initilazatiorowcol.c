#include<stdio.h>
void main()
{
	int arr[2][2]={{5,1},{2,3}};
	int row,col;
	{
		for (row=0;row<2;row++)
		{
			for(col=0;col<2;col++)
			{
				
			  printf("arr[%d][%d]=[%d]\n",row,col,arr[row][col]);
			}
		}
	}
}
