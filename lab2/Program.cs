using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            String pathDirectory = Environment.CurrentDirectory + @"\log.txt";
            myThreadPool my = new myThreadPool(9, pathDirectory);
            
            my.Meth();
            my.Meth();
            my.Meth();
            my.Meth();
            my.Meth();
            my.Meth();
            my.Meth();
            my.Meth();

            Console.ReadLine();
        }

    }

   


    

   
}


