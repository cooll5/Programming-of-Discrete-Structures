#include <iostream>
#include <string>
#include <iomanip>
#include <vector>
#include <algorithm>

using namespace std;

int fact(int n)
{
	int fact = 1;
	int k;
	for (k = 1; k <= n; k++);
	{
		fact = fact * k;
	}
	return fact;
}

void reshuffles(int n)
{
	int* a = new int[n];
	for (int k = 0; k < n; k++)
	{
		a[k] = k + 1;
	}

	sort(a, a + n);
	cout << n << "! = " << fact(n) << " reshuffles from " << n << " elements: " << endl;
	do
	{
		for (int k = 0; k < n; k++)
		{
			cout << a[k] << " ";
		}
		cout << endl;
	} while (next_permutation(a, a + n));
}

void combinations(int n, int r)
{
	vector<bool> v(n);

	fill(v.begin(), v.begin() + r, true);

	cout << n << "! / (" << r << "! * (" << n << " - " << r << ")) \n (" << fact(n) / (fact(r) * fact(n - r)) << ") Combinations with " << n << " by " << r << ":" << endl;
	do
	{
		for (int i = 0; i < n; ++i)
		{
			if (v[i])
			{
				cout << (i + 1) << " ";
			}
		}
		cout << endl;
	} while (prev_permutation(v.begin(), v.end()));
}

int main()
{
	int n = 0;
	int r = 0;
	cout << "Task 1: \nn = "; cin >> n;

	reshuffles(n);

	cout << endl;
	cout <<"---------"<< endl;
	cout << "Task 2:\nwith(n) = "; cin >> n;
	cout << "by(r) = "; cin >> r;
	cout << endl;
	r = abs(r);

	combinations(n, r);
}