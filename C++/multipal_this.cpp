#include<iostream>
using namespace std;
class person
{
	public :
	string name;
	int number;
	void get_persondeta( string name , int number)
	{
		this -> name=name;
		this -> number=number;
	}
};
class employe : public person
{
	public :
	 int id;
	 int clas;
	void get_employe_deta( int id,int clas)
	{
		this -> id=id;
		this -> clas=clas;
	}
	 
	void display()
	{
	cout<<"name="<<name<<endl;
	cout<<"number="<<number<<endl;
	cout<<"id="<<id<<endl;
	cout<<"clas="<<clas<<endl;
}
};
int main()
{
	employe e1;
	string name;
	int number,id,clas;
	cout<<"enter detail";
	cin>>e1.name>>e1.number>>e1.id>>e1.clas;
	
	e1.get_persondeta( e1.name,e1.number);
	e1.get_employe_deta( e1.id,e1.clas);
	e1.display();
	return 0;
}
