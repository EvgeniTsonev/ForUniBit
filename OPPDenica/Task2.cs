
//Да се напише програма на С#, която:
//•	въвежда от клавиатурата стойност на n  – цяло число в интервала [3; 10];
//•	запълва квадратна матрица Anxn. със случайни числа, попадащи в интервала [1; 100];
//•	извежда елементите на матрицата върху екрана, подредени в редове и колонки, като на края на всеки ред извежда и средноаритметичната му стойност;
//•	извежда сумата на елементите върху главния диагонал на матрицата;

using System;
namespace OPPDenica
{
    class Task1
    {
        static void Main()
        {
            Console.WriteLine("Insert number between 3 and 10 including :");
            int c = 0;
            while (!int.TryParse(Console.ReadLine(), out c) || c < 3 || c > 10)
            {
                Console.WriteLine("Invalid input");
            }

            //създаваме матрица и я запълваме със случайни чила в интервала от 1 до 100
            int[,] matrix = new int[c, c];

            Random rnd = new Random();

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = rnd.Next(1,100);
                }
            }

            //отпечатваме матрицата, и сбора на всеки ред срещу него
            for (int i = 0; i < c; i++)
            {
                int avarage = 0;
                Console.WriteLine();
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0, 4}",matrix[i,j]);
                    avarage += matrix[i,j];

                }
                Console.Write(" -->{0,5}",avarage);
            }
            Console.WriteLine();
            Console.WriteLine();
            //пресмятане и отпечатване на диагонала на матрицата
            int diagonalSum = 0;
            for (int i = 0; i < c; i++)
            {
                diagonalSum += matrix[i,i];
            }
            Console.WriteLine("Сбора от числата на главния диагонал на матрицата е : {0} ", diagonalSum);

        }
    }
}