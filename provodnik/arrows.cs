using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik
{
    internal class arrows
    {
        public int[] strel(int x)
        {
            int[] result = new int[2];
            int poz = 2;
            int piz = poz;
            Console.SetCursorPosition(0, poz);
            Console.WriteLine("->");
            ConsoleKeyInfo Clavisha = Console.ReadKey();
            while(true)
            {
                if (Clavisha.Key == ConsoleKey.UpArrow)
                {
                    poz--;
                    if (poz <= 2)
                    {
                        poz = x+1;
                    }
                }
                if (Clavisha.Key == ConsoleKey.DownArrow)
                {
                    poz++;
                    if (poz >= x+1)
                    {
                        poz = 2;
                    }
                }
                result[0] = poz;
                if(Clavisha.Key == ConsoleKey.Enter)
                {
                    return result; 
                }
                if (Clavisha.Key == ConsoleKey.Escape)
                {
                    result[1] = -1;
                    return result;
                }
                if (Clavisha.Key == ConsoleKey.F1)
                {
                    result[1] = -2;
                    return result;
                }
                if (Clavisha.Key == ConsoleKey.F2)
                {
                    result[1] = -3;
                    return result;
                }
                if (Clavisha.Key == ConsoleKey.F3)
                {
                    result[1]= -4;
                    return result;
                }
                
                Console.SetCursorPosition(0, piz);
                Console.WriteLine("  ");
                Console.SetCursorPosition(0,poz);
                Console.WriteLine("->");
                piz = poz;
                Clavisha = Console.ReadKey();
            }
            
        }
    }
}