#include <stdio.h>
void main()
{
	int month;
	printf("enter the month");
	scanf("%d",&month);
	switch(month)
	
	{
		case 1:
		printf("31_days");
		break;
		
		case 2:
		printf("28/29_days");
		break;
		
		case 3:
		printf("30_days");
		break;
		
		case 4:
		printf("31_days");
		break;
		
		case 5:
		printf("30_days");
		break;
		
		case 6:
		printf("31_days");
		break;
		
		case 7:
		printf("30d_days");
		break;
		
		case 8:
		printf("30_days");
		break;
		
		case 9:
		printf("30_days");
		break;
		
		case 10:
		printf("31_days");
		break;
		
		case 11:
		printf("30_days");
		break;
		
		case 12:
		printf("30_days");
		break;
		
		default:
		printf("invalid_days");
		
	   		
	}
	return ;
}
