//Richard Frank
//Spring


#include <iostream>
#include <iomanip>

using namespace std;

void FindAverage(float *pointer, int Number);

int main()
{
	int const SIZE = 5;
	float Numbers[SIZE];
	char Cont;

	 do
	{
		cout << "Please enter five numbers." << endl;
		cin >> Numbers[0];
		cin >> Numbers[1];
		cin >> Numbers[2];
		cin >> Numbers[3];
		cin >> Numbers[4];


		cout << endl << endl;

		FindAverage(Numbers, SIZE);

		cout << endl << endl << "Would you like to continue? (y)" << endl;
		cin >> Cont;
		cout << endl << endl;
	 } while (Cont == 'y');

	return 0;
}


void FindAverage(float *arr, int count)
{
	float Sum = 0;
	float Average = 0;

	for  (int i = 0;  i < count;  i++)
	{
		//Prints out the inputted numbers.
		cout << arr[i] << ' ';

		//Calculates the sum of the total numbers, and the average.
		Sum = Sum + arr[i];
		Average = Sum / count;
	}

	cout << endl << endl << "Total: " << Sum << endl <<
		"Average: " << setprecision(2) << fixed << Average;
}