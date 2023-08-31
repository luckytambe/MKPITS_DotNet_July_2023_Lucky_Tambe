#include<stdio.h>
#include<conio.h>
int main()
{
	char na[50],co[50];
	printf("enter character : ");
	gets(na);
	stringcopy(&na,&co);
	printf("character is %s",co);
	
	getch ();
}
void stringcopy(char *a, char *b)
{
	int i;
	for(i=0;*a!=NULL;i++)
	{
		*b++=*a++;
	}
	*b++=NULL;
}
