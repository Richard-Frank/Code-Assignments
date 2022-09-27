//Richard Frank
//Spring


#include <iostream>
#include <conio.h>
#include <iomanip>

using namespace std;

enum Day
{
	// All these are constants, so they are in all caps. (They don't NEED to be.)

 //   0       1        2         3          4        5        6
	SUNDAY, MONDAY, TUESDAY, WEDNSESDAY, THURSDAY, FRIDAY, SATURDAY, MAX
};

int main()
{
	Day JohnsFav = SATURDAY;

	Day RyansFav = FRIDAY;

	if (JohnsFav == RyansFav)
	{
		cout << "They like the same day! Best Friends?";
	}


	int iMonday = (int)MONDAY;
	Day dZero = (Day)0;

	int Fav;

	// Can't use cin with your own datatypes.
	cin >> Fav;

	switch (Fav)
	{
	case SATURDAY: cout << "Saturday"; break;
	case MONDAY: cout << "Nobody likes Mondays... Idiot."; break;
	default: cout << "...";
	}

	for (int d = SUNDAY; d < MAX; d++)
	{

	}


	_getch();
	return 0;
}