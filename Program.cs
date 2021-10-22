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

            Console.WriteLine("mannen, gissa ett tal mellan 1 och 100");

            int tries = Check();

            Console.WriteLine("yup");
            Console.WriteLine("u right");
            Console.WriteLine("it was " + secNum);

            Console.WriteLine("men du tog många, många försök, exakt " + tries + "försök faktiskt");
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
                    Console.WriteLine("sorry man, för högt");
                }else if(g < secNum){
                    Console.WriteLine("nope, too low");
                }
            }

        }

    }
}
