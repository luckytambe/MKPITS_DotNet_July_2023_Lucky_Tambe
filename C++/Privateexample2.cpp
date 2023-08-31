#include<iostream>
using namespace std;
class employe
{
    private :
    string name;
    public:
    void display()
    {
        cout<<"name = "<<name<<endl;
    }
    void getdata( string na)
    {
        name=na;
    }
};
int main()
{
    employe e1;
    string names;
    cout<<"enter name = ";
    cin>>names;
    e1.getdata(names);
    e1.display();
    return 0;
}
