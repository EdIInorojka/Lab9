using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{

    /*class DialClock
    {
        public int hours;
        public int minutes;

        public DialClock(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public DialClock()
        {
            hours = 0;
            minutes = 0;
        }

        // Метод для реализации индексатора
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < 2)
                {
                    return index == 0 ? hours : minutes;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < 2)
                {
                    if (index == 0)
                    {
                        hours = value;
                    }
                    else
                    {
                        minutes = value;
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        // Метод для ручного ввода элементов массива
        public static DialClock[] CreateArrayManually(int size)
        {
            DialClock[] array = new DialClock[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите часы и минуты для элемента {i + 1}:");
                int hours = int.Parse(Console.ReadLine());
                int minutes = int.Parse(Console.ReadLine());
                array[i] = new DialClock(hours, minutes);
            }

            return array;
        }

        // Метод для случайной генерации элементов массива
        public static DialClock[] CreateArrayRandom(int size)
        {
            DialClock[] array = new DialClock[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                int hours = random.Next(0, 24);
                int minutes = random.Next(0, 60);
                array[i] = new DialClock(hours, minutes);
            }

            return array;
        }

        // Метод для печати элементов массива
        public static void PrintArray(DialClock[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Элемент {i + 1}: {array[i].hours}:{array[i].minutes}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрационная программа

            Console.WriteLine("Ручной ввод элементов массива:");
            DialClock[] array1 = DialClock.CreateArrayManually(3);

            Console.WriteLine("\nСлучайная генерация элементов массива:");
            DialClock[] array2 = DialClock.CreateArrayRandom(3);

            Console.WriteLine("\nИсходный массив:");
            DialClock.PrintArray(array1);

            Console.WriteLine("\nГлубокое копирование массива:");
            DialClock[] arrayCopy = new DialClock[array1.Length];
            Array.Copy(array1, arrayCopy, array1.Length);

            // Проверка глубокого копирования
            arrayCopy[0].hours = 99; // Изменяем первый элемент скопированного массива
            Console.WriteLine("\nИзмененный копированный массив:");
            DialClock.PrintArray(arrayCopy);

            Console.WriteLine("\nИсходный массив:");
            DialClock.PrintArray(array1);

            Console.WriteLine("\nРабота индексатора:");

            // 1. Запись объекта с существующим индексом
            array1[0] = new DialClock(10, 20);
            Console.WriteLine("\nИсходный массив:");
            DialClock.PrintArray(array1);

            // 2. Получение объекта с существующим индексом
            DialClock clock1 = array1[0];
            Console.WriteLine($"\nПервый элемент массива: {clock1.hours}:{clock1.minutes}");

            // 3. Запись объекта с несуществующим индексом
            try
            {
                array1[3] = new DialClock(30, 40);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nВыход за пределы массива. Обработка исключительной ситуации.");
            }

            // 4. Получение объекта с несуществующим индексом
            try
            {
                DialClock clock2 = array1[3];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nВыход за пределы массива. Обработка исключительной ситуации.");
            }

            int maxAngle = -1;
            DialClock maxClock = null;

            for (int i = 0; i < array1.Length; i++)
            {
                DialClock currentClock = array1[i];
                int angle = Math.Abs(currentClock.hours * 30 + currentClock.minutes / 2 - currentClock.minutes * 6);
                if (angle > maxAngle)
                {
                    maxAngle = angle;
                    maxClock = currentClock;
                }
            }

            Console.WriteLine($"\nМаксимальный угол между часовой и минутной стрелкой: {maxClock.hours}:{maxClock.minutes} (Угол: {maxAngle} градусов)");

            Console.ReadLine();
        }
    }*/
}
