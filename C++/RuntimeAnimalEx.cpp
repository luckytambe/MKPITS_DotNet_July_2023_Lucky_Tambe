#include<iostream>
using namespace std;
class Animals
{
	public:
	virtual void sound()
	{
		cout<<"Animals sound "<<endl;
	}
	virtual void make()
	{
		cout<<"MKPITS"<<endl;
	}
};
class dog : public Animals
{
	public:
	 virtual void sound()
	{
		cout<<"dog ="<<endl;
	}
	void make()
	{
		cout<<"bho bho"<<endl;
	}
};
class cat : public Animals
{
	public:
   	void sound()
	{
		cout<<"cat ="<<endl;
	}
	void make()
	{
		cout<<"mau mau"<<endl;
	}
};
class cow : public Animals
{
	public:
	void sound()
	{
		cout<<"cow ="<<endl;
	}
	void make()
	{
		cout<<"Oooo"<<endl;
	}
};
int main()
{
	Animals *A;
	Animals a;
	dog d;
	cat t;
	cow o;
	A=&a;
	A->sound();
	A->make();
	A=&d;
	A->sound();
	A->make();
	A=&t;
	A->sound();
	A->make();
	A=&o;
	A->sound();
	A->make();
	return 0;
	
	
}
