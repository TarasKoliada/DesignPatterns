using Lab6.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Processor
    {
        public void Process()
        {
            //word C:\Users\Legion\OneDrive\Desktop\test.docx
            //pdf file:///C:/Users/Legion/Downloads/Telegram%20Desktop/62885909.pdf
            IParser parser;
            Console.WriteLine("1) WORD");
            Console.WriteLine("2) PDF");
            Console.Write("Your choise: ");
            var parsed = int.TryParse(Console.ReadLine(), out int choise);
            if (!parsed)
            {
                Console.WriteLine("Wrong Input");
                return;
            }

            switch (choise)
            {
                case 1:
                    Console.Write("Enter Path: ");
                    var wordPath = Console.ReadLine();
                    parser = new DocxParser($@"{wordPath}");
                    parser.ParseContent();
                    break;
                case 2:
                    Console.Write("Enter Path: ");
                    var pdfPath = Console.ReadLine();
                    parser = new PdfParser($@"{pdfPath}");
                    parser.ParseContent();
                    break;
            }
        }
    }
}
