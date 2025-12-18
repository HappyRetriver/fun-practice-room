using System;
namespace choijaewon
{
    public class ch1 
    { 
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("값을 입력하시오");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                    number += 2;
                else
                    number += 1;
                Console.Write("결과 값:");
                Console.WriteLine(number);
            }
        }
    }
}