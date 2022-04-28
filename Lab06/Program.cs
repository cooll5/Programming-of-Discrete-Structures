using System.IO;
using System;

namespace Lab06
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Graph g = new Graph();
            int[,] result = g.ReadFile();

            //таблиці суміжності та інцидентності
            IncidentMatrix matrix = new IncidentMatrix();
            SumMatrix sumMatrix = new SumMatrix();

            int[,] IncMatrix = matrix.createMatrix(g, result);
            int[,] sMatrix = sumMatrix.createMatrix(g, result);

            IncidentMatrix.printMatrix(IncMatrix, g);
            Console.WriteLine();
            SumMatrix.printMatrix(sMatrix, g);

            g.WriteIncident(IncMatrix);
            g.WriteSumizhn(sMatrix);
        }
    }
}
