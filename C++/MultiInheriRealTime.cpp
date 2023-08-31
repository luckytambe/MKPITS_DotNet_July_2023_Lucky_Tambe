#include<iostream>
using namespace std;
class ability 
{
    protected:
    string abilityname;
    public:
    void getabilityname(string an)
    {
          abilityname=an;
    }
};
class equipment 
{
    protected:
    string equipmentname;
    public:
    void getequipmentname (string eq)
    {
        equipmentname=eq;
    }
};
class character : public ability, public equipment
{
    private:
    string charactername;
    public:
    void getcharactername(string ch)
    {
        charactername=ch;
    }
    void display()
    {
        cout<<"abilityname ="<<abilityname<<endl;
        cout<<"equipmentname ="<<equipmentname<<endl;
        cout<<"charactername ="<<charactername<<endl;
    }
};
int main()
{
    character c1;
    c1.getabilityname("alian");
    c1.getequipmentname("gun");
    c1.getcharactername("zombie");
    c1.display();
    return 0;
}
