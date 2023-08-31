#include<iostream>
using namespace std;
class company
{
	public :
	string name;
	string desi;
};
class employe : public company
{
	public :
	int no;
	int sal;
};
int main()
{
	employe e1,e2;
	e1.name="akash";
	e1.desi="sr maneger";
	e1.no=485;
	e1.sal=5000;
	
	e2.name="sarang";
	e2.desi="maneger";
	e2.no=459;
	e2.sal=4000;
	
	cout<<e1.name<<endl;
	cout<<e1.desi<<endl;
	cout<<e1.no<<endl;
	cout<<e1.sal<<endl;
	
    cout<<e2.name<<endl;
	cout<<e2.desi<<endl;
	cout<<e2.no<<endl;
	cout<<e2.sal<<endl;
	
	return 0;
	
}
