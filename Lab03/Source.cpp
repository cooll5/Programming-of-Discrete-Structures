#include <iostream>
#include <iomanip>

using namespace std;
#pragma region Task 1
int fact(int x)
{
	int res = 1;
	for (int i = 1; i <= x; i++)
	{
		res = res * i;
	}
	return res;
}

void task1()
{
	int n = 8;
	int r = 5;
	int numerator = fact(n);
	int denominator = fact(n - r);
	double a = numerator / denominator;
	cout << "Task 1: " <<
		"\nn = " << n <<
		"\nr = " << r <<
		"\nA = " << a << endl << endl;
}
#pragma endregion

#pragma region Task 2

void Stirling(int** F, int n)
{
	for (int j = 0; j < n; j++)
	{
		F[j][0] = 1;
		F[j][j] = 1;
	}

	for (int j = 2; j < n; j++)
		for (int k = 1; k < j; k++)
		{
			F[j][k] = F[j - 1][k - 1] + (k + 1) * F[j - 1][k];
		}
	for (int j = 0; j < n; j++)
		for (int k = 0; k < n; k++)
			if (F[j][k] < 0)
			   F[j][k] = 0;
}

void Bell(int** F, int* B, int n)
{
	for (int j = 0; j < n; j++)
		B[j] = 0;

	for(int j = 0; j < n; j++)
		for (int k = 0; k < j; k++)
		{
			B[j] = B[j] + F[j][k];
		}
}

void printtable(int** F, int* B, int n)
{
	cout << " |";
	for (int i = 0; i < n; i++)
		cout << setw(6) << i + 1 << "|";
	cout << setw(6) << "BELL" << endl;

	for (int i = 0; i < n; i++)
	{
		cout << i + 1 << "|";
		for (int j = 0; j < n; j++)
		{
			if (F[i][j] == 0)
				cout << setw(6) << "" <<"|";

			else cout << setw(6) << F[i][j] << "|";
		}
		cout <<setw(6) << B[i];
		cout << endl;
	}
	cout << endl;

}

void task2()
{
	int i = 4;
	int n = i+5;
	int** F = new int* [n];
	for (int j = 0; j < n; j++)
		F[j] = new int[n];

	int* B = new int[n];

	cout << "Task 2: \n";
	Stirling(F, n);
	Bell(F, B, n);
	printtable(F, B, n);
}
#pragma endregion

int main()
{
	task1();

	task2();
}