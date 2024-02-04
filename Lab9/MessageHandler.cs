using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class MessageHandler
    {
        public static bool CheckMessage(string msg, string text)
        {
            int num;
            bool isCorrect = false;
            while (!isCorrect) 
            {
                Console.WriteLine(text);
                isCorrect = int.TryParse(msg, out num);
            }
            return isCorrect;
        }
        public void CreateEmptyClock()
        {
            DialClock clock1 = new DialClock();
            clock1.PrintInfo();
        }

        public void CreateParametersClock()
        {
            while (true)
            {
                Console.WriteLine("Введите кол-во часов");
                
            }
        }

    }
}
