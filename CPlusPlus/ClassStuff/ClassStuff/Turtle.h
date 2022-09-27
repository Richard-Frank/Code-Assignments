#pragma once

#include "Animal.h"

class Turtle : public Animal
{
private:

	string m_shellColor = "Default";

public:

	string getShellColor() { return m_shellColor; }

	void setShellColor(string color) { m_shellColor = color; }

	virtual void Display();

	virtual string toString() { return "Turtle"; }
};