using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{



    public class CashierClass
    {
        private int x;
        public static Queue<string> CashierQueue;
        public static string CurrentCalledNumber = "";
        public static string NextInLine = "";
        internal static string getNumberInQueue;

        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }

        public static void AddToQueue(string studentNumber)
        {
            CashierQueue.Enqueue(studentNumber);

           SS
            if (CashierQueue.Count > 0)
                NextInLine = CashierQueue.Peek();
        }

        public static void RemoveFromQueue()
        {
            if (CashierQueue.Count > 0)
            {
                CurrentCalledNumber = CashierQueue.Dequeue();

                if (CashierQueue.Count > 0)
                    NextInLine = CashierQueue.Peek();
                else
                    NextInLine = "None";
            }













        }
    }
}
