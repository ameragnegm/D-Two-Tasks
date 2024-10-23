namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, number = 0;    
            Console.WriteLine(" Enter Your Numbers:");
            for (int i = 0; sum < 100; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine($" Your sum {sum} exceeds 100 now");
        }
    }
}
