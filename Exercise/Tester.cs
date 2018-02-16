using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Tester
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[]
            {
                new Dog(), 
                new Cat()
            };
            
            foreach(var c in animal )
            {
                Console.WriteLine(" ");
                c.Speak();
                c.Move();
                c.ToString();
            }


            //2 and 3
            Console.WriteLine("Lets compare the objects");
            OverrideDog DogA = new OverrideDog("Bingo", 76);
            OverrideDog DogB = new OverrideDog(DogA.ToString(), 56);

            var Compare = DogA.Equals(DogB);
            Console.WriteLine("DogA and DogB when compared returns:{0}", Compare);
            Console.ReadLine();

        }
    }
}
