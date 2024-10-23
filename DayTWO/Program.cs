namespace DayTWO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your three numbers :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 )
            {
                if (num1 > num3)
                {
                Console.WriteLine($"The largest is {num1}");
                }
                else if (num3 > num2)
                    {
                        Console.WriteLine($"The largest is {num3}");
                    }
                    else
                    {
                        Console.WriteLine($"The largest is {num2}");
                    }
            }else
            {
                if (num3 > num2)
                {
                    Console.WriteLine($"The largest is {num3}");
                }
                else
                {
                    Console.WriteLine($"The largest is {num2}");
                }
            }
            


        }
    }
}
