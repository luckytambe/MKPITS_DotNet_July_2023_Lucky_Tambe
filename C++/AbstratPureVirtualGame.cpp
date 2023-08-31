#include<iostream>
using namespace std;
class abstract
{
	public:
	virtual void start()=0;
	virtual void play()=0;
	virtual void end()=0;
};
class tiktakto :public abstract
{
	public:
	void start()
	{
		cout<<"tiktakto is start"<<endl;
	}
	void play()
	{
		cout<<"tiktakto is play"<<endl;
	}
	void end()
	{
		cout<<"tiktakto is end"<<endl;
	}
};
class chess : public abstract
{
	 public:
	 void start()
	{
		cout<<"chess is start"<<endl;
	}
	void play()
	{
		cout<<"chess is play"<<endl;
	}
	void end()
	{
		cout<<"chess is end"<<endl;
	}
};
int main()
{
	tiktakto t;	
	t.start();
	t.play();
	t.end();
	
	chess c;
	c.start();
	c.play();
	t.end();
	
	return 0;
	
}
