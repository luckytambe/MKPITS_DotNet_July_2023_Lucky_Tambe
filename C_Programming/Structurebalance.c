#include<stdio.h>
#include<string.h>
struct bank
{
	char name[20];
	int acnt,bal;
};
void main()
{
	struct bank b1[3];
	int counter;
	for(counter=0;counter<3;counter++)
	{
		printf("Name and Account no and Balance :");
		scanf("%s%d%d",&b1[counter].name,&b1[counter].acnt,&b1[counter].bal);
		
	}
	printf("\nAccount with balance minimum less than 100");
	for(counter=0;counter<3;counter++)
	{
		if(b1[counter].bal<100)
		{
			printf("\nname=%s, balance=%d",b1[counter].name,b1[counter].bal);
		}
	}
}
//1.Start
//2.Create struct bank
//3.Declare int acnt,bal,char name
//4.Create void main
//5.Declare counter
//6.Check for loop counter=0 or counter<3
//7.print "name,account no,balance"from user
//8.Check for loop counter=0 or counter<3
//9.Check if (balance<100)
//10.print "name,bal"
//11.Stop
