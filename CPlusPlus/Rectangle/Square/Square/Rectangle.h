#pragma once

#include<iostream>

using namespace std;

class Rectangle
{
public:
	//Constructor and Destructor.
	Rectangle() {};
	~Rectangle() { cout << "Rectangle has been closed" << endl; }

	//The "Gets"
	float getHeight() { return m_height; }
	float getWidth() { return m_width; }
	float getArea() { return m_height * m_width; }
	float getPerimeter() { return (m_width * 2) + (m_height * 2); }

	void Display();
	virtual void setHeight(float height);
	virtual void setWidth(float width);

private:

	float m_height;
	float m_width;

};