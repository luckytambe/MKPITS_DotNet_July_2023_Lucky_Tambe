#include<iostream>
using namespace std;
int main()
{
    int num;
    cout<<"enter num";
    cin>>num;
    if(num<0)
    {
        cout<<"it is negative";
    }
    else if(num==1)
    {
        cout<<"it is equal to 0";
    }
    else
    {
        cout<<"it is positive";
    }
    return 0;
}
