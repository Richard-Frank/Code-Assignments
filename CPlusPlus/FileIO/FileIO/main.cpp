//Richard Frank
//Spring


#include<iostream>
#include<conio.h>
#include<string>
#include<fstream> // File stream.


using namespace std;

int main()
{
	cout << "Enter a line of text." << endl << endl;

	//Remember to #include<string>.
	string line;
	string filepath = "C:\\temp\\testText.txt";


	getline(cin, line);


	ofstream ofs(filepath); // Output File Stream (Outputs to files.)
	if (ofs) //Checks to see if ofs is a valid object. Checks to see if it is null.
	{
		ofs << line << endl << "Complete.";
	}
	else
	{
		cout << "Error!";
	}
	
	ofs.close(); // Closes 'ofs' so other objects can use the files.


	cout << "Read file" << endl;

	ifstream ifs(filepath); // Input File Stream (Gets input from files.)
	if (ifs) //Checks to see if ofs is a valid object. Checks to see if it is null.
	{
		while (getline(ifs, line))
		{
			cout << line << endl;
		}
	}
	else
	{
		cout << "Error!";
	}

	ifs.close();

	//Only uses the first word.
	//cin >> line;

	cout << endl << line << endl;

	_getch();
	return 0;
}