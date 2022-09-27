#include "Turtle.h"

//Kicks out the information to the console.
void Turtle::Display()
{
	cout << "Animal: " << toString() << endl;
	Animal::Display();
	cout << "Shellcolor: " << getShellColor() << endl;
	cout << endl;
}