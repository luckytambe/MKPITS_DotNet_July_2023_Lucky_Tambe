#include<iostream>
using namespace std;
class person
{
	public :
	string empna;
	int empco;
	void get_person_deta( string n, int c)
	{
	  empna=n;
	  empco=c;
    }
};
class employe : public person
{
	public :
	int id;
	int salary;
	void get_employe_deta( int i, int s)
	{
    	id=i;
    	salary=s;
    } 
    void display ()
    {
    	cout<<"empna"<<empna<<endl;
    	cout<<"empco"<<empco<<endl;
    	cout<<"id"<<id<<endl;
    	cout<<"salary"<<salary<<endl;
	}
};
int main()
{
	string nm;
	int empcon,eid,esalary;
	cout<<"enter employe details";
	cin>>nm>>empcon>>eid>>esalary;
	employe e1;
	e1.get_person_deta( nm , empcon );
	e1.get_employe_deta( eid , esalary);
	e1.display();
	return 0;
}
