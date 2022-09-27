//Richard Frank
//Prachl
//Spring

//Code from Ryan used.

#include<conio.h>
#include<iostream>
#include<vector>
#include<string>
#include<iomanip>

using namespace std;

struct Employee
{
	int Id;
	string FirstName;
	string LastName;
	float PayRate;
	float Hours;
};

bool addAnother()
{
	// ask if the user would like to continue
	cout << "Would you like to enter another employee?" << endl;
	cout << "Y/N: ";

	char input; cin >> input; // get the input

	// valid responses
	if (input == 'y' || input == 'Y') return true;
	if (input == 'n' || input == 'N') return false;

	// invalid response
	return addAnother();
}

void displayHeader()
{
	cout << setw(10) << "Employee ID";
	cout << setw(20) << "First Name";
	cout << setw(20) << "Last Name";
	cout << setw(14) << "Weekly Pay";
	cout << endl;
}



int main()
{
	vector<Employee> Employees;
	Employee empList;
	

	do
	{
		cout << endl;

		cout << "Please enter the Employee Data." << endl;
		cout << "Id: ";
		cin >> empList.Id;
		cout << "First Name: ";
		cin >> empList.FirstName;
		cout << "Last Name: ";
		cin >> empList.LastName;
		cout << "Pay Rate: ";
		cin >> empList.PayRate;
		cout << "Hours: ";
		cin >> empList.Hours;

		Employees.push_back(empList);


	} while (addAnother());

	cout << endl << endl;


	displayHeader();


	float totalPay = 0;
	for (int i = 0; i < Employees.size(); i++)
	{
		Employee Employee = Employees[i];
		float pay = Employee.PayRate * Employee.Hours;
		totalPay += pay;

		cout << setw(10) << Employee.Id;
		cout << setw(20) << Employee.FirstName;
		cout << setw(20) << Employee.LastName;
		cout << setw(12) << "$" << pay;
		cout << endl;
	}
	cout << "Total pay for all employees: $" << totalPay;

	_getch();



	return 0;
}