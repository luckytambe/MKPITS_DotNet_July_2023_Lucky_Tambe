#include<iostream>
using namespace std;
class account 
{
	public:
	int accno;
	int bal;
	static float roi;
	account (int accno,int bal)
	{
		this->accno=accno;
		this->bal=bal;
	}
	void display()
	{
		cout<<"accno ="<<accno<<endl;
		cout<<"bal= "<<bal<<endl;
		cout<<"rate of in= "<<roi<<endl;
	}
}; 

    float account::roi=9.7f;
	int main()
	{
		account a1 = account (123,2000);
		account a2 = account (456,5000);
		account a3 = account (789,8000);
		a1.display();
		a2.display();
		a3.display();
		return 0;
	}

