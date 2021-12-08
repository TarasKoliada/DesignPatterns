using Lab6.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {;
            //word C:\Users\Legion\OneDrive\Desktop\test.docx
            //pdf file:///C:/Users/Legion/Downloads/Telegram%20Desktop/62885909.pdf

            Processor processor = new Processor();
            processor.Process();

        }
    }
}
