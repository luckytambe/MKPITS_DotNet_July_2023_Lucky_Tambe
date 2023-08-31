#include<iostream>
using namespace std;
int func(int x,int y)
{
	if(y<=0)
	{
		return (1);
	}
	else
	{
		return x*(func(x,y-1));
	}
};
int main()
{
	int result ;
	result =func(5,4);
	cout<<"result ="<<result;
	return 0;
	
}
