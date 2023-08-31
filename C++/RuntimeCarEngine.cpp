#include<iostream>
using namespace std;
class vahicle
{
	public:
	virtual void start()
	{
		cout<<"start engine"<<endl;
	}
	virtual void stop()
	{
		cout<<"stop engine"<<endl;
	}
};
class car : public vahicle
{
	public:
	void start()
	{
		cout<<"car is started"<<endl;
	}
	void stop()
	{
		cout<<"car is stop"<<endl;
	}
};
class motorcycle : public vahicle
{
	public :
	void start()
	{
		cout<<"motorcycle is started"<<endl;
	}
	void stop()
	{
		cout<<"motorcycle is stop"<<endl;
	}
};
class truck : public vahicle
{
	public:
	void start()
	{
		cout<<"truck is started"<<endl;
	}
	void stop()
	{
		cout<<"truck is stop"<<endl;
	}		
};
int main()
{
	vahicle *v;
	vahicle V;
	car c;
	motorcycle m;
	truck t;
	v=&V;
	v->start();
	v->stop();
	v=&c;
	v->start();
	v->stop();
	v=&m;
	v->start();
	v->stop();
	v=&t;
	v->start();
	v->stop();
	
	return 0;
}
