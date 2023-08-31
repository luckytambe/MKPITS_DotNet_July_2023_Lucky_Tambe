#include<iostream>
using namespace std;
class calculate
{
	public:
	int minu(int n1,int n2)
	{
		return n1-n2;
	}
	int minu(int n1,int n2,int n3)
	{
		return n1-n2-n3;
	}
};
int main()
{
	calculate c1;
	int n1,n2,n3,n4,n5;
	cout<<"enter two num";
	cin>>n1>>n2;
	cout<<"enter three num";
	cin>>n1>>n2>>n3;
	cout<<"minus of two num"<<c1.minu(2,3)<<endl;
	cout<<"minus of three num"<<c1.minu(2,4,5);
	return 0;
}
