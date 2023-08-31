#include<iostream>
using namespace std;
class car
{
	public:
	string model;
	string make;
	int year;

void started_engine()
{
	cout<<"engine started"<<endl;
}
void brake()
{
	cout<<"break applied";
}
};
int main()
{
	car c1;
	c1.model=" thar";
	c1.make=" mahoindra";
	c1.year=2022;
	
	cout<<"model : "<<c1.model<<endl;
	cout<<"make : "<<c1.make<<endl;
	cout<<"year : "<<c1.year<<endl;
	c1.started_engine();
	c1.brake();
	return 0;
}
