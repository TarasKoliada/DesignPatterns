using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab6
{
    class Extractor
    {
        public List<string> ExtractNumbers(string content)
        {
            List<string> list = new List<string>();
            var pattern = @"([a-zA-Z]+)|([0-9]+)";
            Regex regex = new Regex(pattern);
            foreach (var match in regex.Matches(content))
            {
                list.Add(match.ToString());
            }

            var numbersList = list.Where(val => int.TryParse(val, out int parsed) == true);
            return numbersList.ToList();
        }

        public List<string> ExtractString(string content)
        {
            List<string> list = new List<string>();
            var pattern = @"([a-zA-Z]+)|([0-9]+)";
            Regex regex = new Regex(pattern);
            foreach (var match in regex.Matches(content))
            {
                list.Add(match.ToString());
            }

            var numbersList = list.Where(val => int.TryParse(val, out int parsed) == false);
            return numbersList.ToList();
        }

        public Match ExtractDates(string content)
        {
            if (Regex.IsMatch(content, @"(\d{1,2}\s+\w+\s+\d{4})"))
            {
                Regex regexObj = new Regex(@"(\d{1,2}\s+\w+\s+\d{4})");
                Match matchResults = regexObj.Match(content);
                while (matchResults.Success)
                {
                    DateTime dte = DateTime.ParseExact(matchResults.Value, "d MMMM yyyy", CultureInfo.GetCultureInfo("en-GB"));
                    Console.WriteLine(dte.ToShortDateString());
                    matchResults = matchResults.NextMatch();
                }
                return matchResults;
            }
            else if (Regex.IsMatch(content, @"(\d{1,2}[./]\d{1,2}[./]\d{4})"))
            {
                Regex regexObj = new Regex(@"(\d{1,2}[./]\d{1,2}[./]\d{4})");
                Match matchResults = regexObj.Match(content);
                while (matchResults.Success)
                {
                    DateTime dte = DateTime.ParseExact(matchResults.Value.Replace(".", "/"), "d/M/yyyy", CultureInfo.GetCultureInfo("en-GB"));
                    Console.WriteLine(dte.ToShortDateString());
                    matchResults = matchResults.NextMatch();
                }
                return matchResults;
            }
            return null;
            
        }
    }
}
