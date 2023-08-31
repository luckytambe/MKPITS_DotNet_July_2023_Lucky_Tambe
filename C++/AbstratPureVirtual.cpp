#include<iostream>
using namespace std;
class media_player 
{
	public :
	virtual void play()=0;
	virtual void pause()=0;
	virtual void stop()=0;
};
class audio : public media_player
{
	public:
	void play()
	{
		cout<<"audio play"<<endl;
	}
	void pause()
	{
		cout<<"audio pause"<<endl;
	}
	void stop()
	{
		cout<<"audio stop"<<endl;
	}
};
class video : public media_player
{
	public:
	void play()
	{
		cout<<"video play"<<endl;
	}
	void pause()
	{
		cout<<"video pause"<<endl;
	}
	void stop()
	{
		cout<<"video stop"<<endl;
	}
};
int main()
{
	audio a;
	a.play();
	a.pause();
	a.stop();
	video v;
	v.play();
	v.pause();
	v.stop();
	return 0;
}

