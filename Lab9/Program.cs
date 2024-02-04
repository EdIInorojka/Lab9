

using System;
using System.Runtime.InteropServices;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "";
            while (msg != "15")
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - создание пустых часов");
                Console.WriteLine("2 - создание часов с параметрами");
                Console.WriteLine("3 - копирование часов");
                Console.WriteLine("4 - вычислить угол методом класса");
                Console.WriteLine("5 - вычислить угол статичным методом");
                Console.WriteLine("6 - добавление минуты");
                Console.WriteLine("7 - вычитание минуты");
                Console.WriteLine("8 - создание пустого массива");
                Console.WriteLine("9 - авто создание массива");
                Console.WriteLine("10 - создание массива вручную");
                Console.WriteLine("11 - копирование массива");
                Console.WriteLine("12 - показать работу индексатора");
                Console.WriteLine("13 - Нахождение максимального угла в массиве");
                Console.WriteLine("14 - вывод кол-ва созданных часов");
                Console.WriteLine("15 - вывод кол-ва созданных массивов");
                Console.WriteLine("16 - закочить выполнение программы");
                msg = Console.ReadLine();

                switch (msg)
                {
                    case "1":
                        MessageHandler.CreateEmptyClock();
                        Console.ReadLine();
                        break;
                    case "2":
                        DialClock clock = MessageHandler.CreateParametersClock();
                        clock.PrintInfo();
                        Console.ReadLine();
                        break;
                    case "3":
                        MessageHandler.CopyClock();
                        Console.ReadLine();
                        break;
                    case "4": 
                        MessageHandler.CalcullateAngle();
                        Console.ReadLine();
                        break;
                    case "5":
                        MessageHandler.CalcullateAngleStatic();
                        Console.ReadLine();
                        break;
                    case "6": 
                        MessageHandler.AddMinute();
                        Console.ReadLine();
                        break;
                    case "7":
                        MessageHandler.DeleteMinute();
                        Console.ReadLine();
                        break;
                    case "8": 
                        MessageHandler.CreateEmptyArray();
                        Console.ReadLine();
                        break;
                    case "9": 
                        DialClockArray arr = MessageHandler.AutoCreateArray();
                        arr.DisplayElements();
                        Console.ReadLine();
                        break;
                    case "10": 
                        MessageHandler.CreatePersonalArray();
                        Console.ReadLine();
                        break;
                    case "11": 
                        MessageHandler.CopyArray();
                        Console.ReadLine();
                        break;
                    case "12":
                        Console.WriteLine("Перезапись элемента в массив: ");
                        MessageHandler.ShowIndexerRewrite();
                        Console.WriteLine("Выбор элемента из массива: ");
                        MessageHandler.ShowIndexerGet();
                        Console.ReadLine();
                        break;
                    case "13":
                        DialClockArray array = MessageHandler.AutoCreateArray();
                        Console.WriteLine($"Максимальный угол массива: {GetMaxAngle(array)}");
                        Console.ReadLine();
                        break;
                    case "14":
                        Console.WriteLine($"Кол-во созданных объектов: {DialClockArray.ObjectsCounter()}");
                        Console.ReadLine();
                        break;
                    case "15":
                        Console.WriteLine($"Кол-во созданных массивов: {DialClockArray.ArraysCounter()}");
                        Console.ReadLine();
                        break;
                    case "16": break;
                    default: 
                        Console.WriteLine("Выбранной команды не уществует");
                        break;

                }
            }

            Console.ReadLine();


        }


        public static double GetMaxAngle(DialClockArray array)
        {
            double maxAngle = 0;
            int length = array.ReturnArrayLength();
            for (int i = 0; i < length; i++)
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
