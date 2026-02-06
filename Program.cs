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

        }
    }
}
