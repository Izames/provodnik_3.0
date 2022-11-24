using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik
{
    public class dlc
    {
        public static void dop1(string path)
        {
            Console.SetCursorPosition(84, 9);
            string name = Console.ReadLine();
            File.Create(path + "\\"+name);
        }
        public static void dop2(string path)
        {
            Console.SetCursorPosition(84, 9);
            string name = Console.ReadLine();
            Directory.CreateDirectory(path + "\\" + name);
            
        }
        public static void dop3(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
            else
            {
                File.Delete(path);
            }
        }
    }
}
