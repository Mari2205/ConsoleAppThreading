using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleAppThreeding
{
    public class Threprog
    {
        public void WorkThreadFuntion(object txt)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(txt);
            }
        }

        private int RanNo()
        {
            Random Random = new Random();
            return Random.Next(-20, 121);
        }

        public void ErrorMge()
        {
            int breakPull = 0;
            while (breakPull < 3)
            {
                int temp = Convert.ToInt32(RanNo());
                if (temp > 100 || temp < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("error magesse: can´t not show those temperatures ({0})", temp);
                    Console.ResetColor();
                    breakPull++;
                }
                else
                    Console.WriteLine("temperatur is {0}", temp);

                Thread.Sleep(1000);
            }
        }
    }
}
