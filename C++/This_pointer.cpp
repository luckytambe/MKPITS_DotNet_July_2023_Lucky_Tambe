#include<iostream>
using namespace std;
class employe
{
	public:
	int employeno;
	string empname;
	employe(int employeno,string empname)
	{
		this -> employeno = employeno;
		this -> empname = empname;
	}
	void display()
	{
		cout<<employeno<<empname;
	}
};
int main()
{
	employe e1(  123   , " ohhh yeah");
	e1.display();
	return 0;
}
