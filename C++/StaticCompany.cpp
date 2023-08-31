#include<iostream>
using namespace std;
class employe
{
	public:
	int empno;
	string empna;
	static string comna;
	employe (int empno, string empna)
	{
		this ->empno=empno;
		this ->empna=empna;
	}
	void display()
	{
		cout<<"empno = "<<empno<<endl;
		cout<<"empna ="<<empna<<endl;
		cout<<"comna ="<<comna<<endl;
	}
};
   string employe ::comna="rockers";
   int main()
{
	employe e1= employe(1,"akash");
	employe e2=employe(2,"sarang");
	e1.display();
	e2.display();
	return 0;	
}
