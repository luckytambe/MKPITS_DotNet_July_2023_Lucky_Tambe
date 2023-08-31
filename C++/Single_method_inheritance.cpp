#include<iostream>
using namespace std;
class animal
{
	public:
	void eating()
	{
		cout<<"eat"<<endl;
	}
};
class dog : public animal
{
	public :
	void bark()
	{
		cout<<"dog bark"<<endl;
	}
};
int main()
{
	dog d1;
	d1.eating();
	d1.bark();
	return 0;
}
