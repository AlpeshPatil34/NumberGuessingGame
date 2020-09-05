using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int equi = r.Next(1,100); 

            bool xqc = false;

            do
            {
                 Console.WriteLine("Hello, please enter a number: ");
                 string s1 = Console.ReadLine();
                 int s = Convert.ToInt32(s1);
                 if (s>equi)
                 {
                     Console.WriteLine("Too High!");
                 }
                 else if (s<equi)
                 {
                     Console.WriteLine("Too Low!");
                 }
                 else if (s == equi)
                 {
                     Console.WriteLine("Just Right!");
                     xqc = true;
                 }

            } while (xqc == false);            
           
        }
    }
}
