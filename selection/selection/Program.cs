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
             //   case 3: 
                    

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
    }
}
