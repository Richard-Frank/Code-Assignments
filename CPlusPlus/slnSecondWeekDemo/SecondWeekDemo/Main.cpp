//Richard Frank
//Spring

#include <iostream>
#include <conio.h>
#include <iomanip> //Gives us setprescision(), setw() and "Fixed"

using namespace std;


int main()
{

	int v = 7;

	cout << "Size of int: " << sizeof(int) << " bytes" << endl <<endl;
	//cout << "Size of v-int: " << sizeof(v) << " bytes" << endl << endl;
	cout << "Size of bool: " << sizeof(bool) << " bytes" << endl << endl;
	cout << "Size of char: " << sizeof(char) << " bytes" << endl << endl;
	cout << "Size of double: " << sizeof(double) << " bytes" << endl << endl;
	cout << "Size of float: " << sizeof(float) << " bytes" << endl << endl;



	//Shows the max/min of int.
	cout << "Max int: " << numeric_limits<int>::max() << endl << endl;
	cout << "Min int: " << numeric_limits<int>::min() << endl << endl;

	//Removes nagaive range
	cout << "Max int: " << numeric_limits<unsigned int>::max() << endl << endl;
	cout << "Min int: " << numeric_limits<unsigned int>::min() << endl << endl;

	//Order of operations.
	cout << endl << endl << endl;


	int i = 6, j = 3, k = 2;

	//Answer 12
	int a = i + j * k;

	//Answer 18
	a = (i + j) * k;

	//Answer 7 - Remember integer divivsion, 3/2 = 1. To round up, add 0.5
	a = j / k + i;

	//Answer 7.0
	float f = j / k + i;

	//Answer 7.5
	f = j / (float)k + i;


	int b = 7 % 2;


	cout << a << endl;
	cout << f << endl << endl;


	// conditional statements (if/else if/else, switch)

	cout << "Enter an integer: ";
	int input;
	cin >> input;

	if (input % 2) // Resolves to true if input is odd.
	{
		cout << input << " is odd." << endl;
	}
	else if (input == 5)
	{
		//How did the user get here?
		cout << "You entered 5";
	}
	else
	{
		cout << input << " is even." << endl;

	}

	if (5)
	{
		cout << "This will run because 5 is not zero." << endl << endl;
	}

	switch (input)
	{

    //Case fallthrough, will keep going as long as there is no break. (When working with characters, put values in 'single quotes'.
	case 13:
	case 12: cout << "12 Drummers Drumming" << endl;
	case 11: cout << "Eleven Pipers Piping" << endl;
	case 10: cout << "Ten Lords a Leaping" << endl;
	case 9: cout << "Nine Ladies Dancing" << endl;
	case 8: cout << "Eight Maids a Milking" << endl;
	case 7: cout << "Seven Swans a Swimming" << endl;
	case 6: cout << "Six Geese a Laying" << endl;
	case 5: cout << "FIVE GOLDEN RINGS!!!!!!!!1!" << endl;
	case 4: cout << "Four Calling Birds" << endl;
	case 3: cout << "Three French Hens" << endl;
	case 2: cout << "Two Turtle Doves" << endl;
	case 1: cout << "A Partridge in a Pear Tree" << endl; break;
	default: cout << "..." <<endl; //Default must be bottom. Duh.
	}

	//iostream manipulation

	cout << 23.45678 << endl;
	//Rounds the number.
	cout << setprecision(3) << 23.45678 << endl;
	cout << setprecision(3) << fixed << 23.45678 << endl;

	cout << setw(10) << "Hello!";

	_getch();
    return 0;
}