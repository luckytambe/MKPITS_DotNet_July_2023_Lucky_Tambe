#include<iostream>
using namespace std;
class classA
{
	protected :
		int n1;
		public :

    void getn1(int n)
    {
    	n1=n;
	}
	
};
class classB
{
	protected :
		int n2;
		public :
	void getn2(int n)
	{
		n2=n;
	}
};
class classC : public classA, public classB
{
	public:
	void display()
	{
		cout<<"n1="<<n1<<endl;
		cout<<"n2="<<n2<<endl;
		cout<<"total = "<<n1+n2;
	}
};
int main()
{
	classC c1 ;
	int num1,num2;
	cout<<"enter num1 & num2";
	cin>>num1>>num2;
	c1.getn1(num1);
	c1.getn2(num2);
	c1.display();
	return 0;
}

