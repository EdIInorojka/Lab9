

using System;
using System.Runtime.InteropServices;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "";
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - создание пустых часов");
                Console.WriteLine("2 - создание часов с параметрами");
                Console.WriteLine("3 - копирование часов");
                Console.WriteLine("4 - создание часов с параметрами");
                Console.WriteLine("7 - вычислить угол методом класса");
                Console.WriteLine("8 - вычислить угол статичным методом");
                Console.WriteLine("9 - добавление минуты");
                Console.WriteLine("10 - удаление минуты");
                Console.WriteLine("11 - вывести часы в консоль");
                Console.WriteLine("12 - Создание пустого массива");
                Console.WriteLine("13 - Авто создание массива");
                Console.WriteLine("14 - Создание массива вручную");
                Console.WriteLine("15 - Копирование массива");
                Console.WriteLine("16 - Изменение копированного массива");
                Console.WriteLine("17 - Показать работу индексатора");
                Console.WriteLine("18 - Вывод кол-ва созданных часов");
                Console.WriteLine("19 - Вывод кол-ва созданных массивов");
                msg = Console.ReadLine();

                switch (msg)
                {
                    case "1": break;
                    case "2": break;
                    case "3": break;
                    case "4": break;
                    case "5": break;
                    case "6": break;
                    case "7": break;
                    case "8": break;
                    case "9": break;
                    case "10": break;
                    case "11": break;
                    case "12": break;
                    case "13": break;
                    case "14": break;
                    case "15": break;
                    case "16": break;
                    case "17": break;
                    case "18": break;
                    case "19": break;
                    default: 
                        Console.WriteLine("Выбранной команды не уществует");
                        break;

                }
            }





            DialClock clock1 = new DialClock();
            clock1.PrintInfo();
        
            DialClock clock2 = new DialClock(1, 1);
            clock2.PrintInfo();
            clock2.DeleteMinute();
            clock2.PrintInfo();
            clock2.AddMinute();
            clock2.PrintInfo();


            DialClock clock3 = new DialClock(clock2);
            clock3.PrintInfo();

            DialClock clock = new DialClock(15, -119);

            double angle1 = DialClock.CalculateAngleStatic(15, -119);
            Console.WriteLine($"Угол (статический метод): {angle1}");

            double angle2 = clock.CalculateAngle();
            Console.WriteLine($"Угол (метод класса): {angle2}");

            Console.WriteLine($"Угол делится на 2.5: {angle1 % 2.5 == 0}");
            Console.WriteLine($"Угол делится на 2.5: {DialClock.IsDevidedTwoHalf(angle1)}");

            int count = clock3.Hours * 60 + clock3.Minutes;
            Console.WriteLine($"Кол-во пройденных делений минутной стрелкой: {count}");
            Console.WriteLine($"Кол-во пройденных делений минутной стрелкой: {clock3.Counter()}");

            DialClock plusClock = clock2 + clock3;
            DialClock minusClock = clock2 - clock3;
            Console.WriteLine($"Оператор +: часы: {plusClock.Hours} минуты: {plusClock.Minutes}");
            Console.WriteLine($"Оператор -: часы: {minusClock.Hours} минуты: {minusClock.Minutes}");

            Console.WriteLine($"Кол-во созданных объектов: {DialClock.GetObjectCount()}");

            Console.WriteLine(clock1.Equals(clock3));

            // Демонстрационная программа
            int size;

            Console.WriteLine("Создание массива через ручной ввод:");
            size = AddArraySize();
            DialClockArray array1 = new DialClockArray(size, "");
            array1.DisplayElements();

            Console.WriteLine("Авто создание массива:");
            size = AddArraySize();
            DialClockArray array2 = new DialClockArray(size);
            array2.DisplayElements();

            Console.WriteLine("Копирование массива:");
            DialClockArray array3 = new DialClockArray(array1);
            array3.DisplayElements();

            Console.WriteLine("Изменение скопированного массива");
            array3[1].Hours = 3;
            array3[1].Minutes = 3;
            Console.WriteLine("Массив 1:");
            array1.DisplayElements();
            Console.WriteLine("Скопированный массив:");
            array3.DisplayElements();

            Console.WriteLine("Запись объекта в сущ. индекс");
            array3[0] = new DialClock(10, 20);
            array3.DisplayElements();

            /*Console.WriteLine("Запись объекта в несущ. индекс");
            array3[-1] = new DialClock(10, 20);
            array3.DisplayElements();*/

            Console.WriteLine("Получение объекта с сущ. индексом");
            DialClock cl1 = array3[0];
            cl1.PrintInfo();

            /*Console.WriteLine("Получение объекта с сущ. индексом");
            DialClock cl2 = array3[-1];
            cl2.PrintInfo();*/

            Console.WriteLine($"Максимальный угол массива: {GetMaxAngle(array3)}");

            Console.WriteLine($"Кол-во созданных массивов: {DialClockArray.ArraysCounter()}");

            Console.WriteLine($"Кол-во созданных объектов: {DialClockArray.ObjectsCounter()}");

            Console.ReadLine();
        }

        public static int AddArraySize()
        {
            int size = 0;
            bool isCorrect = false;
            while( !isCorrect ) 
            {
                Console.WriteLine("Введите длину массива");
                isCorrect = int.TryParse(Console.ReadLine(), out size);
                if (!isCorrect && size < 0)
                {
                    Console.WriteLine("Неверное значение. Попробуйте ещё раз");
                }
            }
            return size;
        }

        public static double GetMaxAngle(DialClockArray array)
        {
            double maxAngle = 0;
            int length = array.ReturnArrayLength();
            for (int i = 0; i<length; i++)
            {
                double angle = array[i].CalculateAngle();
                if (maxAngle < angle)
                {
                    maxAngle = angle;
                }
            }

            return maxAngle;
        }
    }
}
