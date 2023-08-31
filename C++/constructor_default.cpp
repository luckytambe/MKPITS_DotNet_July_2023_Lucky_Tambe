#include<iostream>
using namespace std;
class employe
{
	public:
	int empno;
	string empname;
	employe()
	{
		empno=1234;
		empname="lucky";
		
	}
	void display()
	{
		cout<<"empno = "<<empno<<endl;
		cout<<"empname = "<<empname<<endl;
	}
};
	int main()
	{
		employe e1;
		e1.display();
		return 0;
	}

