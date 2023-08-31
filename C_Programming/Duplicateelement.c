#include<stdio.h>
void main()
{
	int i,count=0;
	int arr[5];
	int j;
	for(i=0;i<5;i++)
	{
		printf("Enter num : ");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if (arr[i]==arr[j])
			{
				count++;
				break;
			}
		}
	}
	printf("\n duplicate of arr = %d",count);
}
