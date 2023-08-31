#include<iostream>
using namespace std;
class account 
{
	public:
	int accno;
	int bal;
	virtual void deposite(int amt )=0;
};
class saving : public account
{
	public:
	void deposite(int amt)
	{
		int intr=500;
		bal=bal+amt+intr;
		cout<<"with intrest ="<<bal<<endl;
	}
};
class current : public account 
{
	public :
		void deposite (int amt)
		{
			bal =bal+amt;
			cout<<"without intrest ="<<bal<<endl;
			
		}
 } ;
 int main()
 {
 	account *a;
 	saving s;
 	a=&s;
 	a->accno=123;
 	a->bal=5000;
 	a->deposite(500);
 	
 	current c;
 	a=&c;
 	a->accno=456;
 	a->bal=2000;
 	a->deposite(500);
 	return 0;
 }
