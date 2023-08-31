#include<iostream>
using namespace std;
class person
{
	public:
	string empname;
	int empno;
};
class employe : public person
{
	public :
	int empcon;
	int salary;
};
class parttime : public employe
{
   public :
    int hours;	
};
int main()
{
	employe e1;
	e1.empname="akash";
	e1.empno=8485;
	e1.empcon=456;
	e1.salary=12000;
	cout<<"employe details"<<endl;
	cout<<e1.empname<<endl;
	cout<<e1.empno<<endl;
	cout<<e1.empcon<<endl;
	cout<<e1.salary<<endl;
	
	parttime p1;
	p1.empname="sara";
	p1.empno=888;
	p1.empcon=895;
	p1.salary=88888;
	p1.hours=45;
	cout<<"parttime details"<<endl;
	cout<<p1.empname<<endl;
	cout<<p1.empno<<endl;
	cout<<p1.empcon<<endl;
	cout<<p1.salary<<endl;
	cout<<p1.hours<<endl;
	
	return 0;
}
