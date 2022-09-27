#pragma once
//Pragma Once keeps the class from being loaded more than once.

//__Animal_H__ is just a unique name for this class. It COULD be named anything.

//If __Animal_H__ is not defined, run this code. An older way to keep it from being loaded more than once.
//#ifndef __Animal_H__
//#define __Animal_H__

#include<string>
#include<iostream>

using namespace std;

class Animal
{
private: //Privates everything below it in the class.
	string m_name;
	int m_age = 1331;


public: //Publics everything below it in the class.

	//Constructor
	Animal() { }
	Animal(string name, int age)
	{
		setName(name);
		setAge(age);
	}

	//Destructor -- Runs before the object is destroyed. Best used for cleanup.
	~Animal() { cout << getName() << " destroyed. You monster." << endl; }

	//Mutator methods
	///void setName(string name) { this->name = name; }
	void setName(string name) { m_name = name; }
	void setAge(int age)
	{
		if (age >= 0) m_age = age;
		else
		{
			cout << getName() << " has an invalid age. Please enter a non-negative number." << endl;
			cin >> age;
			setAge(age);
		}
	}


	//Accessor methods
	string getName() { return m_name; }
	int getAge() { return m_age; }


	// Other Methods

	// PURE virtual function (Abstract) Anything that uses this MUST override it.
	virtual string toString() = 0;

	string Move() { return getName() + " Walking---"; }
	
	//Kicks out the information to the console.
	//Virtual means that other classes can override Display(), so Cat Display() can be different from Animal Display().
	virtual void Display();
};


//#endif // __Animal_H__