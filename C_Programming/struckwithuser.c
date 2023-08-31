#include<string.h>
#include<stdio.h>
struct book
{
	char title[50];
	char auther[50];
	int bookid;
};
void main()
{
	struct book b1;
	printf("enter title,auther,bookid : ");
	scanf("%s",&b1.title);
	scanf("%s",&b1.auther);
	scanf("%s",&b1.bookid);
	printf("title=%s\n",b1.title);
	printf("auther=%s\n",b1.auther);
	printf("bookid=%d\n",b1.bookid);
}

