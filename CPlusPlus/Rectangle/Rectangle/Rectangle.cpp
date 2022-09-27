#include "Rectangle.h"

void Rectangle::Display()
{//Displays all the info we have.
	cout << endl;
	cout << "Height: " << getHeight() << endl;
	cout << "Width: " << getWidth() << endl;
	cout << "Area: " << getArea() << endl;
	cout << "Perimeter: " << getPerimeter() << endl << endl;

}

void Rectangle::setHeight(float height)
{//Detects a negative number, and loops until they have correct input.
	if (height >= 0)
	{
		m_height = height;
	}
	else
	{
		cout << "Cannot use negative numbers." << endl;
		cin >> height;
		setHeight(height);
	}
}


void Rectangle::setWidth(float width)
{//Detects a negative number, and loops until they have correct input.
	if (width >= 0)
	{
		m_width = width;
	}
	else
	{
		cout << "Cannot use negative numbers." << endl;
		cin >> width;
		setWidth(width);
	}
}