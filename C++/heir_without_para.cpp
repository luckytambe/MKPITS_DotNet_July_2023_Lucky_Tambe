#include<iostream>
using namespace std;
class shape 
{
	public: 
	int x;
	int y;
	void getdata(int a,int b)
	{
		x=a;
		y=b;
	}
};
class rectangle : public shape 
{
	public :
	int crarea()
	{
		int ra;
		ra=x*y;
		return ra;
		
	}
};
class triangle : public shape
{
	public :
	float ctarea()
	{
		float tr;
		tr=0.5*x*y;
		return tr;
	}
};
int main()
{
	rectangle r;
	triangle t;
	int length,breadth,base,height;
	int ra;
	float tr;
	cout<<"enter length & breadth";
	cin>>length>>breadth;
	r.getdata(length,breadth);
	ra=r.crarea();
	cout<<"area of rectangle : "<<ra<<endl;
	cout<<"enter base height";
	cin>>base>>height;
	t.getdata(base,height);
	tr=t.ctarea();
	cout<<"area of triangle : "<<tr<<endl;
	return 0;
}
