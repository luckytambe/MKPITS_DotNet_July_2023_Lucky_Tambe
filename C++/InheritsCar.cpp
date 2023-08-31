#include<iostream>
using namespace std;
class engine
{
	private :
	string power;
	public :
	void getpower (string po)
	{
		power=po;
	}
	void start()
	{
		cout<<"start engine : "<<endl;
	}
	void stop()
	{
		cout<<"stop engine : "<<endl;
	}
};
class vehicle 
{
	private:
	string brand ;
	public :
	void getbrand(string br)
	{
		brand=br;
	}
	void acclerated()
	{
		cout<<"acclerated ="<<endl;
	}
	void brake ()
	{
		cout<<"brake"<<endl;
	}
	void display()
	{
		cout<<"brand "<<brand<<endl;
	}
};
class car : public engine, public vehicle
{
	private:
		public:
		void drive()
		{
			cout<<"drive "<<endl;
		}
		void park()
		{
			cout<<"parking "<<endl;
		}
};
int main()
{
	car c1;
	c1.getbrand("tata ");
	c1.display();
	c1.start();
	c1.drive();
	c1.acclerated();
	c1.brake();
	c1.park();
	c1.stop();
	return 0;
}
