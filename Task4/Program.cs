//Да се напише на С# оператора за създаване на клас unibit, със следните елементи:
//•	полета:  int x, y;
//•	поне 1 конструктор;
//•	свойства за достъп до полетата;
//•	свойство за проверка дали двата компонента ( x и  y) на даден обект от класа са равни;
//•	свойство за намиране на (модул)  
//•	методи за въвеждане и отпечатване на обект от класа;
//•	метод за намиране на симетричен обект (ще считаме, че обектът b с компоненти bx и by  

using System;
namespace Task4
{
    public class setXY
    {
        //declaring fields
        public int x;
        public int y;
        // Constructor that takes two argument. 
        public setXY(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        // Method for getting x y values
        public static int getValue()
        {
            string a;
            Console.Write("Въседете елемент от обекта(цяло число) : ");
            a = Console.ReadLine();
            int element = int.Parse(a);
            return element;
        }

        //method for writing the values on the console
        public static void PrintXY(setXY xy)
        {
            Console.WriteLine("Полето x има стойност : {0}", xy.x);
            Console.WriteLine("Полето y има стойност : {0}", xy.y);
        }
        //метод дали са равни елементите
        public static void isEqual(setXY xy)
        {

            if (xy.x == xy.y)
                Console.WriteLine("Двата компонента x и y са равни");
            else
                Console.WriteLine("Двата компонента на класа не са равни");

        }
        //метод изчисляващ корен квадратен от X на квадрат + Y на квадрат
        public static double Modul(double x, double y)
        {
            double resultModul = Math.Sqrt(x * x + y * y);
            return resultModul;
        }

        //метод за проверка на симетричност на два обекта a и b
        public static bool isSymetric(setXY a, setXY b)
        {
            bool isSymetric;
            if ((a.x == -b.x) && (b.y == -a.y))
            {
                isSymetric = true;
            }
            else isSymetric = false;
            return isSymetric;
        }
    }

    class TestSetXY
    {
        static void Main()
        {
            int x, y;
            x = setXY.getValue();
            y = setXY.getValue();
            //konstruktor na instanciq ot klasa
            setXY xy = new setXY(x, y);
            Console.WriteLine();
            setXY.PrintXY(xy);
            setXY.isEqual(xy);
            Console.WriteLine("Корен Квадратен от x на квадрат плюс y на квадрат : {0}", setXY.Modul(x, y));

            //създаваме два нови обекта а и б
            Console.WriteLine("Създаваме обект а....");
            x = setXY.getValue();
            y = setXY.getValue();
            setXY a = new setXY(x, y);
            Console.WriteLine("Създаваме обект b....");
            x = setXY.getValue();
            y = setXY.getValue();
            setXY b = new setXY(x, y);

            //подаваме двата обекта на функцията isSymetric
            if (setXY.isSymetric(a, b))
            {
                Console.WriteLine("Обектите а и б са симетрични.");
            }
            else Console.WriteLine("Обектите а и б не са симетрични.");
        }
    }

}