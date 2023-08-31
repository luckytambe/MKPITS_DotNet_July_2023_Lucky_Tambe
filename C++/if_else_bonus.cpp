#include<iostream>
using namespace std;
int main()
{
    char name[20];
    int salary,bonus=0;
    cout<<"enter name";
    cin>>name;
    cout<<"enter salary";
    cin>>salary;
    if(salary>=10000)
    {
        bonus=5000;
    }
    else if (salary>=5000 && salary<10000)
    {
        bonus=2000;
    }
    else
    {
        bonus=1000;
    }
    cout<<"name ="<<name<<endl;
    cout<<"salary= "<<salary<<endl;
    cout<<"bonus ="<<bonus<<endl;
    return 0;
}

