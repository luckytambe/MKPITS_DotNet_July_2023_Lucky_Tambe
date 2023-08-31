#include<stdio.h>
#include<string.h>
struct book 
{
	char title[50];
	char authoer[50];
	int bookid;
};
void printbook(struct book*ptr);
void main()
{    
    struct book b1;
	printf("enter title,authoer,bookid : ");
	scanf("%s",b1.title);
	scanf("%s",b1.authoer);
	scanf("%d",&b1.bookid);
	printbook(&b1);
}
void printbook(struct book*ptr)
{
	
	printf("title=%s\n",ptr->title);
	printf("authoer=%s\n",ptr->authoer);
	printf("bookid=%d\n",ptr->bookid);
	
}
