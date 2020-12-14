using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppThreeding
{
    class Program
    {
        static char ch = '*';
        static void Main(string[] args)
        {
            Threprog threprog = new Threprog();
            #region opg 0,1
            //Thread thread = new Thread(new ThreadStart(threprog.WorkThreadFuntion));
            //thread.Start()
            #endregion
            #region Opg 2
            //Thread thread1 = new Thread(threprog.WorkThreadFuntion);
            //thread1.Start("C#-trådning er nemt!");

            //Thread.Sleep(1000);

            //Thread thread2 = new Thread(threprog.WorkThreadFuntion);
            //thread2.Start(" Også med flere tråde …");
            #endregion
            #region opg 3
            //Thread thread3 = new Thread(threprog.ErrorMge);
            //thread3.Start();

            //Thread.Sleep(10000); // main tread sleap
            //bool isStilAlive = thread3.IsAlive;

            //if (isStilAlive == false)
            //{
            //    thread3.Abort();
            //}
            #endregion
            #region opg 4
            Thread thread4 = new Thread(PrintUsrInput);
            thread4.Start();

            Thread thread5 = new Thread(UsrInput);
            thread5.Start();
            #endregion

            Console.Read();

            Console.ReadKey();

        }

        static public void PrintUsrInput()
        {
            while (true)
            {
                Thread.Sleep(100);
                Console.Write(ch);
            }
        }

        static public void UsrInput()
        {
            while (true)
            {
                ch = Console.ReadKey().KeyChar;
            }
        }
    }
}
