using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Logs
    {
        public String fileName;
        String text;

        public Logs(String fileName)
        {
            this.fileName = fileName;
        }

        public void writeEven(String textEvent)
        {
            text = "";

            try
            {
                using (StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(fileName, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(DateTime.Now + " " + textEvent);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
