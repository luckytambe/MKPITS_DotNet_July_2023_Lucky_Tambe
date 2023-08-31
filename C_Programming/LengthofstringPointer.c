#include<stdio.h>
int main()
{
	int i=0;
	char s[30],*ptr;
	printf("Enter character : ");
	gets(s);
	ptr=s;
	while(*ptr !='\0')
	{
         i++;
		*ptr++;
	}
	printf("string is=%d",i);
}
