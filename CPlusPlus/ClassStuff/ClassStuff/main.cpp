//Richard Frank
//Spring


#include<conio.h>
#include<iostream>

//Use quotes if the #include is in your project files.
//Never include .cpp files.
#include"Cat.h"
#include"Turtle.h"
#include"Dog.h"


using namespace std;

/*
void animalTest()
{
	Animal dog;
	dog.setName("Wishbone");
	dog.setAge(4);

	Animal dog2("Rover", 2);

	dog.Display();
	dog2.Display();

	cout << "Do you want to create a new animal? (y/n)" << endl;
	char input; cin >> input;


	if (input == 'y')
	{
		Animal *pDog3 = new Animal("Spot", 6);
		pDog3->Display();
		delete pDog3;
	}

	cout << "Do you want to create a new animal? (y/n)" << endl;
	cin >> input;
	Animal *pDog4 = NULL;
	if (input == 'y')
	{
		pDog4 = new Animal("Gordo", 14);

		//This will cause a memory leak, you are changing the pointer and leaving the object behind.
		//pDog4 = new Animal();
	}



	//if (pDog4 != NULL)
	if (pDog4)
	{
		pDog4->Display();
	}
}
*/


void inheritTest()
{
	Cat c;

	c.setName("Fluffffy");
	c.setAge(3);
	c.Display();

	cout << endl;

	Turtle t;
	t.setName("Shellface");
	t.setShellColor("Plaid");
	t.setAge(104);
	t.Display();
}

int main()
{

	//inheritTest();
	//animalTest();


	int input;

	cout << "Please enter a number for an animal type." << endl << "0: Dog" << endl << "1: Cat" << endl << "2: Turtle" << endl;
	cin >> input;
	cout << endl;


	Animal *pAnimal = NULL;

	switch (input)
	{

	case 0: pAnimal = new Dog(); break;
	case 1: pAnimal = new Cat(); break;
	case 2: pAnimal = new Turtle(); break;
	}
	if (pAnimal)
	{
		cout << "Please enter a name: ";

		string n; cin >> n;
		pAnimal->setName(n);

		Turtle *pTurtle = static_cast<Turtle *>(pAnimal);

		if (pTurtle)
		{
			pTurtle->setShellColor("The color of DOOM!");
		}

		pAnimal->toString();
		pAnimal->Display();
	}


	_getch();
	return 0;
}