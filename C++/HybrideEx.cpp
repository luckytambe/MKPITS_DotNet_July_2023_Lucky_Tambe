#include<iostream>
using namespace std;
class classA
{
	protected :
	int num1;
	public :
	void getnum1(int n1)
	{
		num1=n1;
	}
};
class classB : public classA
{
	protected :
	int num2;
	public:
		void getnum2(int n2)
		{
			num2=n2;
		}
};
class classC 
{
	protected :
		int num3;
		public:
		void getnum3(int n3)
		{
			num3=n3;
		}
};
class classD : public classB, public classC
{
	
	public:
	int r;
	int multiply()
	{
		r=num1*num2*num3;
		
		return r;
	}
};
int main()
{
	classD d1;
	int result;
	d1.getnum1(2);
	d1.getnum2(3);
	d1.getnum3(4);
	result=d1.multiply();
	cout<<"multiply ="<<result;
	return 0;
}
