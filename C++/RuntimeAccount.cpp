#include<iostream>
using namespace std;
class Account
{
	public:
	int accno;
	int bal;
	virtual void deposite(int amt)
	{
		cout<<"accno="<<accno<<endl;
		cout<<"from acc deposite"<<endl;
	}
};
class saving : public Account 
{
	public:
	void deposite(int amt)
	{
		int intrest=500;
		bal=bal+amt+intrest;
		cout<<"intrest with balance"<<bal<<endl;
	}
};
class current : public Account
{
	public :
	void deposite(int amt)
	{
		bal=bal+amt;
		cout<<"without intrest with bal"<<bal<<endl;
	}
};
int main()
{
	Account *A;
	saving s;
	current c;
	A=&s;
	A->accno=123;
	A->bal=1000;
	A->deposite(2000);
	A=&c;
	A->accno=456;
	A->bal=2000;
	A->deposite(3000);
	return 0;
}
