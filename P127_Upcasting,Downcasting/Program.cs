using System;

namespace P127_Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Ismayil ismayilov";
			//Console.WriteLine(word.Length);
			//Console.WriteLine(word.toCapitalized().Length);



			Console.WriteLine(word.customContain("yilo"));

            //Human human = new Human();
            //human.Name = "Sabir";

            //Teacher teacher = new Teacher();

            //teacher.Academy = "Code";

            //human.Info();
            //teacher.Info();

            //human = teacher;

            //human.Info();

            Samoyed samoyed = new Samoyed();

            Dog dog = new Samoyed();


            //Console.WriteLine(dog.GetType());


            //Animal animal = new Samoyed();
            Animal lion = new LionFish();
            //lion.
            //Animal lion = new Samoyed();
            Animal animal = new Samoyed();
            //LionFish lionFish = lion as LionFish;
            Console.WriteLine(lion);
            if(lion is LionFish)
            {
                LionFish lionFish = (LionFish)lion;
            }
            else
            {
                Console.WriteLine("Error");
            }
            //lionFish.Poison = "Deadly";

            Manat manat = new Manat() { Azn = 200};
            Dollar dollar = (Dollar)manat;
            Console.WriteLine(dollar.Usd);
        }
    }


    class Manat
    {
        public int Azn;

        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar { Usd = manat.Azn * 2 };
        }
    }

    class Dollar
    {
        public int Usd;
    }


    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Dog:Animal
    {
        public abstract void Bark();
    }

    abstract class Fish:Animal
    {
        public abstract void Swim();
    }

    class Samoyed : Dog
    {
        public string Fur;
        public override void Bark()
        {
            Console.WriteLine("hav");
        }

        public override void Eat()
        {
            Console.WriteLine("Pedigree");
        }
    }

    class LionFish : Fish
    {
        public string Poison;
        public override void Eat()
        {
            Console.WriteLine("Small fish");
        }

        public override void Swim()
        {
            Console.WriteLine("blop blop");
        }
    }
}
