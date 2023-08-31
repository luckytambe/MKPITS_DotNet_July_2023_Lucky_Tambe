#include<stdio.h>
void main()

{
	int num;
	int counter=2;
	int rem=0;
	for(num=3;num<=20;num++)
	{   
	    counter=2;
		while(counter<num)
		{
			rem=num%counter;
		    if(rem==0)
		   {
			  break;
	       }
		    counter++;
		}
	    if(num==counter)
	    {
	    	printf("% dit is prime\n ",num);
		}
    }
}
