#include<iostream>
using namespace std;
class employe
{
	public:
	int empno;
	string employename;
	employe(int en,string ename)
	{
		empno=en;
		employename=ename;
	}
	void display()
	{
		cout<<"empno = "<<empno<<endl;
		cout<<"employename = "<<employename<<endl;
	}
	
};
int main()
{
	int en;
	string ename;
	cout<<"empno and employename ";
	
	cin>>en>>ename;
	employe e1(en,ename);
	e1.display();
	return 0;
}
