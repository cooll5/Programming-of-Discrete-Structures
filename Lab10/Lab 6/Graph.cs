using System;
using System.IO;

namespace Lab10
{
    internal class Graph
    {
        private int m;
        private int n;
        public Graph()
        {
            m = 0;
            n = 0;
        }
        public int GetM() { return this.m; }
        public int GetN() { return this.n; }
        public int[,] ReadFile()
        {
            string line;
            string[] subs;
            int[,] FInfo = null;
            try
            {

                StreamReader sr = new StreamReader("C:\\Users\\unman\\Desktop\\Lab 6\\graph_01_1.txt");  // 6
                //StreamReader sr = new StreamReader("C:\\Users\\unman\\Desktop\\Lab 6\\IrReflecsive.txt");  // 14
                //StreamReader sr = new StreamReader("C:\\Users\\unman\\Desktop\\Lab 6\\Symmetry.txt");  // 14

                line = sr.ReadLine();
                subs = line.Split();
                this.n = Convert.ToInt32(subs[0]);
                this.m = Convert.ToInt32(subs[1]);

                FInfo = new int[m + 1, 2];
                line = sr.ReadLine();
                for (int i = 1; line != null; i++)
                {
                    subs = line.Split();
                    FInfo[i, 0] = Convert.ToInt32(subs[0]);
                    FInfo[i, 1] = Convert.ToInt32(subs[1]);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return FInfo;
        }

        // 10
        public int[,] ReadFileLab10()
        {
            string line;
            string[] subs;
            int[,] FInfo = null;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\unman\\Desktop\\Lab 6\\Lab10-graph_4.txt");

                line = sr.ReadLine();
                subs = line.Split();
                this.n = Convert.ToInt32(subs[0]);
                this.m = Convert.ToInt32(subs[1]);


                FInfo = new int[m + 1, 3];
                line = sr.ReadLine();
                for (int i = 1; line != null; i++)
                {
                    subs = line.Split();
                    FInfo[i, 0] = Convert.ToInt32(subs[0]);
                    FInfo[i, 1] = Convert.ToInt32(subs[1]);
                    FInfo[i, 2] = Convert.ToInt32(subs[2]);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return FInfo;
        }
    }
}