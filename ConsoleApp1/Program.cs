using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("loop : ");
            int n = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=1;i<=n;i++)
            {
                Console.Write("Number "+i+":");
                int input = Int32.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);


            while (true) {

            Console.Write("Stop");
            string xxx = Console.ReadLine();
            if (xxx == "y")
            {
                int sum2 = 0;
                Console.Write("loop : ");
                int n2 = Int32.Parse(Console.ReadLine());
                for (int i = 1; i <= n2; i++)
                {
                    Console.Write("Number " + i + ":");
                    int input2 = Int32.Parse(Console.ReadLine());
                    sum2 += input2;
                }
                    Console.WriteLine(sum2);
                }
                else {
                Console.WriteLine("Buy");break;
            }
            }

        }
    }
}
