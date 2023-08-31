#include<stdio.h>
void deposit(int amount,int balance);
void withdraw(int amount,int balance);
 void main()
 {
 	int amount,balance=1000;
 	printf("enter amount");
 	scanf("%d",&amount);
 	deposit(amount,balance);
 	withdraw(amount,balance);
 }
  void deposit(int amount,int balance)
  {
  	balance=balance+amount;
  	printf("amount deposite balance is %d\n",balance);
  }
  void withdraw(int amount,int balance)
  {
  	balance=balance-amount;
  	printf("amount withdraw balance is %d\n",balance);
  }
