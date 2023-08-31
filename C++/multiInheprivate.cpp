#include<iostream>
using namespace std;
class ability
{
	private :
	string abilityname;
	public :
	void abname(string na)
	{
		abilityname=na;
	}
	void display()
	{
		cout<<"abilityname ="<<abilityname<<endl;
	}
};
class equipment 
{
	private :
	string equipmentname;
	public :
		void eqname(string eq)
		{
			equipmentname=eq;
		}
		void display()
		{
			cout<<"equipmentname ="<<equipmentname<<endl;
		}
};
class character:public ability,public equipment
{
	private :
	string charactername;
	public :
	void getcharactername(string chn,string na,string eq)
	{
		charactername=chn;
		abname(na);
		eqname(eq);
	}
	void display()
	{
		cout<<"charactername ="<<charactername<<endl;
		ability::display();
		equipment::display();
	}
};
int main()
{
	character c1;
	c1.getcharactername("allian","attct","gun");
	c1.display();
	return 0;
}
