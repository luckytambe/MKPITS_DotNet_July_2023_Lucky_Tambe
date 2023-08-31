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
	strcpy(b1.title,"dotnet");
	strcpy(b1.auther,"lucky");
	b1.bookid=123;
	printf("title=%s\n",b1.title);
	printf("auther=%s\n",b1.auther);
	printf("bookid=%d\n",b1.bookid);
}
