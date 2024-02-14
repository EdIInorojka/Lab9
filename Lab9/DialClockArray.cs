using System;

namespace Lab9
{
    public class DialClockArray
    {
        private DialClock[] arr; // одномерный массив элементов типа DialClock
        private static int objectsCounter = 0;
        private static int arraysCounter = 0;

        public DialClockArray()
        {
            arr = new DialClock[0];
            arraysCounter++;
        }

        public DialClockArray(int size)
        {
            arr = new DialClock[size];
            arraysCounter++;
            objectsCounter += size;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = new DialClock();
                arr[i].Hours = random.Next(12);
                arr[i].Minutes = random.Next(60);

            }
        }

        public DialClockArray(DialClockArray source)
        {
            arr = new DialClock[source.arr.Length];
            for (int i = 0; i < source.arr.Length; i++)
            {
                arr[i] = new DialClock();
                arr[i].Hours = source.arr[i].Hours;
                arr[i].Minutes = source.arr[i].Minutes;
            }
        }


        public DialClockArray(int size, string inputMessage)
        {
            arr = new DialClock[size];
            arraysCounter++;
            objectsCounter += size;
            for (int i = 0; i < size; i++)
            {
                arr[i] = new DialClock();
                Console.WriteLine($"{inputMessage} {i+1}");
                arr[i].Hours = MessageHandler.CheckMessage("Введите часы: ");
                arr[i].Minutes = MessageHandler.CheckMessage("Введите минуты: ");
            }
        }

        public void DisplayElements()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Элемент {i+1}:");
                Console.WriteLine("Часы: " + arr[i].Hours);
                Console.WriteLine("Минуты: " + arr[i].Minutes);
                Console.WriteLine();
            }
        }

        // Метод для реализации индексатора
        public DialClock this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new ArgumentException($"Значение должно входить в диапазон от 0 до {arr.Length}");
                }

                return arr[index];
            }

            set
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new ArgumentException($"Значение должно входить в диапазон от 0 до {arr.Length}");
                }

                arr[index] = value;
            }
        }

        public int ReturnArrayLength()
        {
            return arr.Length;
        }

        public static int ArraysCounter()
        {
            return arraysCounter;
        }

        public static int ObjectsCounter()
        {
            return objectsCounter;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is DialClockArray arr)
            {
                return this == arr;
            }
            else
            {
                return false;
            }
        }
    }
}

