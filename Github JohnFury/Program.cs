using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_JohnFury
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írja be, hány számot fog beadni!");
            int[] szamok=new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Kérek "+ szamok.Length +" számot.");
            
            int seged = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Írja be a "+(i+1)+". számot");
                szamok[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < szamok.Length; i++)
            {
                if (seged<szamok[i])
                {
                    seged = szamok[i];
                }
            }
            Console.WriteLine("A legnagyobb szám: "+seged);
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            
        }
    }
}
