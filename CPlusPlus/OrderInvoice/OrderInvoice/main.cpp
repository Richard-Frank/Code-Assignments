//Richard Frank
//Spring

#include<conio.h>
#include<iostream>
#include<vector>
#include<string>
#include<iomanip>
#include<fstream>



using namespace std;

bool addAnother()
{
	// ask if the user would like to continue
	cout << "Do you have more parts to add?" << endl;
	cout << "Y/N: ";

	char input; cin >> input; // get the input

	// valid responses
	if (input == 'y' || input == 'Y') return true;
	if (input == 'n' || input == 'N') return false;

	// invalid response
	return addAnother();
}

int main()
{

	struct Invoice
	{
		float partNum;
		float cost;
		float quantity;

	};

	Invoice inv;
	vector<Invoice> invList;
	string line;
	string filepath = "C:\\temp\\invoice.txt";
	ofstream ofs(filepath);
	bool save = false;
	char yn;

	do
	{
		cout << "Please enter the part number." << endl;
		cin >> inv.partNum;
		cout << endl << "Please enter the cost of the item(Each)" << endl;
		cin >> inv.cost;
		cout << endl << "Please enter the amount of parts purchased" << endl;
		cin >> inv.quantity;
		cout << endl;

		invList.push_back(inv);

	} while (addAnother());


	cout << "Do you wish to save this invoice?" << endl;
	cin >> yn;
	if (yn == 'y' || yn == 'Y') save = true;
	if (yn == 'n' || yn == 'N') save = false;

	cout << endl << endl;

	float totalCost = 0;

	cout << "Part No.       Cost(Each)       Quantity" << endl;

	if (save == true)
	{
		line = "Part No.          Cost(Each)          Quantity";
		if (ofs)
		{
			ofs << line << endl;
		}
		else
		{
			cout << "Error!";
		}
	}


	for (int i = 0; i < invList.size(); i++)
	{

		Invoice Temp = invList[i];

		totalCost = totalCost + Temp.cost * Temp.quantity;

		cout << setw(2) << Temp.partNum;
		cout << setw(15) << "$" << Temp.cost;
		cout << setw(18) << Temp.quantity;
		cout << endl;

		if (save == true)
		{

			line = to_string(Temp.partNum) + "           $" + to_string(Temp.cost) + "       " + to_string(Temp.quantity);

			if (ofs)
			{
				ofs << line << endl;
			}
			else
			{
				cout << "Error!";
			}

		}
	}
	cout << "Subtotal: $" << totalCost;

	line = "Subtotal: $" + to_string(totalCost);
	if (ofs)
	{
		ofs << line;
	}
	else
	{
		cout << "Error!";
	}
	totalCost = totalCost + 0.05 * totalCost;
	cout << setw(15) << "Total: $" << totalCost;
	line = "          Total: $" + to_string(totalCost);
	if (ofs)
	{
		ofs << line;
	}
	else
	{
		cout << "Error!";
	}

	ofs.close();

	_getch();
	return 0;

}