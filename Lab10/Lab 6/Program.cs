using System;
using System.Collections.Generic;

namespace Lab10
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Graph f = new Graph();
            int[,] result = f.ReadFile();

            sMatrix sMatrix = new sMatrix();

            // 10
            Console.WriteLine();
            Console.WriteLine("Lab - 10");
            Lab10 w = new Lab10();
            int[,] lab10graph = f.ReadFileLab10();
            int[,] lab10 = w.CreateMatrix(f, lab10graph);
            Lab10.prntMatrix(lab10, f);



            // 11
            Console.WriteLine();
            Console.Write("Lab - 11");
            FloydPathMatrix floidlab11 = new FloydPathMatrix(w, lab10);


            // 12

            Console.WriteLine();
            Console.WriteLine("Lab - 12");
            DextraMatrix floidlab12 = new DextraMatrix(w, lab10);



            //13

            Console.WriteLine("Lab - 13");
            int[,] WeightGraph = f.ReadFileLab10();
            sMatrix sMatrix1 = new sMatrix();
            int[,] SumMatrix1 = sMatrix1.CreateMatrix(f, WeightGraph);
            sMatrix.printMatrix(SumMatrix1, f);
            Console.WriteLine();

            PaintedGraphs graphColor = new PaintedGraphs(sMatrix1);

            /*            //14
                        Console.WriteLine();
                        Console.WriteLine("Lab 14");
                        lab14 lab14 = new lab14(sMatrix);*/

            Console.ReadKey();
        }
    }
}
