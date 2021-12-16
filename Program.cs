using System;

namespace LB4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Cuckoo cuckoo = new Cuckoo();
            Sitter sitter = new Sitter();
            sitter.hatchchicks();
            cuckoo.sing();
            bird.fly();
            bird.layeggs();
        }

    }
    class Bird
    {

        public void fly()
        {
            Console.WriteLine("*cuckoo flying*");
        }
        public void layeggs()
        {
            Console.WriteLine("*cuckoo lay eggs*");
        }
    }
    class Cuckoo : Bird
    {
        public void fly(Bird bird)
        {
            bird.fly();
        }

        public void layeggs(Bird bird)
        {
            bird.layeggs();
        }
        public void sing()
        {
            Console.WriteLine("*cuckoo sign*");
        }
    }
    class Sitter : Cuckoo
    {
        public void hatchchicks()
        {
            Console.WriteLine("*cuckoo hatchs chicks*");
        }
    }
}