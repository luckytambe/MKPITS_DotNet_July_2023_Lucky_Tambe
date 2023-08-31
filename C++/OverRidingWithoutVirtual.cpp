#include<iostream>
using namespace std;
class account
{
	public:
	int accno;
	int balance;
    void deposite(int amt)
	{
		cout<<"hello to Account"<<endl;
	}
	
};
class saving : public account
{
	public:
	void deposite(int amt)
	{
		int intre=500;
		balance=balance+amt+intre;
		cout<<"with intrest ="<<balance<<endl;
	}
};
class current :public account
{
	public:
	void deposite(int amt)
	{
		balance=balance+amt;
		cout<<"without intrest ="<<balance<<endl;
	}
};
int main()
{
	account *a;
	saving s;
	current c;
	a=&s;
	a->accno=123;
	a->balance=2000;
	a->deposite(500);
	a=&c;
	a->accno=456;
	a->balance=3000;
	a->deposite(500);
	return 0;
}
