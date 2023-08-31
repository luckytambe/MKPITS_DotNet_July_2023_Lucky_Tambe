#include<iostream>
using namespace std;
class family
{
    protected:
    int fno;
};
class person :public family
{
    public:
    void getdata(int no)
    {
        fno=no;
    }
    void display()
    {
        cout<<"fno= "<<fno<<endl;
    }
};
int main()
{
    person p1;
    int no;
    p1.getdata(45);
    p1.display();
    return 0;
}
