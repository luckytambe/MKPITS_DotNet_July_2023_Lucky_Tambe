#include<iostream>
using namespace std;
class person
{
	public:
	string name;
	string city;
};
class student : public person
{
	public:
	int rno;
	int marks;
	
};
int main()
{
	student s1;
	s1.name="lucky";
	s1.city="nagpur";
	s1.rno=18;
	s1.marks=456;
	cout<<s1.name<<endl;
	cout<<s1.city<<endl;
	cout<<s1.rno<<endl;
	cout<<s1.marks<<endl;
	
	return 0;
}
