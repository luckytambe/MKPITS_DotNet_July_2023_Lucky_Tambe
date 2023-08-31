#include<stdio.h>
int main()
{
	int i;
	int rev=0;
	char name[50];
	printf("Enter character : ");
	gets(name);
	while(name[rev]!='\0')
	{
		rev++;
	}
	i=rev-1;
	while(i>=0)
	{
		printf("%c",name[i]);
		i--;
	}
}
