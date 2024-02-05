using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class MessageHandler
    {
        public static int CheckMessage(string text)
        {
            int num = 0;
            bool isCorrect = false;
            while (!isCorrect) 
            {
                Console.WriteLine(text);
                string msg = Console.ReadLine();
                isCorrect = int.TryParse(msg, out num);
                if (!isCorrect)
                {
                    Console.WriteLine("Неверное значение");
                }
            }
            return num;
        }
        public static void CreateEmptyClock()
        {
            DialClock clock = new DialClock();
            clock.PrintInfo();
        }

        public static DialClock CreateParametersClock()
        {
            int hours = CheckMessage("Введите кол-во часов");
            int minutes = CheckMessage("Введите кол-во минут");
            DialClock clock = new DialClock(hours, minutes);
            return clock;
        }

        public static void CopyClock()
        {
            DialClock clock1 = new DialClock(3, 45);
            Console.WriteLine("Часы для копирования:");
            clock1.PrintInfo();
            DialClock clock2 = new DialClock(clock1);
            Console.WriteLine("Результат копирования:");
            clock2.PrintInfo();
        }

        public static void CalcullateAngle()
        {
            DialClock clock = CreateParametersClock();
            double angle = clock.CalculateAngle();
            Console.WriteLine($"Угол = {angle}");
        }

        public static void CalcullateAngleStatic()
        {
            int hours = CheckMessage("Введите кол-во часов");
            int minutes = CheckMessage("Введите кол-во минут");
            double angle = DialClock.CalculateAngleStatic(hours, minutes);
            Console.WriteLine($"Угол = {angle}");
        }

        public static void AddMinute()
        {
            DialClock clock = CreateParametersClock();
            clock.Minutes++;
            clock.PrintInfo();
        }

        public static void DeleteMinute()
        {
            DialClock clock = CreateParametersClock();
            clock.Minutes--;
            clock.PrintInfo();
        }

        public static void CreateEmptyArray()
        {
            DialClockArray arr = new DialClockArray();
            Console.WriteLine("Создан пустой массив");
        }

        public static DialClockArray AutoCreateArray() 
        {
            int size = CheckMessage("Введите длину массива");
            DialClockArray arr = new DialClockArray(size);
            return arr;
        }

        public static void CreatePersonalArray() 
        {
            int size = CheckMessage("Введите длину массива");
            DialClockArray arr = new DialClockArray(size, "Элемент");
            arr.DisplayElements();
        }

        public static void CopyArray()
        {
            Console.WriteLine("Создание массива для копирования:");
            DialClockArray arr = AutoCreateArray();
            DialClockArray copiedArray = new DialClockArray(arr);
            copiedArray.DisplayElements();
        }

        public static void ShowIndexerRewrite()
        {
            DialClockArray array = AutoCreateArray();
            DialClock clock = CreateParametersClock();
            int num = CheckMessage("Введите индекс");
            if (num > 0 && num < array.ReturnArrayLength())
            {
                Console.WriteLine("Массив до записи объекта:");
                array.DisplayElements();
                Console.WriteLine("Массив после записи объекта:");
                array[num] = clock;
                array.DisplayElements();
            }
            else
            {
                array[num] = clock;
            }
        }

        public static void ShowIndexerGet()
        {
            DialClockArray array = AutoCreateArray();
            DialClock clock = CreateParametersClock();
            int num = CheckMessage("Введите индекс");
            if (num > 0 && num < array.ReturnArrayLength())
            {
                Console.WriteLine("Выбранный элемент:");
                array[num].PrintInfo();
            }
            else
            {
                array[num].PrintInfo();
            }
        }
    }
}
