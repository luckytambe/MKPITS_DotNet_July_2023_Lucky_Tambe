#include<iostream>
using namespace std;
int square (int num)
{
	int result=num*num;
	return result ;
	
}
int main()
{
	int num,result;
	cout<"enter num";
	cin>>num;
	result=square(num);
	cout<<"area = "<<result;
	return 0;
	
}
