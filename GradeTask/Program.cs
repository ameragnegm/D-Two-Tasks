using System.Globalization;

namespace GradeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Choose From (A,B,C,D,E):");
            String grade =  Console.ReadLine().ToUpper();
            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Very Good");
                    break;
                case "C":
                    Console.WriteLine("Good");
                    break;
                case "D":
                    Console.WriteLine("Fair");
                    break;
                case "E":
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("No match");
                    break;
            }
            }
    }
}
