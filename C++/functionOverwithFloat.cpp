#include<iostream>
using namespace std;
class total
{
	public:
	int add(int n1,int n2)
	{
		return n1+n2;
	}
	float add(float n1,float n2,float n3)
	{
		return n1+n2+n3;
	}
};
int main()
{
	total t1;
	cout<<"add two num ="<<t1.add(4,5)<<endl;
	cout<<"add two float ="<<t1.add(4.5,4.8,4.5);
	return 0;
	
}
