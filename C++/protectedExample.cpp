#include<iostream>
using namespace std;
class person
{
	
	  protected :
      string name;
};
   class student : public person 
   {
   	 public :
   	 void putdeta(string s)
   	 {
   	 	name=s;
     }
     
     void displaydata()
     {
     	cout<<"name = "<<name<<endl;
	 }
	
   };
	 int main()

{
	student s1;
	s1.putdeta("lucky");
	s1.displaydata();
   
   return 0;
}
