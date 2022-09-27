//Richard Frank
//Spring

#include <iostream>

using namespace std;

void Swapintegers(int *Num1, int *Num2);

int main()
{

	int First;
	int Second;
	char Cont;


	//Asks for two user inputted numbers. Calls Swapintegers. Loops if they press y.
	while (true)
	{
		cout << "Please enter you first number." << endl;
		cin >> First;
		cout << "Please enter your second number." << endl;
		cin >> Second;

		cout << endl << "And now we swap!" << endl << endl;
		cout << First << ' ' << Second << endl;
		Swapintegers(&First, &Second);
		cout << First << ' ' << Second << endl;

		cout << endl << "Again? (y)" << endl;
		cin >> Cont;

		if (Cont != 'y')
		{
			break;
		}

		cout << endl;
	}

	return 0;

}


//Swaps the values of the pointers.
void Swapintegers(int *Num1, int *Num2)
{
	 int Temp;

	 Temp = *Num1;

	*Num1 = *Num2;
	*Num2 = Temp;

	return;

}