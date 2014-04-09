
//Даден е едномерен масив, съдържащ n на брой цели числа. Да се напише програма на С# за намиране и извеждане върху екрана на:
//•	корен квадратен от max-min , където max и min са съответно максималния и минималния елемент на масива;
//•	броя на положителните  елементите от масива, кратни на 3.
//•	стойностите на онези елементи на масива, в които се среща цифрата 3 (напр. ако стойността на даден елемент на масива е 23,
//то трябва да се отпечата, но ако е 125 – не трябва да се печата).

using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int[] myArr = new int[10] { 23, 32, 1, 2, 45, 6, 43, 23, 12, 45 };
            int max = int.MinValue;
            int min = int.MaxValue;
            //намираме максималния и минималния елемент на масива
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] < min)
                {
                    min = myArr[i];
                }
                if (myArr[i] > max)
                {
                    max = myArr[i];
                }
            }
            Console.WriteLine("Най малкия елемет в масива е: {0}", min);
            Console.WriteLine("Най големия елемент ва масива е : {0}", max);
            Console.WriteLine("Корен квадратен от max-min e : {0}", Math.Sqrt(max-min));
            //отпечатване на еламентите кратни на 3
            Console.WriteLine("Елементите кратни на 3 в масива са : ");
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 3 == 0)
                {
                    Console.WriteLine("-->{0,5}",myArr[i]);
                }
            }

            //отпечатване на елементите от масива които съдържат цифрата 3
            Console.WriteLine("Eлементите от масива които съдържат цифрата 3 : ");
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i].ToString().Contains("3"))
                {
                    Console.WriteLine("--> {0,5}", myArr[i]);
                }
            }
        }
    }
}
