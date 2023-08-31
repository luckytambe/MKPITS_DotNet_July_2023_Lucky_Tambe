#include<iostream>
using namespace std;
class student
{
	public:
	string name;
	int clas;
	int rollno;
	void getStudend_details()
	{
		cout<<"name "<<"clas "<<"rollno ";
		cin>>name>>clas>>rollno;
	}
	void displayStudent_detail()
	{
		cout<<"name= "<<name<<endl;
		cout<<"clas= "<<clas<<endl;
		cout<<"rollno= "<<rollno<<endl;
	}
   float calculategrade()
{

           float m1,p1,c1,per;
           cout<<"enter three sub:";
           cin>>m1>>p1>>c1;
           per=(m1+p1+c1)/300*100;
           cout<<"Per ="<<per;
           if(per>=90)
         {
        	cout<<"topper"<<endl;
         }
           else if(per<70 && per>=90)
         { 
         	cout<<"grade 'A' "<<endl;
         } 
           else if(per>=50)
         {
        	cout<<"grade B"<<endl;
         }
           else 
         {
        	cout<<"fail"<<endl;
         }
          return per;
} 

};
int main()
{ 
 student s1;
 s1.getStudend_details();
 s1.displayStudent_detail();
 s1.calculategrade();
 return 0;
}
