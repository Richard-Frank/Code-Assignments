//Shaun
//Prachi
//Richard

#include<conio.h>
#include<iostream>

#include"Square.h"


using namespace std;


int main()
{

	Square squ;
	float width;

	cout << "Please enter the width of your square." << endl;
	cin >> width;
	
	squ.setWidth(width);
	squ.Display();

	_getch();
	return 0;

}