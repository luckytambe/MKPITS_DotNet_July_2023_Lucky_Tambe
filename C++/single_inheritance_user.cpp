#include<iostream>
using namespace std;
class family
{
	public:
	string name;
};
class person : public family
{
	public:
	int no;
};
int main()
{
	person p1;
	cout<<"enter name and no"<<endl;
	cin>>p1.name>>p1.no;
	cout<<p1.name<<p1.no<<endl;
	return 0;
}
