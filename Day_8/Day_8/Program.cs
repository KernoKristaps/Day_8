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
      
    }
}
