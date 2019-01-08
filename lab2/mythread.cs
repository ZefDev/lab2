using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab2
{
    public class Mythhread
    {
        private Thread _thread;
        public Thread Thread { get; private set; }

        public void ArrangeThread()
        {
            Thread = new Thread(Mythhread.DoWork);
        }

        public void AvoidThread()
        {
            Thread.Abort();
        }
        public static void DoWork(object data)
        {
            try
            {
                Console.WriteLine("Поток " + data + " начал работу");
                Thread.Sleep(10000);
                if ((int)data == 0)
                {
                    throw new Exception();

                }
                Console.WriteLine("Поток " + data + " окончил работу");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, data);

            }
           
        }
    }
}
