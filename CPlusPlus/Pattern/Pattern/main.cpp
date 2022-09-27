//Richard Frank
//Spring

#include<iostream>
#include<conio.h>

//Crates the following pattern.
/*
         2         3            5       6   
1|	*----------**********-**********----------*
2|	**---------*********---*********---------**
3|	***--------********-----********--------***
4|	****-------*******-------*******-------****
5|	*****------******---------******------*****
6|	******-----*****-----------*****-----******
7|	*******----****-------------****----*******
8|	********---***---------------***---********
9|	*********--**-----------------**--*********
10|	**********-*-------------------*-**********
       1                4                7
*/
using namespace std;


int PrintPattern(int &Max, int &Min, int &TriFour);

int main()
{
	int Max = 10;
	int Min = 1;
	int TriFour = 1;
	int Line = 1;

	do
	{
	   PrintPattern(Max, Min, TriFour);
	   Line++;
	} while (Line < 11);

	_getch();
	return 0;
}



int PrintPattern(int &Max, int &Min, int &TriFour)
{
	int T1, T2, T3, T4, T5, T6, T7;

	for (T1 = 0; T1 < Min; T1++)
	{
		cout << '*';
	}

	for (T2 = 0; T2 < Max; T2++)
	{
		cout << ' ';
	}

	for (T3 = 0; T3 < Max; T3++)
	{
		cout << '*';
	}

	for (T4 = 0; T4 < TriFour; T4++)
	{
		cout << ' ';
	}

	for (T5 = 0; T5 < Max; T5++)
	{
		cout << '*';
	}

	for (T6 = 0; T6 < Max; T6++)
	{
		cout << ' ';
	}

	for (T7 = 0; T7 < Min; T7++)
	{
		cout << '*';
	}

	Max--;
	Min++;
	TriFour = TriFour + 2;
	cout << endl;

	return Max, Min, TriFour;
}