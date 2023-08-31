#include<iostream>
using namespace std;
class classA
{
    public :
    void getdata()
    {
        cout<<"dispaly form classA"<<endl;
    }
};
class classB 
{
    public :
    void getdata()
    {
        cout<<"display form classB"<<endl;
    }
};
class classC : public classA ,public classB
{
    public :
    void getdataC()
    {
        classA::getdata();
        classB::getdata();
    }
};
int main()
{
    classC c1;
    c1.getdataC();
    return 0;
}
