#include<iostream>
using namespace std;
class rectangle
{
	public:
	float length,breath;
	float calculate_area()
	
	{
		float a=length*breath;
		return a;
	}
	float parameter()
	{
		float para=2*(length+breath);
		return para;
	}
};
int main()
{
	float result;
    rectangle R1;
	cout<<"enter area : ";
	cin>>R1.length>>R1.breath;
	
	result=R1.calculate_area();
	cout<<"area= "<<result<<endl;
	
	
	result=R1.parameter();
	cout<<"parameter= "<<result<<endl;
	
	return 0;
	
}
 

