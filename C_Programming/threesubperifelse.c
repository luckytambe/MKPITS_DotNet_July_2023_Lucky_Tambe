#include<iostream>

using namespace std;

int main()
{
	int phy,che,bio,sum;
	float per;
	cout<<"Enter three sub marks :";
	cin>>phy>>che>>bio;
	sum=phy+che+bio;
	per=(sum/300.0f)*100.0f;
	cout<<"per = "<<per<<endl;
	cout<<"sum = "<<sum<<endl;
	if(per>=90)
	{
		cout<<"topper";
	}
	else if (per>=50)
	{
		cout<<"grade A";
	}
	else
	{
		cout<<"fail";
	}
	return 0;
	
}
