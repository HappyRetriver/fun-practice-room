using System;
namespace choijaewon{
    class progam{

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("숫자를 입력하시오");
            int x = int.Parse(Console.ReadLine());

            char z;
            while (true)
            {
                Console.WriteLine("+, -, /, *");
                z = Console.ReadLine()[0];

                if (z == '+' || z == '-' || z == '/' || z == '*')
                    break;
            }
            Console.WriteLine("숫자를 입력하시오");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("입력된 값");
            Console.WriteLine($"{x}{z}{y}");

            int result = 0;
            if (z == '+')
            { result = x + y; }
            else if (z == '-') { result = x - y; }
            else if (z == '*') { result = x * y; }
            else if (z == '/') { result = x / y; }

            Console.WriteLine("값은");
            Console.WriteLine($"{result}");

            Console.WriteLine("초기화p, 다시시작 엔터");
            string input = Console.ReadLine();
                if (input =="q") ;
                break;
            }
        }
    }
   
}