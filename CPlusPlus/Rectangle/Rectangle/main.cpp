//Richard Frank
//Spring

#include<iostream>
#include<conio.h>

#include"Rectangle.h"

using namespace std;

/////////////////////////////////////////////////////////////////////////////////
//Rectangle was here.
/////////////////////////////////////////////////////////////////////////////////

bool addAnother()
{
	// ask if the user would like to continue
	cout << "Would you like to create another rectangle?" << endl;
	cout << "Y/N: ";

	char input; cin >> input; // get the input

	// valid responses
	if (input == 'y' || input == 'Y') return true;
	if (input == 'n' || input == 'N') return false;

	// invalid response
	return addAnother();
}


int main()
{
	Rectangle Rec;

	float height;
	float width;

	do
	{
		cout << "Please enter the height of your rectangle." << endl;
		cin >> height;
		Rec.setHeight(height);

		cout << endl << "Please enter the width of your rectangle." << endl;
		cin >> width;
		Rec.setWidth(width);

		Rec.Display();
	} while (addAnother());

	return 0;
}