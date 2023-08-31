#include<iostream>
using namespace std;
class calculation
{
	public :
	int add(int n1,int n2)
	{
	   return n1+n2;
	}
	int add (int n1,int n2,int n3)
	{
		return n1+n2+n3;
	}
};
int main()
{
	calculation c1;
	int n1,n2,n3,n4,n5;
	cout<<"addition of two num"<<c1.add(4,5)<<endl;
	cout<<"addition of three num "<<c1.add(4,5,6);
	return 0;
}
