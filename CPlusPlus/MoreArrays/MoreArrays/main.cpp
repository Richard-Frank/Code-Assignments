//Richard Frank
//Spring

#include<conio.h>
#include<iostream>
#include<vector>


using namespace std;

void PrintArray(int *pointNum, int count);


int main(int argc, char *argv[])
{
	/*
	//The path to the program.
	for (int i = 0; i < argc; i++)
	{

		cout << i << ' ' << argv[i] << endl;
	}
	*/

	int const SIZE = 5;
	int numbers[SIZE] = { 3, 6, 12, 24, 48 };

	//PrintArray(numbers, SIZE);

	//2D Array, a 2D array is a array of arrays.
	//(This will be upset until we tell it how big it is.)
	int twoDarr[][2] =
	{
		{2, 3},
		{5, 1},
		{6 , 4},
		{12, 7}
	};

	int x, y;

	cin >> x;
	cin >> y;
	cout << endl << twoDarr[x][y];

	_getch();
	return 0;
}


void PrintArray(int *arr, int count)
{
	for (int i = 0; i < count; i++)
	{

		cout << arr[i] << endl;
	}

}