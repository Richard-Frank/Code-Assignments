#include <iostream>
#include <conio.h>

/*

I was out the door when I realized the we had not put our names on this.
I know one the name of one of the people I worked with because he E-mailed me the code.
But we were the 3 man crew and I don't know the third man's name. Sorry.


Richard Frank - Me

Shaun Hardtke (Primary Keyboarder)

3rd man.

*/
//Spring




using namespace std;
// fuction prototypes
double adding(double num1, double num2);
double sub(double num1, double num2);
double multi(double num1, double num2);
double divid(double num1, double num2);
// Main fuction
int main()
{
	bool cont = true;
	char YN;

	do
	{

	double num1, num2;
	char numer;
	cout << "Please enter a number" << endl;
	cin >> num1;
	cout << "Please enter a symbol  -  +  *  / " << endl;
	cin >> numer;
	cout << "Please enter a second number." << endl;
	cin >> num2;

	switch (numer)
	{
		// Calls the adding function, and asks if the user wants to continue. Y/N.
	case'+': cout << num1 << " + " << num2 << " = " << adding(num1, num2) << endl << endl;
		cout << endl << "Continue? Y/N" << endl;
		cin >> YN;

		switch (YN)
		{
		case'Y':;
		case 'y': cout << endl << endl; break;
		case 'N':;
		case 'n': cont = false; cout << "Byeeeeeeeeeeee!"; break;

		default: cout << "Incorrect input. The program will now close."; _getch(); cont = false;
		}; break;

		// Calls the sub function, and asks if the user wants to continue. Y/N.
	case'-': cout << num1 << " - " << num2 << " = " << sub(num1, num2) << endl << endl;
		cout << endl << "Continue? Y/N" << endl;
		cin >> YN;

		switch (YN)
		{
		case'Y':;
		case 'y': cout << endl << endl; break;
		case 'N':;
		case 'n': cont = false; cout << "Byeeeeeeeeeeee!"; break;

		default: cout << "Incorrect input. The program will now close."; _getch(); cont = false;
		}break;

		// Calls the multi function, and asks if the user wants to continue. Y/N.
	case'*': cout << num1 << " * " << num2 << " = " << multi(num1, num2) << endl << endl;
		cout << endl << "Continue? Y/N" << endl;
		cin >> YN;

		switch (YN)
		{
		case'Y':;
		case 'y': cout << endl << endl; break;
		case 'N':;
		case 'n': cont = false; cout << "Byeeeeeeeeeeee!"; break;

		default: cout << "Incorrect input. The program will now close."; _getch(); cont = false;
		}break;

		// Calls the divid function, and asks if the user wants to continue. Y/N.
	case'/':divid(num1, num2);	
		if (num2 == 0.0)
		{
			cout << "Cannot divide by zero! "<< endl;
		}
		else
		{
			cout << num1 << " / " << num2 << " = " << divid(num1, num2) << endl << endl;; 
		}
		cout << endl << "Continue? Y/N" << endl;
		cin >> YN;

		switch (YN)
		{
		case'Y':;
		case 'y': cout << endl << endl; break;
		case 'N':;
		case 'n': cont = false; cout << "Byeeeeeeeeeeee!"; break;

		default: cout << "Incorrect input. The program will now close."; _getch(); cont = false;
		}break;


	default: num1 = 0; num2 = 0; numer = '/'; cout << "Error! " << endl;

	}

	} while (cont == true);

	return 0;
}
 double adding(double num1, double num2)
{
	 return num1 + num2;
}
 double sub(double num1, double num2)
 {
	 return num1 - num2;
 }
 double multi(double num1, double num2)
 {
	 return num1 * num2;
 }
 double divid(double num1, double num2)
 {
	 return num1 / num2; 
 }
 