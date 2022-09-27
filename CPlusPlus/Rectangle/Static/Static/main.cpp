#include<iostream>
#include<conio.h>


using namespace std;

//This class is in main because we are lazy.
class Circle
{
private:
	//Static
	static int s_count;

	int m_radius = 1331;


public:

	Circle() { s_count++; }
	Circle(int radius) { s_count++; }

	~Circle() { s_count--; }


	int getRadius() { return m_radius; }
	static int getCount() { return s_count; }


	void setRadius(int radius)
	{
		if (radius > 0) { m_radius = radius; }
	}


	//Does not work.
	//Normally goes in the .cpp
	int Circle::s_count = 0; //Initialize the static member variable.

};


int main()
{
	cout << Circle::getCount() << endl;

	Circle c1, c3;
	Circle c2(5);

	cout << Circle::getCount() << endl;

	Circle *pC1; // Does not instantiate a Circle. Just creates a pointer.

	cout << Circle::getCount() << endl;

	pC1 = new Circle(12);

	cout << Circle::getCount() << endl;

	delete pC1;

	cout << Circle::getCount() << endl;

	_getch();
	return 0;
}