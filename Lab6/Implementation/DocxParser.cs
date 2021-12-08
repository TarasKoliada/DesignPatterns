using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Lab6.Abstraction;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab6
{
    class DocxParser : IParser
    {
        private string _content;
        private readonly string _filePath;
        public DocxParser(string filePath)
        {
            _filePath = filePath;
            ReadFile();
        }
        public void ParseContent()
        {
            Extractor ex = new Extractor();

            Console.WriteLine("\n\n1) Extract numbers from Word");
            Console.WriteLine("2) Extract string from Word");
            Console.WriteLine("3) Extract Dates from Word");
            Console.WriteLine("4) Read data from Word");
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
                    Console.WriteLine();
                    var data = ReadFile();
                    Console.WriteLine(data);
                    break;
                case 5:
                    break;
            }
                
        }

        public string ReadFile()
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(_filePath, true))
            {
                Body body = wordDoc.MainDocumentPart.Document.Body;
                var contents = "";

                var reg = new Regex(@"^[\s\p{L}\d\•\-\►]");

                foreach (Paragraph co in
                         wordDoc.MainDocumentPart.Document.Body.Descendants<Paragraph>().Where<Paragraph>(somethingElse =>
                         reg.IsMatch(somethingElse.InnerText)))
                {
                    if (co.ParagraphProperties != null || co.ParagraphProperties.NumberingProperties != null)
                    {
                        contents += co.InnerText + "\n";
                    }
                }
                _content = contents;
                return contents;
            }
        }
    }
}
