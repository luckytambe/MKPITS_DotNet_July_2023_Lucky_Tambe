#include<iostream>
using namespace std;
class employe
{
	public:
	int no,salary;
	string name,designation;
	void getdeta()
	{
		cout<<"no "<<"salary "<<"name "<"designation ";
		cin>>no>>salary>>name>>designation;
	}
	void displaydeta()
	{
		cout<<"no :"<<no<<endl;
		cout<<"salary :"<<salary<<endl;
		cout<<"name :"<<name<<endl;
		cout<<"designation :"<<designation<<endl;
	}
};
int main()
{
	employe emp1,emp2;
	cout<<"employe1 "<<endl;
	emp1.getdeta();
	emp1.displaydeta();
	cout<<"employe2 "<<endl;
	emp2.getdeta();
	emp2.displaydeta();
	
	return 0;
}
