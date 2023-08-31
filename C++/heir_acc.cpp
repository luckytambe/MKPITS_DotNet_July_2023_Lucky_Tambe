#include<iostream>
using namespace std;
class account
{
	public :
	int acc;
	int bal;
	int intrest;
	void getdata(int a, int b,int c)
	{
	    acc=a;
	    bal=b;
	    intrest=c;
	}
};
class saving : public account 
{
	public :
	
	int deposit(int amt)
	{
		bal=bal+intrest+amt;
		return bal;
	}
};
class current : public account
{
	public :
	int deposit(int amt)
	{
		bal=bal+amt;
		return bal;
	}
};
int main ()
{
	saving s1;
	current c1;
	int result ;
	int acc,bal,intrest,amount;
	cout<<"enter account details";
	cin>>acc>>bal>>intrest>>amount;
	s1.getdata(amount,bal,intrest);
	result=s1.deposit(amount);
	cout<<"saving bal with intrest"<<result<<endl;
	c1.getdata(amount,bal,intrest);
	result=c1.deposit(amount);
	cout<<"current bal"<<result;
	return 0;
}
