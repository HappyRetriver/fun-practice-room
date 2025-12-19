using System;
namespace choi 
{
    public class perent{
        public virtual void speak()
        {
            Console.WriteLine("부모동작");
        }
    }
    class chid : perent {
        public override void speak()
        {
            Console.WriteLine("부모동작");
        }
       
    }

}
