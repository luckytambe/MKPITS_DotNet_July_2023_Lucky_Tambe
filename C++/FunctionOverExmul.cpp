#include<iostream>
using namespace std;
class multiple
{
	public :
	int mul(int n1,int n2)
	{
		return n1*n2;
	}
	int mul(int n1,int n2,int n3)
	{
		return n1*n2*n3;
	}
};
int main()
{
	multiple m1;
	cout<<"multiple of two num"<<m1.mul(2,5)<<endl;
	cout<<"multiple of the num"<<m1.mul(2,3,4);
	return 0;
}
