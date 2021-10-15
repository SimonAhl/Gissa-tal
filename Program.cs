using System;

namespace easd
{
    class Program
    {
        public static int secNum;
        static void Main(string[] args)
        {
            Random ran = new Random();

            secNum = ran.Next(1, 101);

            Console.WriteLine("HAHAHA FOOL, YOU MAY NEVER GUESS MY [[[NUMBER]]] between 1 and 100");

            int tries = Check();

            Console.WriteLine("shit, uuuh");
            Console.WriteLine("u right");
            Console.WriteLine("it was " + secNum);

            Console.WriteLine("BUT AT LEAST YOUR MONKEY BRAIN TOOK [" + tries + "] TRIES FOOOL");
        }

        public static int Check(){

            int tries = 0;
            while(true){

                tries++;
                int g = int.Parse(Console.ReadLine());

                if (g == secNum){
                    return (tries);
                }
                else if(g > secNum){
                    Console.WriteLine("FOOL,,,,, YOU NEVER STOOD A CHANCE, ITS SIMPLE REALLY, YOURE WRONG, ITS TO HIGH HAHAHAHHAHAHAHHA");
                }else if(g < secNum){
                    Console.WriteLine("JUST LIKE YOUR BRAIN, THIS IS TO LOW");
                }
            }

        }

    }
}
