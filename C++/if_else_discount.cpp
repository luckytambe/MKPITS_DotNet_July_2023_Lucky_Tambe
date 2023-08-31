#include<iostream>
using namespace std;
int main()
{
	char cus_na[10],pro_na[10];
	int prize,quantity,to_amount,discount;
	cout<<"enter cus_na";
	cin>>cus_na;
	cout<<"enter pro_na";
	cin>>pro_na;
	cout<<"prize";
	cin>>prize;
	cout<<"quantity";
	cin>>quantity;
	to_amount=prize*quantity;
	
	if(to_amount>=1000)
	{
	    cout<<"discount="<<to_amount*0.40;
	}
	else if (to_amount>=500)
	{
		cout<<"discount="<<to_amount*0.25;
	}
	else
	{
		cout<<"discount="<<to_amount*0.10;
	}
	cout<<"cus_na = "<<cus_na<<endl;
	cout<<"pro_na = "<<pro_na<<endl;
	cout<<"prize = "<<prize<<endl;
	cout<<"quantity = "<<quantity<<endl;
    cout<<"discount = "<<discount<<endl;
	to_amount=to_amount-discount;
	cout<<"to_amount"<<to_amount<<endl;
}
