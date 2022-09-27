#include "Animal.h"

//Kicks out the information to the console.
void Animal::Display()
{
	cout << "Name: " << getName() << endl;
	cout << "Age: " << getAge() << endl;
}