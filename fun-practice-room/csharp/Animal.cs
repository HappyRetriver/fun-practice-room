using System;
namespace choi {
    abstract class Animal 
    {
        public abstract void speak();
    }

    class dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("강아지");
        }
    }
    class deer : Animal
    {
        public override void speak()
        {
            Console.WriteLine("사슴");
        }
    }
    class cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("고양이");
        }

    }

    class program
    {
        static void Main()
        {
            Console.WriteLine("1:강아지, 2: 고양이, 3:사슴 ");
            int input = int.Parse(Console.ReadLine());
            Animal animal = null;
            switch (input)
            {
                case 1:
                    animal = new dog();
                    break;
                case 2:
                    animal = new cat();
                    break;
                case 3:
                    animal = new deer();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    return;
            }
            animal.speak();
        }
    }
}
