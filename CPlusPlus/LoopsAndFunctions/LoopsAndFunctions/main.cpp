//Richard Frank
//Spring

#include <iostream>
#include <conio.h>
#include <iomanip>


using namespace std;

// Function Prototype. Lets C++ know that a function called CountTo exists. Thus, pre-reading it.
void CountTo(int Max);
float Add(float num1, float num2);


bool GetChange(float chg, int&q, int&d, int&n, int&p);

int main()
{
	//C++ reads top to bottom. Will not understand if you call somthing before it reads it.

	int quarters, nickels, dimes, pennies;

	if (GetChange(0.55, quarters, dimes, nickels, pennies))
	{
		cout << "Q: " << quarters << endl;
		cout << "D: " << dimes << endl;
		cout << "N: " << nickels << endl;
		cout << "P: " << pennies << endl;

		cout << endl;
	}

	else
	{
		cout << "You did not enter a vaild change amount.";
	}

      CountTo(10);
	  cout << endl << Add(5, 7) << endl << endl;


	int i = 0;

	for (; i < 4; i++)
	{
		cout << i << ", ";

		if (i == 1)
		{
			break;
		}
	}


	// same syntax as C#.
	do 
	{

		cout << endl << "do - while" << endl;
	} while (0); // 0 Is the same as false.

	while (0)
	{
		cout << "while";
	}



	_getch();
	return 0;
}


void CountTo(int Max)
{

	for (int i = 1; i <= Max; i++)
	{
		cout << i << endl;
	}

}

float Add(float num1, float num2)
{
	return num1 + num2;
}


bool GetChange(float chg, int&q, int&d, int&n, int&p)
{
	if (chg <= 0 || chg > 1) return false;


	// These will change in main because they are passed by reference (&);
	q = 2;
	d = 0;
	n = 1;
	p = 3;

	return true;
}