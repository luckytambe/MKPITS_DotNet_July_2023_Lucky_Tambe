#include<iostream>
using namespace std;
int main()
{
    int num;
    cout<<"Enter num";
    cin>>num;
    if(num<0)
    {
        cout<<"it is negative num";
    }
    else if(num==0)
    {
        cout<<"it is equal num";
    }
    else
    {
        cout<<"it is positive";
    }
    return 0;
}
