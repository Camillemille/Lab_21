
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CallingMethods
{
    public class Animal
    {
        protected string name;
        protected bool hasFur;
        protected int numberOfLegs;
        public Animal()
        {
            //any initialization goes here
        }
        public Animal(string type, bool fur, int legs)
        {
            name = type;
            hasFur = fur;
            numberOfLegs = legs;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public bool HasFur
        {
            get
            {
                return hasFur;
            }
            set
            {
                hasFur = value;
            }
        }
        public int NumberOfLegs
        {
            get
            {
                return numberOfLegs;
            }
            set
            {
                numberOfLegs = value;
            }
        }
        public virtual void Eat()
        {
            Console.WriteLine("food in mouth, swallow!");
            Console.WriteLine("eat, eat!!!");
        }
        public override string ToString()//polymorphism override
        {
            StringBuilder myString = new StringBuilder();
            myString.Append("I have an animal.  ");
            if (name != null)
            {
                myString.Append("It is a ");
                myString.Append(name);
                myString.Append(". ");
            }
            if (hasFur)
            {
                myString.Append("It has fur. ");
            }
            if (numberOfLegs > 0)
            {
                myString.Append("It has ").Append(numberOfLegs).Append(" legs. ");
            }
            return myString.ToString();
        }
    }
    public class Cat : Animal
    {
        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Cat()
        {
            hasFur = true;
            numberOfLegs = 4;
            name = "cat";
        }
        public Cat(string furColor)
        {
            hasFur = true;
            numberOfLegs = 4;
            name = "cat";
            color = furColor;
        }
        public override void Eat()
        {
            Console.WriteLine("Can the cat see the bottom of the food bowl? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("The cat cannot eat because its bowl is empty. It meows pitifully for more food ");
            }
            else
            {
                base.Eat();
            }
        }
        public override string ToString()
        {
            StringBuilder myString = new StringBuilder(base.ToString());
            if (color != null)
            {
                myString.Append("It is a ").Append(color).Append(" cat.");
            }
            return myString.ToString();
        }
        public void ChaseMouse()
        {
            Console.WriteLine("The cat sees a mouse!");
            Console.WriteLine("The cat chases a mouse");
        }
        public void Play(string toy)
        {
            Console.WriteLine("The cat is playing with a" + toy);
            Console.WriteLine("The cat takes a nap,");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animal myCat = new Animal();
            //myCat.Name = "cat";
            //myCat.HasFur = true;
            //myCat.NumberOfLegs = 4;
            //myCat.Eat();
            //Console.WriteLine(myCat.ToString());
            //Console.WriteLine();
            Cat myCat = new Cat("calico");
            Console.WriteLine(myCat.ToString());
            myCat.Eat();
            myCat.ChaseMouse();
            Console.WriteLine();
            Animal myDog = new Animal("dog", true, 4);//polymorphism overload
            Console.WriteLine(myDog.ToString());
            myDog.Eat();

            
        }
    }
}



