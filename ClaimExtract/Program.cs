using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClaimExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileText = File.ReadAllText("ClaimData.txt");
            var claimPattern = @"(?<=~CLM\*)([0-9]*)(?=\*)";
            var claimNumbers = Regex.Matches(fileText, claimPattern);
            foreach (var id in claimNumbers)
            {
                Console.Write($"{id}, ");
            }

            var refPattern = @"\~REF\*\*\~";
            var refCount = Regex.Matches(fileText, refPattern).Count;
            Console.WriteLine($"Ref count:{refCount}");
            Console.Read();
        }
    }
}
