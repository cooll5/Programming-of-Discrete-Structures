using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class DextraMatrix
    {
        int[] minPath;
        int[] minWeight;

        public DextraMatrix(Lab10 wMatrix, int[,] lab10)
        {
            for (int i = 1; i <= wMatrix.getN(); i++)
            {
                for (int j = 1; j <= wMatrix.getN(); j++)
                {
                    if (lab10[i, j] < 0)
                    {
                        throw new Exception("Matrix element must be more that zero!");
                    }
                }
            }
            findTops(wMatrix, lab10, 1);
            Console.WriteLine("Weight: ");
            printVector(minWeight);
            Console.WriteLine("Path: ");
            printVector(minPath);
        }
        private void findTops(Lab10 wMatrix, int[,] lab10, int a)
        {
            HashSet<int> M = new HashSet<int>();
            int[] T = new int[wMatrix.getN() + 1];
            int[] P = new int[wMatrix.getN() + 1];

            M.Add(a);
            T[a] = 0;

            for (int i = 1; i < wMatrix.getN() + 1; i++)
            {
                P[i] = 0;
                if (i != a)
                {
                    T[i] = int.MaxValue;
                }
            }

            int x = a;
            for (int i = 1; i < wMatrix.getN() + 1; i++)
            {
                for (int v = 1; v < wMatrix.getN() + 1; v++)
                {
                    if (lab10[x, v] > 0 && lab10[x, v] != int.MaxValue)
                    {
                        if (!M.Contains(v))
                        {
                            if (T[v] > (T[x] + lab10[x, v]))
                            {
                                T[v] = (T[x] + lab10[x, v]);
                                P[v] = x;
                            }
                        }
                    }
                }

                int minWeight = int.MaxValue;
                int minTop = 0;
                for (int v = 1; v < wMatrix.getN() + 1; v++)
                {
                    if (!M.Contains(v))
                    {
                        if (T[v] < minWeight)
                        {
                            minWeight = T[v];
                            minTop = v;
                        }
                    }
                }
                M.Add(minTop);
                this.minWeight = T;
                this.minPath = P;
                x = minTop;
            }
        }

        public void printVector(int[] V)
        {
            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] == int.MaxValue)
                {
                    Console.Write("{V" + i + ": " + "-" + "} ");
                }
                else
                {
                    Console.Write("{V" + i + ": " + V[i] + "} ");
                }
            }
            Console.WriteLine();
        }
    }
}
