#include<stdio.h>
#include<string.h>
struct book 
{
	char title[50];
	char auther[50];
	int bookid;
};
void printbook(struct book b1);
void main()
{    
    struct book b1;
	printf("enter title,auther,bookid : ");
	scanf("%s",b1.title);
	scanf("%s",b1.auther);
	scanf("%d",&b1.bookid);
	printbook(b1);
}
void printbook(struct book b1)
{
	
	printf("title=%s\n",b1.title);
	printf("auther=%s\n",b1.auther);
	printf("bookid=%d\n",b1.bookid);
	
}
