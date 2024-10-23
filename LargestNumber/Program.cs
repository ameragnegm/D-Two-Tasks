namespace DayTWO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your three numbers :");
            int[] numbers = new int[3];
            int inputNum , largestNum ;
            for (int i = 0; i < numbers.Length; i++) {
               inputNum = Convert.ToInt32(Console.ReadLine());
                numbers[i] = inputNum;
            }
            largestNum = numbers[0];
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > largestNum)
                {
                    largestNum = numbers[i];
                }
               
            }
            Console.WriteLine($"The largest : {largestNum}");
        

        }
    }
}
