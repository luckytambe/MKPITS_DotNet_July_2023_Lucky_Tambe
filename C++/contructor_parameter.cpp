#include<iostream>
using namespace std;
class employe
{
	public:
	int empno;
	string empname;
	employe(int en,string ename)
	{
		empno=en;
		empname=ename;
	}
	void display()
	{
		cout<<"empno ="<<empno<<endl;
		cout<<"empname ="<<empname<<endl;
	}
};
int main()
{
	int en;
	string ename;
	employe  e1(11,"akash");
	e1.display();
	return 0;
}
