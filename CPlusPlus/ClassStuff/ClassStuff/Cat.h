#pragma once

#include "Animal.h"

class Cat : public Animal
{
private:

	int m_numLives = 9;

public:

	int getNumLives() { return m_numLives; }

	bool isAlive() { return (getNumLives() > 0); }

	void Kill();

	virtual string toString() { return "Cat"; }
};