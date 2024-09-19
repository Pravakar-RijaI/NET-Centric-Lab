using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CollegeProgram
{
    /*public class Person
    {
        public int CitizenshipNo;
        public string Name { get; set; }
        private byte _age;
        public byte Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 110)
                    _age = value;
                else
                    Console.WriteLine("Invalid Age");
            }
        }

        public void Introduce()
        {
            Console.WriteLine(this.Name + " with Citizenship No. "
                + this.CitizenshipNo + " is " + this.Age + " years old.");
        }

    }*/
    /* public class Person
     {
         private string Name;
         private byte Age;

         public Person()
         {
             this.Name = "No Name";
             this.Age = 0;
         }

         public Person(string name)
         {
             this.Name = name;
         }

         public Person(string name, byte age)
         {
             this.Name = name;
             this.Age = age;
         }

         public void Introduce()
         {
             Console.WriteLine(this.Name + " is of Age " + this.Age);
         }

     }*//*
     public class Class1
     {
         public int _id;
         public Class1(int id)
         {
             _id = id;
         }
     }

     public class Class2 : Class1
     {
         private string _name;
         public Class2(int id, string name)
             : base(id)
         {
             _name = name;
         }
         public void Introduce()
         {
             Console.WriteLine($"{_name} has an ID:{base._id}");
         }
     }*/

    /* public partial class Person
     {
         private int _id;
         public string Name { get; set; }

         public Person(int id, string name)
         {
             _id = id;
             Name = name;
         }
     }

     //This class can be placed in any other file.
     public partial class Person
     {
         public void Introduce()
         {
             Console.WriteLine($"{Name} has an ID:{_id}");
         }
     }
     public class DisplayData
     {
         public void Display()
         {
             Console.WriteLine("Displaying First Method...");
         }

         public void Display(int id)
         {
             Console.WriteLine($"Display Second Method with ID:{id}.");
         }

         public void Display(string name)
         {
             Console.WriteLine($"Display Third Method with Name:{name}.");
         }
     }
 */


    internal class Program
    {
        /*public static void ModifyValue(int num)
        {
            num = 20;
            Console.WriteLine($"In Method\nValue: {num}");
        }*/
        internal class Modify
        {
            public virtual void Display()
            {
                Console.WriteLine("This is good");
            }
        }
        

        internal class NoModify : Modify
        {
            public sealed override void Display()
            {
                base.Display();
                Console.WriteLine("This is perfect");
            }
        }

        internal class Simple : NoModify
        {
           public override void Display()
            {
                Console.WriteLine("this is not good.");
            }
        }

        public static void ModifyValue(int num)
        {
            num = 20;
            Console.WriteLine($"In Method\nValue: {num}");
        }
        internal static void Main()
        {
            Simple M1 = new Simple();
            M1.Display();


            /*List<string> Names = new List<string>();
            Names.Add("Sheldon Cooper");
            Names.Add("Mary Cooper");
            Names.Add("George Cooper");
            Names.Add("George Jr");
            Names.Add("Mandy Cooper");
            Console.WriteLine($"Names List- Count:{Names.Count}");
            Console.WriteLine($"Names List- Capacity:{Names.Capacity}");
            Console.WriteLine("Names:");
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }*/

            /*DisplayData D1 = new DisplayData();
            D1.Display();
            D1.Display(56);
            D1.Display("Felix Kjellberg");*/

            /*Person Obj = new Person(42, "Tuco Salamanca");
            Obj.Introduce();*/

            /*Class2 Obj = new Class2(101, "Jesse Pinkman");
            Obj.Introduce();
*/
            /*Person P1 = new Person();
            P1.Introduce();
            Person P2 = new Person("Walter White");
            P2.Introduce();
            Person P3 = new Person("Walter White", 52);
            P3.Introduce();*/


            /* Person P1 = new Person();
             P1.CitizenshipNo = 31121;
             P1.Name = "Robert California";
             P1.Age = 42;
             P1.Introduce();*/

            /* string[] Names = new string[4]
 { "Andy", "Creed", "Kelvin", "Dwight" };
             int Count = 0;
             foreach (string Name in Names)
             {
                 Console.WriteLine("Array[{0}]: {1}", Count, Name);
                 Count++;
             }*/

            /*string Name = "";
            while (Name == "") 
            {
                Console.WriteLine("Enter Your Name: ");
                Name = Console.ReadLine();
            }
            Console.WriteLine("Your name must be {0}.", Name);*/

            /*Console.Write("Enter Your Name: ");
            // Take input from user and store it in variable
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");*/


            //FILE
            /*string ConsoleInput;
            StreamWriter wr = new StreamWriter("C:\\Users\\USER\\Documents\\PRAVAKAR\\NET Centric\\file.txt");
            Console.WriteLine("Enter the text to write on File: ");
            ConsoleInput = Console.ReadLine();
            wr.WriteLine(ConsoleInput);
            wr.Close();

            string FileOutput;
            StreamReader rw = new StreamReader("C:\\Users\\USER\\Documents\\PRAVAKAR\\NET Centric\\file.txt");
            FileOutput = rw.ReadLine();
            Console.WriteLine("Output from file: \n" + FileOutput);*/
        }
    }
}
