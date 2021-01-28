using System;

namespace selection
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            int select = Convert.ToInt32(a1);
            switch(select)
            {
                case 1:
                    string oof = Console.ReadLine();
                    int minorfaults = Convert.ToInt32(oof);
                    PassFail(minorfaults);
                    // I forgot how subroutines work and this works for some reason?
                    break;
                case 2:
                    //forgot how arrays work so doing the states of water one
                    string a2 = Console.ReadLine();
                    double idkwhatthisis = Convert.ToDouble(a2);
                    StatesOfWater(idkwhatthisis);
                    break;
                case 3:
                    //this is the very good quotes one yay so much fun lmao
                    string bruv = Console.ReadLine();
                    im14andthisisdeepquotes(bruv);
                    // capitalize the first letter because I was to lazy to fix it
                    break;
                case 4:
                    string henlo = Console.ReadLine();
                    int numbah = Convert.ToInt32(henlo);
                    string curencylmao = Console.ReadLine();
                    moolah(numbah, curencylmao);
                    break;

                    

            }
            Console.ReadLine();
        }
        static void PassFail(int minorfaults)
        {
            if(minorfaults >= 16)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Pass");
                Console.ReadLine();
            }
        }
        static void StatesOfWater(double idkwhatthisis)
        {
            if(idkwhatthisis >= 100)
            {
                Console.WriteLine("Gaseous");
            }
            if (idkwhatthisis >= 1)
            {
                if(idkwhatthisis <= 99)
                {
                    Console.WriteLine("Liquid");
                }
            }
            if (idkwhatthisis < 1)
            {
                Console.WriteLine("Solid");
            }
        }
        static void im14andthisisdeepquotes(string poggers)
        {
            int ihatemyself = 0;
            if(poggers == "Engineer")
            {
                Console.WriteLine("The Engineer has been, and is, a maker of history.");
                ihatemyself = 1;
            }
            if(poggers == "Developer")
            {
                Console.WriteLine("Logical thinking, passion and perserverance is the pain on your palette.");
                ihatemyself = 1;
            }
            if(poggers == "Analyst")
            {
                Console.WriteLine("Seeing what other people can't see gives you great vision.");
                ihatemyself = 1;
            }
            if(ihatemyself == 0)
            {
                Console.WriteLine("I'm sorry we could not find a quote for your job.");
            }
        }   
        static void moolah(int moneymoney,string curencyspeltwront)
        {
            //pound to USD 1.37
            //pound to Euro 1.13
            //pound to Yuan 8.84
            //pound to Yen  142.56
            double finalmoney = 0;
            if(curencyspeltwront == "USD")
            {
                double math = 1 / 1.37; 
                finalmoney = moneymoney * math;
                    Console.WriteLine(finalmoney);
            }
            if(curencyspeltwront == "Euro")
            {
                double math = 1 / 1.13;
                finalmoney = moneymoney * math;
                Console.WriteLine(finalmoney);
            }
            if(curencyspeltwront == "Yuan")
            {
                double math = 1 / 8.84;
                finalmoney = moneymoney * math;
                Console.WriteLine(finalmoney);
            }
            if (curencyspeltwront == "Yen")
            {
                double math = 1 / 142.56;
                finalmoney = moneymoney * math;
                Console.WriteLine(finalmoney);
            }
        }
    }
}
