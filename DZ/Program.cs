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
            Console.Clear();
            Zadanie.Logi();
        }
        public static class Zadanie

        {
            public static String line;
            public static void Logi()
            {
                try
                {

                    StreamReader sr = new StreamReader("C:\\Users\\Анна\\Desktop\\log.log");

                    line = sr.ReadLine();

                    while (line != null)
                    {

                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }

                    sr.Close();
                    Console.ReadLine();
                }


                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }

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