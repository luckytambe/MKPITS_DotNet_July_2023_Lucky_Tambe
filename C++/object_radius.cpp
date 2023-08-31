#include<iostream>
using namespace std;
class circle 
{
	public:
	int radius;
	float calculate_area()
	{
		float area=3.14f*radius*radius;
		return area;
	}
	float calculate_circumference()
	{
	    float circumference=2*3.14f*radius;
		return circumference;
	}
};
int main()
{
	float result;
	circle c1;
	cout<<"enter radius";
	cin>>c1.radius;
	
	result=c1.calculate_area();
	cout<<"area="<<result;
	
	result=c1.calculate_circumference();
	cout<<"circumference="<<result;
	return 0;
}
