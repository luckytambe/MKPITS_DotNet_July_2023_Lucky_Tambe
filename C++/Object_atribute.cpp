#include<iostream>
using namespace std;
class student
{
	public:
	string course;
	string name;
	int rollno;
	void getdeta()
	{
		cout<<"rollno :"<<"name : "<<"course :";
		cin>>rollno>>name>>course;
	}
	void displaydeta()
	{
		cout<<"rollno "<<rollno<<endl;
		cout<<"name "<<name<<endl;
		cout<<"course "<<course<<endl;
	}	
};
int main()
{
	student stud1,stud2;
	cout<<"student1 "<<endl;
	stud1.getdeta();
	stud1.displaydeta();
	cout<<"student2 "<<endl;
	stud2.getdeta();
	stud2.displaydeta();
	return 0;
}

