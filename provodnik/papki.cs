using provodnik;
using System.Diagnostics;

namespace provodnik
{
    internal class papki
    {
        public static string[] dir(string dirname, int opr)
        {
            int izo = 0;
            int i = 0;
            int fordate = 2;
            Console.Clear();
            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Выбор файла\n----------------------------------------------------------------------------------");
            while (izo != 30)
            {
                Console.SetCursorPosition(81, izo);
                Console.WriteLine("|");
                izo++;
            }
            Console.SetCursorPosition(84, 3);
            Console.WriteLine("F1 - создать файл");
            Console.SetCursorPosition(84, 5);
            Console.WriteLine("F2 - создать папку");
            Console.SetCursorPosition(84, 7);
            Console.WriteLine("F3 - удалить папка систем 32");
            Console.SetCursorPosition(82, 8);
            Console.WriteLine("---------------------------------");
            if (Directory.Exists(dirname)) 
            {
                string[] Directories = Directory.GetDirectories(dirname);
                foreach (string dir in Directories)
                {
                    Console.SetCursorPosition(2, fordate);
                    Console.WriteLine(dir);
                    Console.SetCursorPosition(50, fordate);
                    Console.WriteLine(Directory.GetCreationTime(dir));
                    fordate++;
                }
                string[] files = Directory.GetFiles(dirname);
                foreach (string file in files)
                {
                    Console.SetCursorPosition(2, fordate);
                    Console.WriteLine(file);
                    Console.SetCursorPosition(50, fordate);
                    Console.WriteLine(Directory.GetCreationTime(file));
                    fordate++;
                }
                string[] array = new string[files.Length + Directories.Length];
                foreach (string file in Directories)
                {
                    array[i++] = file;
                }
                foreach (string file in files)
                {
                    array[i++] = file;
                }
                return array;
            }
            else
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = dirname,
                    UseShellExecute = true
                });
                string []f = new string[1];
                return f ;
            }           
        }
    }
}
