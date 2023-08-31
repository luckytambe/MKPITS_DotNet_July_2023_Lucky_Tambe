#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char op;
	cout<<"enter two num";
	cin>>n1>>n2;
	cout<<"Enter operator (+,-,/,*)";
	cin>>op;
	switch(op)
	{
		case'+':
		sum=n1+n2;
		break;
		case'-':
		sum=n1-n2;
		break;
		case'/':
		sum=n1/n2;
		break;
		case'*':
		sum=n1*n2;
		break;		
		
	}
	cout<<"sum="<<sum;
	return 0;
	
}
