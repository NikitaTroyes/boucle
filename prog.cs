using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32];

            int i = 0;
            while (i < moves.Length)
            {

                Console.WriteLine("entre un mouvement : ");
                string typeDeMove = Console.ReadLine();

                if (typeDeMove == "done")
                {

                    break;

                }

                moves[i] = typeDeMove;
                i = i + 1;


            }

            Console.WriteLine("Nombre de répétitions : ");
            int repetition = Int32.Parse(Console.ReadLine());

            for (int initiation = 0; initiation < repetition; initiation++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.WriteLine("Move n°" + (x + 1) + " : " + moves[x]);
                }
            }

            Console.ReadLine();




        }
    }
}
