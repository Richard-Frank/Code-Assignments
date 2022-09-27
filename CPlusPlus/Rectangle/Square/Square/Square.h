#pragma once

#include"Rectangle.h"


class Square : public Rectangle
{
private:

	float m_height;
	float m_width;

public:

	void setHeight(float height)
	{
		{//Detects a negative number, and loops until they have correct input.
			if (height >= 0)
			{
				m_height = height;
				m_width = height;
			}
			else
			{
				cout << "Cannot use negative numbers." << endl;
				cin >> height;
				setHeight(height);
			}
		}
	}

	void setWidth(float width)
	{
		{//Detects a negative number, and loops until they have correct input.
			if (width >= 0)
			{
				m_height = width;
				m_width = width;
			}
			else
			{
				cout << "Cannot use negative numbers." << endl;
				cin >> width;
				setWidth(width);
			}
		}
	}

	//The "Gets"
	float getHeight() { return m_height; }
	float getWidth() { return m_width; }
	float getArea() { return m_height * m_width; }
	float getPerimeter() { return (m_width * 2) + (m_height * 2); }

	virtual void Display();

};