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

        }
    }
}