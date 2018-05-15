using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Masivs();
            JaunaZvaigzne();
            Uzdevums();

            Console.ReadLine();
        }
        


        static void Masivs()
        {
            int[] masivs = new int[4];
            masivs[0] = 1;
            masivs[1] = 5;
            masivs[2] = 7;
            masivs[3] = 6;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\n" + masivs[i]);
            }
            
        }
        static void JaunaZvaigzne()
        {
            string[] zvaigzne = new string[3];
            zvaigzne[0] = "*";
            zvaigzne[1] = "**";
            zvaigzne[2] = "***";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n" + zvaigzne[i]);
            }
          
        }
        static void Uzdevums()
        {
            
            string[] ievade = new string[5];
            int[] izvade = new int[5];
           

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n" + "Ievadiet " + i + " vertiba");
                ievade[i] = Console.ReadLine();
                izvade[i] = Convert.ToInt32(ievade[i]);
                
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n" + izvade[i]);

                Console.WriteLine(ievade[i] + "+" );
            }
        }
        //izvade[i] + "=" + ievade[i] + izvade[i]

    }
}
