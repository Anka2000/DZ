using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
namespace Domashechka
{
    static class Program
    {

        static void Main(string[] args)
        {
            Zadanie.Error();

        }
        public static class Zadanie

        {

            public static void Error()
            {
                const string word = "Error";

                using (StreamReader reader = new StreamReader("C:\\Users\\Анна\\Desktop\\log.log", Encoding.UTF8))
                {
                    Regex regex = new Regex("\\b" + word + "\\b", RegexOptions.IgnoreCase);
                    string str = null;
                    while ((str = reader.ReadLine()) != null)
                    {
                        if (regex.IsMatch(str))
                            Console.WriteLine(str);
                    }
                    Console.ReadKey(true);
                }
            }

        }
    }
}