//Richard Frank
//Spring


#include <iostream>
#include <conio.h>
#include <iomanip>

using namespace std;


int main()
{

	float Input1;
	float Input2;

	float Salary;

	// Asks for input,
	cout << "Please Enter Employee's Salary." << endl;
	cin >> Input1;
	cout << "Please Enter Employee's Weekly Workhours." << endl;
	cin >> Input2;


	if (Input1 > -1 && Input2 > -1)
	{

		//If the employee has worked overtime.
		if (Input2 > 40)
		{
			//Calculates the regular pay.
			Salary = 40 * Input1;

			//Sets removes the regular pay hours.
			Input2 = Input2 - 40;

			//Calculates the employee's weekly pay.
			Salary = Salary + Input2 * 1.5 * Input1;


			//Displays the amount of overtime hours worked. And the total pay.
			cout << endl << endl << "This Employee has worked overtime!" << endl <<
				"OVERTIME HOURS: " << Input2 << endl << "Pay: $" <<
				setprecision(2) << fixed << Salary << endl << endl << "Press any key to exit.";


		}

		else
		{
			//Calculates the employee's weekly pay.
			Salary = Input1 * Input2;

			cout << endl << endl << "This Employee has not earned overtime." << endl <<
				"Pay: $" << setprecision(2) << fixed << Salary << endl << endl << "Press any key to exit.";

		}


	}

	else
	{
		cout << "Input Error! Connot enter negative numbers!" << endl << "Press any key to exit.";
	}

	_getch();

	return 0;
}