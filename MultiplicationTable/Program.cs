namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 2 & 9 :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 9 && number >= 2)
            {
                Console.WriteLine($" Multiplication Table for  number {number}");
                for (int i = 1; i <= 12; i++)
                {
                   
                        Console.Write($" {number} * {i} = {i * number}  ");
                    
                }
            }else
            {
                Console.WriteLine(" Enter a valid number");
            }
        }
    }
}
