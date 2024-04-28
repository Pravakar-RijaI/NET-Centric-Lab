using System;
using System.IO;

namespace CollegeProgram
{ 
    internal class Program
    {
        internal static void Main()
        {
            string ConsoleInput;
            StreamWriter wr = new StreamWriter("C:\\Users\\USER\\Documents\\PRAVAKAR\\NET Centric\\file.txt");
            Console.WriteLine("Enter the text to write on File: ");
            ConsoleInput = Console.ReadLine();
            wr.WriteLine(ConsoleInput);
            wr.Close();

            string FileOutput;
            StreamReader rw = new StreamReader("C:\\Users\\USER\\Documents\\PRAVAKAR\\NET Centric\\file.txt");
            FileOutput = rw.ReadLine();
            Console.WriteLine("Output from file: \n" + FileOutput);
        }
    }
}