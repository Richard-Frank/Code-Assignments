
// Ryan Appel
// Spring 2016

#include <iostream>
#include <conio.h>
#include <iomanip>  // gives us setprecision() and setw() "fixed"

using namespace std;

int main()
{
	// sizeof() function tells us the memory footprint
	int v = 7;

	cout << "The size of int: " << sizeof(int) << " bytes" << endl;
	cout << "The size of i(int): " << sizeof(v) << " bytes" << endl;
	cout << "The size of float: " << sizeof(float) << " bytes" << endl;
	cout << "The size of double: " << sizeof(double) << " bytes" << endl;
	cout << "The size of bool: " << sizeof(bool) << " bytes" << endl;
	cout << "The size of char: " << sizeof(char) << " bytes" << endl;

	// numeric limits -- largest/smallest value of that type
	cout << "Max int: " << numeric_limits<int>::max() << endl;
	cout << "Min int: " << numeric_limits<int>::min() << endl;

	cout << "Max unsigned int: " << numeric_limits<unsigned int>::max() << endl;
	cout << "Min unsigned int: " << numeric_limits<unsigned int>::min() << endl;

	cout << endl << endl << endl;

	// order of operations (and integer division)

	int i = 6, j = 3, k = 2;

	int a = i + j * k; // 12
	a = (i + j) * k;   // 18
	a = j / k + i;	   // 7 - remember integer division 3/2 = 1 (not 1.5)

	float f = (float)(j / k + i); // 7.0 -- still dividing ints
	f = j / (float)k + i; // 7.5

	int b = 7 % 2;

	//cout << a;


	// conditional statements (if/else if/else, switch)

	cout << "Enter an integer: ";
	int input;
	cin >> input;

	if (input % 2) // resolves to true if input is odd
	{
		cout << input << " is odd!" << endl;
	}
	else if (input == 5)
	{
		// how the HELL did the user get here?!?!???!
		cout << "you entered 5!";
	}
	else
	{
		cout << input << " is even!" << endl;
	}

	if (5)
	{
		cout << "This will run because 5 is not zero!" << endl;
	}

	switch (input)
	{
	//case 13:
	case 12: cout << "Twelve Drummers Drumming" << endl;
	case 11: cout << "Eleven Pipers Piping" << endl;
	case 10: cout << "Ten Lords a Leaping" << endl;
	case 9: cout << "Nine Ladies Dancing" << endl;
	case 8: cout << "Eight Maids a Milking" << endl;
	case 7: cout << "Seven Swans a Swimming" << endl;
	case 6: cout << "Six Geese a Laying" << endl;
	case 5: cout << "Five Golden Rings" << endl;
	case 4: cout << "Four Calling Birds" << endl;
	case 3: cout << "Three French Hens" << endl;
	case 2: cout << "Two Turtle Doves" << endl;
	case 1: cout << "A Partridge in a Pear Tree" << endl; break;
	default: cout << "..." << endl; 
	}

	// io stream manipulation
	cout << 23.45678 << endl;
	cout << setprecision(3) << 23.45678 << endl; // rounds the #
	cout << setprecision(3) << fixed << 23.45678 << endl;

	cout << setw(10) << "Hello!";

	_getch();
	return 0;
}