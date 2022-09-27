//Richard Frank
//Spring


#include <iostream>
#include <conio.h>

using namespace std;


int main()
{

	double TempInput;
	char Type;

	cout << "Please enter a temperature. (Example: 98.6)" << endl; 
	cin >> TempInput;
	cout << endl << "Please enter 'F' to convert Fahrenheit to Celsius. Or 'C' to convert Celsius to Fahrenheight."
		<< endl;
	cin >> Type;


	switch (Type)
	{

	case 'F':
	case 'f': cout << (5.0 / 9.0) * (TempInput - 32.0) << "C"; break;
	case 'C':
	case 'c': cout << (9.0 / 5.0) * TempInput + 32.0 << "F"; break;
	default: cout << "Please enter either 'C' or 'F'.";


	}


	_getch();

	return 0;
}