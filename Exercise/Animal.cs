using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    abstract class Animal
    {
        private int weight;
        private string name;
        public abstract void Speak();

        public abstract void Move();

        public abstract void ToString();


    }

    class Cat:Animal
    {
        public override void Move()
        {
            Console.WriteLine("Cat is slow in movement");
            
        }

        public override void Speak()
        {
            Console.WriteLine("Cat meows in speech");
              
        }

        public override void ToString()
        {
            int weight = 56;
            string name = "Domestic Cat";
            Console.WriteLine("the weight of {0} is {1}",name, weight.ToString());
        }
    }


    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Dog is fast in movement");

        }

        public override void Speak()
        {
            Console.WriteLine("Dog barks");

        }

        public override void ToString()
        {

            int weight = 76;
            string name = "Bingo";
            Console.WriteLine("the weight of {0} is {1}", name, weight.ToString());
        }
    }

}
