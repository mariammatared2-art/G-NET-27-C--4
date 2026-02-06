using System;
using System.Diagnostics;
using System.Reflection.Metadata;
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

            #region Question 3
            // (a)A traditional switch statement
            //string fileExtension = ".pdf";
            //string fileType;

            //switch (fileExtension )
            //{
            //    case ".pdf":
            //        fileType = "**PDF Document**";
            //        break;
            //    case ".docx":
            //    case ".doc":
            //        fileType = "**Word Document**";
            //        break;
            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "**Excel Spreadsheet**";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "**Image File**";
            //        break;
            //    default:
            //        fileType = "**Unknown File Type**";
            //        break;
            //}
            //Console.WriteLine(fileType);
            //(b) A switch expression  
            //string fileExtension = ".pdf";
            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "**PDF Document**",
            //    ".docx" or ".doc" => "**Word Document**",
            //    ".xlsx" or ".xls" => "**Excel Spreadsheet**",
            //    ".jpg" or ".png" or ".gif" => "**Image File**",
            //    _ => "**Unknown File Type**"
            //};
            //Console.WriteLine(fileType);

            #endregion

            #region Question 4
            //Rewrite the following using only ternary operators(no if statements):

            //int temperature = 35;
            //string weatherAdvice;

            //weatherAdvice = (temperature < 0) ? "Freezing! Stay indoors." :
            //                (temperature < 15) ? "Cold. Wear a jacket." :
            //                (temperature < 25) ? "Pleasant weather." :
            //                (temperature < 35) ? "Warm. Stay hydrated." :
            //                "Hot! Avoid sun exposure.";

            //Then answer: Is the ternary version more readable? 
            //   -- the ternary version is less readable

            //    When would you choose one over the other ? 
            //     --choose if statements:
            //        When conditions are complex
            //        When clarity and maintainability are paramount
            //    -- choose the ternary operator  
            //        It should be used for simple, straightforward decisions

            #endregion

            #region Question 5

            //int MIN_LENGTH = 8;
            //int MAX_ATTEMPTS = 5;

            //int attempts = 0;
            //bool passwordAccepted = false;
            //string password;

            //do
            //{
            //    Console.WriteLine($"\nEnter a password (Attempt {attempts + 1} of {MAX_ATTEMPTS}):");
            //    password = Console.ReadLine();
            //    attempts++;
            //    bool hasMinLength = password.Length >= MIN_LENGTH;
            //    bool hasUppercase = false;
            //    bool hasDigit = false;
            //    bool hasNoSpaces = !password.Contains(" "); 

            //    foreach (char c in password)
            //    {
            //        if (char.IsUpper(c)) hasUppercase = true;
            //        if (char.IsDigit(c)) hasDigit = true;
            //    }
            //    passwordAccepted = hasMinLength && hasUppercase && hasDigit && hasNoSpaces;

            //    if (passwordAccepted)
            //    {
            //        Console.WriteLine("\n**Password accepted!**");
            //        break; 
            //    }
            //    else if (attempts >= MAX_ATTEMPTS)
            //    {
            //        Console.WriteLine("\n**Account locked.** Exiting program.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nInvalid password. Rules violated:");
            //        if (!hasMinLength) Console.WriteLine("- Minimum 8 characters required.");
            //        if (!hasUppercase) Console.WriteLine("- At least one uppercase letter required.");
            //        if (!hasDigit) Console.WriteLine("- At least one digit required.");
            //        if (!hasNoSpaces) Console.WriteLine("- No spaces allowed.");
            //    }

            //} while (!passwordAccepted && attempts < MAX_ATTEMPTS);
            //Console.ReadKey();
            #endregion

            #region Question 6
    
                //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

                //Console.WriteLine("--- Array Processing Results ---");

                //// (a) Find and display all failing scores (below 50) using foreach ---
                //Console.WriteLine("\na) Failing scores (below 50):");
                //foreach (int score in scores)
                //{
                //    if (score < 50)
                //    {
                //        Console.WriteLine(score);
                //    }
                //}

                //// (b) Find the first score above 90 and stop searching immediately using for ---
                //Console.WriteLine("\nb) First score above 90 (stop searching immediately):");
                //for (int i = 0; i < scores.Length; i++)
                //{
                //    if (scores[i] > 90)
                //    {
                //        Console.WriteLine(scores[i]);
                //        break; 
                //    }
                //}

                ////  (c) Calculate the class average, excluding any scores below 40 using while ---
                //Console.WriteLine("\nc) Class average (excluding scores below 40):");
                //int sum = 0;
                //int count = 0;
                //int index = 0;

                //while (index < scores.Length)
                //{
                //    int currentScore = scores[index];
                //    index++;

                //    if (currentScore < 40)
                //    {
                //        continue; 
                //    }

                //    sum += currentScore;
                //    count++;
                //}

                //if (count > 0)
                //{
                //    double average = (double)sum / count;
                //    Console.WriteLine($"Average: {average:F2}");
                //}
                //else
                //{
                //    Console.WriteLine("No valid scores to calculate average.");
                //}

                ////  (d) Count how many students scored in each grade range using foreach and switch ---
                //Console.WriteLine("\nd) Count students in each grade range:");
                //int countA = 0, countB = 0, countC = 0, countD = 0, countF = 0;

                //foreach (int score in scores)
                //{
                //    switch (score)
                //    {
                //        case int n when n >= 90:
                //            countA++;
                //            break;
                //        case int n when n >= 80:
                //            countB++;
                //            break;
                //        case int n when n >= 70:
                //            countC++;
                //            break;
                //        case int n when n >= 60:
                //            countD++;
                //            break;
                //        default:
                //            countF++;
                //            break;
                //    }
                //}

                //Console.WriteLine($"A (90-100): {countA}");
                //Console.WriteLine($"B (80-89): {countB}");
                //Console.WriteLine($"C (70-79): {countC}");
                //Console.WriteLine($"D (60-69): {countD}");
                //Console.WriteLine($"F (Below 60): {countF}");

                //Console.WriteLine("\n--- End of Results ---");
    
        #endregion
    }
}
}
