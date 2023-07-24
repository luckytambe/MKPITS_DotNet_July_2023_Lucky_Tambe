#include <stdio.h>
int main()
{
	int day_no;
	printf("enter day_no");
	scanf("%d",&day_no);
	switch(day_no)
	
{	
    case 1:
	printf("monday");
	break;
		
	case 2:
	printf("tuesday");
	break;
		
	case 3:
	printf("wed");
	break;
	
	case 4:
	printf("thus");
	break;
	
	case 5:
	printf("fri");
	break;
	
	case 6:
	printf("sat");
	break;
		
	case 7:
	printf("sun");
	break;
		
	default:
	printf("invalid day");
	break;
}
}
