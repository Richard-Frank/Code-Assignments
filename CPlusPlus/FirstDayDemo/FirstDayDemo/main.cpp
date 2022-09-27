
#include <iostream> // So we can write to console.
#include <conio.h> // So we can use "getch".

using namespace std; //Allows you to use std:: without needing to type it.

int main()
{


	cout << "\"Hello " << "World\""; //Prints "Hello World".
	cout << std::endl; // Creates a "new line" character
	cout << "\r\n"; //Creates a "new line" character

	int const I = 4; //Constant int. Constant in all caps.
	float f = 6.1f;
	double const DBL = 2131.1223; //Constant double. Constant in all caps.
	char ch = 'c'; // note the single quotes.
	bool IsAlive = true;
	string s; // A string is an object not a datatype.

	//DBL = 3; Error, DBL is a constant!

	cout << I  << endl; //Prints out a datatype to the console.
	cout << f << endl; //Prints out a datatye to the console.
	cout << ch << endl; //Prints out a datatye to the console.

	std::cout << "Press any key to exit"; //Prints text to console.


	_getch(); // Holds the window open. Remember the ().
	return 0; // Tells OS that we have exited without error.
}