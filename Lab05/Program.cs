using System;

namespace Lab05
{
    class Program
    {
        static String[] Defunct(String[] A, String[] B, String[] C)
        {
            String[] D = new String[A.Length * B.Length * C.Length];
            int j = 0;
            for (int ic = 0; ic < C.Length; ic++)
            {
                for (int ia = 0; ia < A.Length; ia++)
                {
                    for (int ib = 0; ib < B.Length; ib++)
                    {
                        D[j] = " " + C[ic] + " " + A[ia] + " " + B[ib];
                        j++;
                    }

                }
            }
            return D;
        }
        static int[] Bitrow(int[] A, int[] C)
        {
            int[] Bit = new int[C.Length];

            for (int i = 0; i < Bit.Length; i++)
                Bit[i] = 0;

            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < C.Length; j++)
                    if (C[j] == A[i])
                    {
                        Bit[j] = 1;
                        break;
                    }

            return Bit;
        }

        static int[] Not(int[] A)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1)
                    D[i] = 0;
                else
                    D[i] = 1;

            return D;
        }
        static int[] And(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 && B[i] == 1)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }
        static int[] Or(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 || B[i] == 1)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }

        static int[] Difference(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 && B[i] == 0)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }
        static int[] XOR(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == B[i])
                    D[i] = 0;
                else
                    D[i] = 1;

            return D;
        }
        static void Main(string[] args)
        {
            String[] A = { "a", "b", "c" };
            String[] B = { "x", "y", "z" };
            String[] C = { "0", "1" };
            String[] D = Defunct(A, B, C);

            Console.WriteLine("Task 1\nAxCxB:");
            Array.ForEach(D, Console.WriteLine);
            Console.WriteLine();

            int[] As = { 1, 2, 4, 6, 8, 10 };
            int[] Cs = { 2, 3, 5 };
            int[] Bs = { 4, 9 };
            int[] bA = Bitrow(As, Cs);
            int[] bB = Bitrow(Bs, Cs);

            Console.WriteLine("----------------");
            Console.WriteLine("Task 2\n" + "U:        " + string.Join(" ", Cs));
            Console.WriteLine("A:        " + string.Join(" ", bA));
            Console.WriteLine("B:        " + string.Join(" ", bB));
            Console.WriteLine("Not A:    " + string.Join(" ", Not(bA)));
            Console.WriteLine("A And B:  " + string.Join(" ", And(bA, bB)));
            Console.WriteLine("A Or B:   " + string.Join(" ", Or(bA, bB)));
            Console.WriteLine("A Diff B: " + string.Join(" ", Difference(bA, bB)));
            Console.WriteLine("A Xor B:  " + string.Join(" ", XOR(bA, bB)));


        }
    }
}
