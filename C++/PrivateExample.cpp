#include<iostream>
using namespace std;
class student
{
		private :
		int rno;
	    public :
		
	void display()
	{
		cout<<"rno = "<<rno<<endl;
	}
	void getdeta(int r)
	{
		rno=r;
	}
		
};
int main()
{
	student s1;
	int rn;
	cout<<"enter rno";
	cin>>rn;
	s1.getdeta(rn);
    s1.display();
	return 0;
}
