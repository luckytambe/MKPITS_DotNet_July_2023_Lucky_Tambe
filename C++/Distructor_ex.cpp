#include<iostream>
using namespace std;
class employe
{
	public:
	employe()
	{
		cout<<"called constructor"<<endl;
	}
	~employe()
	{
		cout<<"called distructor"<<endl;
	}
	
};
int main()
{
	employe e1;
	employe e2;
	return 0;
}
