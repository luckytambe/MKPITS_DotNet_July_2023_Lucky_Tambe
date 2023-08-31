#include<iostream>
using namespace std;
class account
{
	public:
	int accno;
	int balance;
	void deposite(int amt)
	{
		cout<<"hello to deposite";
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
	saving s;
	current c;
	s.accno=123;
	s.balance=2000;
	s.deposite(500);
	c.accno=456;
	c.balance=3000;
	c.deposite(500);
	return 0;
}
