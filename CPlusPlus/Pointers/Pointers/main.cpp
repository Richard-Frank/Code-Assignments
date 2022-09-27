//Richard Frank
//Spring


#include <iostream>
#include <conio.h>

//You need this if you want vectors. Huh.
#include <vector>

using namespace std;

void ShowPointersStuff();
void ShowArrayStuff();
void ShowVectorStuff();

int main()
{
	ShowPointersStuff();
	//ShowArrayStuff();
	//ShowVectorStuff();


	_getch();
	return 0;
}

void ShowPointersStuff()
{
	int i = 6;

	cout << "The value of i: " << i << endl;

	// Place an & infront of a variable to have it display its adress.
	cout << "Adress of i:  " << &i << endl;

	// A pointer holds an adress. To make a pointer, add an *.
	int *pI = &i;
	cout << "Value of pI:  " << pI << endl;
	cout << "Adress of pI: " << &pI << endl;

	// Adding a * to a pointer follows the adress and gets the value. (Dereferencing)
	cout << "Value pointed to by pI: " << *pI << endl;


	// The 'i' variable's value has been changed by the pointer. (It followed it home!)
	*pI = 44;
	cout << "The value of i: " << i << endl;
}


void ShowArrayStuff()
{
	float numbers[10];

	for (int i = 0; i < 10; i++)
	{
		// Puts 10 numbers in the array.
		numbers[i] = 10 * i;
	}

	for (int i = 0; i < 10; i++)
	{
		// Counts to 90.
		cout << numbers[i] << ", ";
	}


	cout << endl;

	// On heap
	int numStudents = 12;

	//When creating a new float. We create a space in memory that is not erased automatically.
	//Otherwise we get a memory leak, as it will create a new float EVERY TIME.

	// Creates a array that can be changed because the array is created in limbo. And we use the adress.
	float *numbersTwo = new float[numStudents];


	for (int i = 0; i < numStudents; i++)
	{
		numbersTwo[i] = 10 * i;
	}

	// Be careful overflowing an array. It will find the next spot in memory and just use that.
	for (int i = 0; i <= numStudents; i++)
	{
		// Counts to 110. And uses whatever is in the next space in memory.
		cout << numbersTwo[i] << ", ";
	}

	//Cleans up the mess we made when we made a new float.
	delete[] numbersTwo;
}


void ShowVectorStuff()
{
	float i;

	//A vector is an object.
	//A vector takes more memory. (Not a BIG issue.)
	vector<float> vec;

	//Puts numbers(floats) in the vector.
	vec.push_back(6.2f);
	vec.push_back(9231.1f);
	vec.push_back(10.0f);
	vec.push_back(100.200f);
	vec.push_back(123.345f);
	vec.push_back(30.2f);


	for (i = 0; i < vec.size();i++)
	{
		cout << vec[i] << ", ";
	}

	cout << endl;

	//Used for pointing to elements of a vector.
	vector<float>::iterator it;

	//Vec.end() points to a spot in memory that is NOT in the array.
	for (it = vec.begin(); it < vec.end(); it++)
	{
		cout << *it << ", ";
	}
}