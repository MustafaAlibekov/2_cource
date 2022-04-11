using System;
using System.Linq;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pas1 = Console.ReadLine();
            string Pas2 = "Serega123";
            //Console.WriteLine(String.Compare(Pas1,Pas2));
            int i = String.Compare(Pas1, Pas2);
            if ( i  == 0)
            {
                Console.WriteLine("Пароль верный");
            }
            else
            {
                Console.WriteLine("Пароль неверный");
            }
        }
    
       
        
    
}
}
