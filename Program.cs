using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //(a) Explain why this code is inefficient. Reference what happens in memory
            //------------------------------------------------------------------------------------
            //-- In C#, strings are immutable

            //--Each += operation creates a new string object in memory

            //-------------------------------------------------------------------------------------
            //(b) Rewrite this code using StringBuilder to be more efficient.
            //-------------------------------------------------------------------------------------
            //StringBuilder sb = new StringBuilder();

            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append(i).Append(",");
            //}
            //string result = sb.ToString();
            //Console.WriteLine(result);

            //----------------------------------------------------------------------------------------
            //(c)Add timing code(using Stopwatch) to both versions and report the time difference. 
            //----------------------------------------------------------------------------------------
            //Stopwatch sw = new Stopwatch();
            //sw.Restart();
            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append(i).Append(",");
            //}
            //sw.Stop();
            //Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds + " ms");
            #endregion

            #region Question 2
            //Console.Write("Enter age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Enter day of week (1–7): ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Do you have a student ID? (yes/no): ");
            //bool isStudent = Console.ReadLine().ToLower() == "yes";
            //double price = 0;
            //if (age < 5)
            //    price = 0;
            //else if (age <= 12)
            //    price = 30;
            //else if (age <= 59)
            //    price = 50;
            //else
            //    price = 25;
            //if (price > 0 && (day == 6 || day == 7))
            //    price += 10;
            //if (price > 0 && isStudent)
            //    price *= 0.8;
            //Console.WriteLine("Final Ticket Price: " + price + " EGP");
            #endregion
        }
    }
}
