//Richard Frank
//Tom Fuller
//Spring


#include <conio.h>
#include <iostream>
#include <vector>

using namespace std;


int main()
{
	float Numbers;

	vector<float> vec;

	cout << "Please enter five numbers." << endl;

	cin >> Numbers;
	vec.push_back(Numbers);
	float Min = Numbers;
	float Max = Numbers;

	cin >> Numbers;
	vec.push_back(Numbers);

	cin >> Numbers;
	vec.push_back(Numbers);

	cin >> Numbers;
	vec.push_back(Numbers);

	cin >> Numbers;
	vec.push_back(Numbers);

	cout << endl;

	vector<float>::reverse_iterator it;

	for (it = vec.rbegin(); it < vec.rend(); it++)
	{
		if (*it > Max)
		{
			Max = *it;
		}
		if (*it < Min)
		{
			Min = *it;
		}

		cout << *it << " ";
	}
	cout << endl << endl;
	cout << "The largest number is: " << Max;
	cout << endl;
	cout << "The smallest number is: " << Min;

	_getch();
	return 0;

}