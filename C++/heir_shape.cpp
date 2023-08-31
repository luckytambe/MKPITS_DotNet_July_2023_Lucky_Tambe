#include<iostream>
using namespace std;
class shape
{
	public :
	int x;
	int y;
	void getdata(int a,int b)
    {
    	x=a;
	    y=b;
	}
};
class rectrangle : public shape 
{
	public :
	int rarea(int l ,int b)
	{
		int ra;
		ra=l*b;
		return ra;
	}
};
class trangle : public shape 
{
	public :
	int tarea (int b, int h)
	{
	    int rc;
		rc=0.5*b*h;
		return rc;		
	}
};
int main()
{
	rectrangle r;
	trangle t;
	
	int length,breath,base,height;
	int ra;
	int rc;
	
	cout<<"length breath ";
	cin>>length>>breath;
	ra=r.rarea(length ,breath );
	cout<<"area of rectangle"<<ra<<endl;
	cout<<"base height";
	cin>>base>>height;
	rc=t.tarea(base ,height);
	cout<<"area of trangle"<<rc;
	return 0;	
}
