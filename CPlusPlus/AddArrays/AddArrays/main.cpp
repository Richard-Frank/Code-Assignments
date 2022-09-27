//Richard Frank
//Spring

#include <conio.h>
#include <iostream>

using namespace std;

int main()
{


	int const SIZE = 2;

	int ArrayOne[][SIZE] =
	{

		{ 16, 54 },
		{ 18, 91 },
		{ 23, 11 }
	};

	int ArrayTwo[][SIZE] =
	{

		{ 14, 16 },
		{ 52, 19 },
		{ 77, 59 }
	};

	int ArrayThree[][SIZE] =
	{

		{ 0, 0 },
		{ 0, 0 },
		{ 0, 0 }
	};

	for (int a = 0; a < 3; a++)
	{

		for (int b = 0; b < 2; b++)
		{
			ArrayThree[a][b] = ArrayOne[a][b] + ArrayTwo[a][b];

			cout << ArrayOne[a][b] << '+';
			cout << ArrayTwo[a][b] << " = ";
			cout << ArrayThree[a][b] << endl << endl;

		}

	}

	_getch();
	return 0;
}
