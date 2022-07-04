namespace Hello
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            {
            Console.Clear();
            Console.WriteLine("Введите целое положительное трёхзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string x = Convert.ToString(number);
            Console.WriteLine($"-> {x[1]}");
            }
        }
    }
}
