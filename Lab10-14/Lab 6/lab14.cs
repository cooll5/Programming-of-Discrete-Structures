using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class lab14
    {
        private bool isSymerical;
        private bool isIrReflecsive;

        public lab14(sMatrix matrix)
        {
            isSymerical = checkSymetrical(matrix);
            isIrReflecsive = checkIrReflecsive(matrix);

            Console.WriteLine("Symetrical: " + isSymerical);
            Console.WriteLine("IrReflecsive: " + isIrReflecsive);
        }

        private bool checkSymetrical(sMatrix sMatrix)
        {
            int n = sMatrix.GetN();
            int[,] matrix = sMatrix.GetMatrix();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((matrix[i, j] == 1 && matrix[j, i] == 0)
                         ||
                        (matrix[i, j] == 0 && matrix[j, i] == 1))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool checkIrReflecsive(sMatrix sMatrix)
        {
            int n = sMatrix.GetN();
            int[,] m = sMatrix.GetMatrix();

            bool bool_res = true;

            for (int i = 1; i <= n; ++i)
            {
                bool_res = m[i, i] == 1;

                if (!bool_res)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
