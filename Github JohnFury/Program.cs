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
            Console.WriteLine("Kérek 10 számot.");
            int[] szamok=new int[10];
            int seged = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Írja be a "+(i+1)+". számot");
                szamok[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
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
