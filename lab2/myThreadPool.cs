using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab2
{
    public class myThreadPool
    {
        public List<Thread> listThread;
        public List<Thread> listWait;
        public int countThread;
        public String nameLog;
        public Logs logs;


        public myThreadPool()
        {
            this.countThread = 5;
            listThread = new List<Thread>();
            listWait = new List<Thread>();
            this.logs = new Logs(Environment.CurrentDirectory + @"\log.txt");
            for (int i = 0; i < countThread; i++)
            {
                listThread.Add(new Thread(Mythhread.DoWork));

            }
            logs.writeEven("Было создано " + this.countThread + " потоков");
            Console.WriteLine("Было создано " + this.countThread + " потоков");
        }

        public myThreadPool(int countThread, String nameLog)
        {

            this.countThread = countThread;
            listThread = new List<Thread>();
            listWait = new List<Thread>();
            this.logs = new Logs(nameLog);
            for (int i = 0; i < countThread; i++)
            {
                listThread.Add(new Thread(Mythhread.DoWork));

            }
            logs.writeEven("Было создано " + this.countThread + " потоков");
            Console.WriteLine("Было создано " + this.countThread + " потоков");
        }

        public void Meth()
        {
            
            
            int isFull = 0;
            for (int i = 0; i < listThread.Count; i++)
            {
                try
                {
                    if (listThread[i].IsAlive == false)
                    {
                        isFull = 1;
                        listThread[i].Start(i);
                        logs.writeEven("Поступила новая задача");
                        Console.WriteLine("Поступила новая задача");
                        break;
                    }

                }
                catch (Exception ex)
                {
                    logs.writeEven(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }

            if (isFull == 0)
            {
                listWait.Add(new Thread(Mythhread.DoWork));
                /*for (int i = 0; i < listWait.Count; i++)
                {
                    listThread[i].Join();
                    listWait.RemoveAt(i);
                }*/
                //listWait.Add(new Thread(Mythhread.DoWork));
                logs.writeEven(" Поток переполнен, номер в очереди " + listWait.Count);
                Console.WriteLine(" Поток переполнен, задача поставлена в очередь " + listWait.Count);

            }

        }

        public void checkThread()
        {
            for (int i = 0; i < listThread.Count; i++)
            {
                Console.WriteLine("isAlive " + listThread[i].IsAlive);
            }
        }

    }

}
