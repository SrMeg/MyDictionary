using System;
using System.Collections.Generic;
using System.Text;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string, string> word = new MyDictionary<int, string, string>();
            word.Add(1, "Flower", "Çiçek");
            word.Add(2 , "Door", "Kapı");
            word.Add(3 , "Computer", "Bilgisayar");
            word.Add(4 , "Light", "Işık");

            


            foreach (var Id in word.Id)
            {
                Console.Write(Id+", ");
            }

            Console.WriteLine(" ");
            foreach (var En in word.englishWord)
            {
                Console.Write(En+", ");
            }
            Console.WriteLine(" ");
            foreach (var Tr in word.turkishWord)
            {
                Console.Write(Tr + ", ");
            }

        }
    }

    
}