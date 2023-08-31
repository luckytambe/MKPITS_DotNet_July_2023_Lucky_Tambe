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
	cout<<"minus of two num"<<c1.minu(10,5)<<endl;
	cout<<"minus of three num"<<c1.minu(10,9,8);
	return 0;
}
