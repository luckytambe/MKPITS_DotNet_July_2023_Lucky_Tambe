#include<iostream>
using namespace std;
int main()
{
    float hra,da,basic,hra1,da1,total;
    cout<<"enter basic salary";
    cin>>basic;
    cout<<"hra";
    cin>>hra;
    cout<<"da";
    cin>>da;
    hra1=(hra*basic/100);
    da1=(da*basic/100);
    total=hra+da+basic;
    
    cout<<"total="<<total<<endl;
}
