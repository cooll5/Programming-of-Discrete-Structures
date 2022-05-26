using System;
using System.Collections.Generic;

namespace Lab10
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            FileService f = new FileService();
            int[,] result = f.ReadFile();

            iMatrix matrix = new iMatrix();
            int[,] IMatrix = matrix.createMatrix(f, result);
            iMatrix.printMatrix(IMatrix, f);
            f.WriteFileIncident(IMatrix);

            Console.WriteLine("\n");

            sMatrix sMatrix = new sMatrix();
            int[,] SumMatrix = sMatrix.CreateMatrix(f, result);
            sMatrix.printMatrix(SumMatrix, f);
            f.WriteFileSumij(SumMatrix);
            Console.WriteLine("\n");
            int[,] degs = CharchactGraf.FindInnerAndOut(sMatrix);

            for (int i = 1; i < f.GetN() + 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(degs[i, j] + " ");
                }
                Console.WriteLine();
            }

            //7
            Console.WriteLine();
            Console.WriteLine("Lab - 7");
            CharchactGraf.isVisyacha(sMatrix, degs);
            CharchactGraf.isIsolated(sMatrix, degs);

            // 8
            Console.WriteLine();
            Console.WriteLine("Lab - 8");
            DFS dfs = new DFS();
            dfs.Search(sMatrix, 4);
            dfs.PrintResult();

            // 9
            Console.WriteLine();
            Console.WriteLine("Lab - 9");
            BFS bfs = new BFS();
            bfs.Search(sMatrix, 4);
            bfs.PrintResult();


            /*
                        // 10
                        Console.WriteLine();
                        Console.WriteLine("Lab - 10");
                        WeightMatrix w = new WeightMatrix();
                        int[,] lab10graph = f.ReadFileWeight();
                        int[,] lab10 = w.CreateMatrix(f, lab10graph);
                        WeightMatrix.printMatrix(lab10, f);*/


            /*
                        // 11
                        Console.WriteLine();
                        Console.Write("Lab - 11");
                        FloydPathMatrix floidlab11 = new FloydPathMatrix(w, lab10);


                        // 12

                        Console.WriteLine();
                        Console.WriteLine("Lab - 12");
                        DeixtraMatrix floidlab12 = new DeixtraMatrix(w, lab10);



                        //13

                        Console.WriteLine("Lab - 13");
                        int[,] WeightGraph = f.ReadFileWeight();
                        sMatrix sMatrix1 = new sMatrix();
                        int[,] SumMatrix1 = sMatrix1.CreateMatrix(f, WeightGraph);
                        sMatrix.printMatrix(SumMatrix1, f);
                        Console.WriteLine();

                        ColoredGraph graphColor = new ColoredGraph(sMatrix1);*/

            //14
            Console.WriteLine();
            Console.WriteLine("Lab 14");
            lab14 lab14 = new lab14(sMatrix);

            Console.ReadKey();
        }
    }
}
