using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Lab6.Abstraction;
using System;
using System.Text;

namespace Lab6
{
    class PdfParser : IParser
    {
        private readonly string _filePath;
        private string _content;
        public PdfParser(string filePath)
        {
            _filePath = filePath;
            ReadFile();
        }
        public void ParseContent()
        {
            Extractor ex = new Extractor();
            Console.WriteLine("\n\n1) Extract numbers from PDF");
            Console.WriteLine("2) Extract string from PDF");
            Console.WriteLine("3) Extract Dates from PDF");
            Console.WriteLine("4) Read data from PDF");
            Console.Write("Your Choise: ");
            var parsed = int.TryParse(Console.ReadLine(), out int choise);
            if (!parsed)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                ParseContent();
            }

            switch (choise)
            {
                case 1:
                    var numList = ex.ExtractNumbers(_content);
                    Console.WriteLine();
                    foreach (var item in numList)
                    {
                        Console.WriteLine($"{item}  ");
                    }
                    break;
                case 2:
                    var strList = ex.ExtractString(_content);
                    Console.WriteLine();
                    foreach (var item in strList)
                    {
                        Console.WriteLine($"{item}  ");
                    }
                    break;
                case 3:
                    var matches = ex.ExtractDates(_content);
                    Console.WriteLine();
                    if (matches != null)
                    {
                        Console.WriteLine(matches.Value);
                    }
                    else
                    {
                        Console.WriteLine("Dates is not found");
                    }

                    break;
                case 4:
                    var data = ReadFile();
                    Console.WriteLine(data);
                    break;
                case 5:
                    break;
            }
        }

        public string ReadFile()
        {
            using (PdfReader reader = new PdfReader(_filePath))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
                _content = text.ToString();
                return text.ToString();
            }
        }
    }
}
