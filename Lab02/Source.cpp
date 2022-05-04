#include <iostream>

using namespace std;

void oper_pq(int* p, int* q, int* pq, const int n)
{
	for(int i = 0; i < n; i++)
	{
		if (p[i] == 1 && q[i] == 1)
			pq[i] = 1;
		else pq[i] = 0;
	}
}

void oper_pr(int* p, int* r, int* pr, const int n)
{
	for (int i = 0; i < n; i++)
	{
		if (p[i] == 1 && r[i] == 1)
			pr[i] = 1;
		else pr[i] = 0;
	}
}

void oper_pqpr(int* pq, int* pr, int* pqpr, const int n)
{
	for (int i = 0; i < n; i++)
	{
		if (pq[i] == 1 && pr[i] == 1 || (pq[i] == 0 && pr[i] == 0))
		{
			pqpr[i] = 1;
		}
		else
		{
			pqpr[i] = 0;
		}
	}
}
int main()
{
	const int n = 8;
	int p[n] = { 0,0,0,0,1,1,1,1 };
	int q[n] = { 0,0,1,1,0,0,1,1 };
	int r[n] = { 0,1,0,1,0,1,0,1 };
	int pq[n];
	int pr[n];
	int pqpr[n];
	oper_pq(p, q, pq, n);
	oper_pr(p, r, pr, n);
	oper_pqpr(pq, pr, pqpr, n);
	cout << "           (p ^ q) ~ (p ^ r)" << endl << endl;;
	cout << "------------------------------------------------" << endl;
	cout << "| p | q | r | p ~ q |p ^ r | (p ^ q) ~ (p ^ r) |" << endl;
	cout << "------------------------------------------------" << endl;
	for (int i = 0; i < n; i++)
	{
		cout << "| " << p[i] << " | " << q[i] << " | " << r[i] << " |   " << pq[i] << "   |   " << pr[i] << "   |        " << pqpr[i] << "         |" << endl;
	}
	cout << "------------------------------------------------" << endl;
}