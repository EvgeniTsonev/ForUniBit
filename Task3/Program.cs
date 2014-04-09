
//Да се напише програма на С#, която чете низ от клавиатурата
//и променя регистъра на буквите в него на принципа: всяка трета се преобразува в главна,
//а всички останали – в малки.  Напр. Ако е даден низът „qWeRTyuiOP”, да се преобразува на “qwErtYuiOp”.

using System;
namespace Task3
{
    class Program
    {
        static void Main()
        {
            //четем от конзолата
            Console.Write("Въведете текст : ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            int length = arr.Length;
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                //всяка трета се преобразува в главна, а всички останали – в малки,
                //ако е някакъв друг символ го оставя така

                if ((i + 1) % 3 == 0)
                {
                    Console.Write(Char.ToUpper(arr[i]));
                }
                else
                {
                    Console.Write(Char.ToLower(arr[i]));
                }
            }
            //Отпечатваме резултата
            for (int i = 0; i < length; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
