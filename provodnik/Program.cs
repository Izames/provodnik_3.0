using provodnik;
namespace work
{
    internal class go
    {
        public static void Main()
        {
            List<string> ssilkaList = new List<string>();
            string[] array;
            int x = 0; /*Вначале служит для счета сколько дисков*/
            string help;

            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Выбор диска\n----------------------------------------------------------------------------------");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.Write("\t" + drive.Name);
                Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Гб свободно из " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                x++;
            }
            arrows arrow = new arrows();
            int[] y = arrow.strel(x); /*короткие стрелки*/
            array = papki.dir(Convert.ToString(drives[y[0] - 2]), y[0] -2);
            ssilkaList.Add(Convert.ToString(drives[y[0] - 2]));
            while (true)
            {
                y = arrow.strel(array.Length);
                if (y[1] < -1)
                {
                    if (y[1] == -2)
                    {
                        dlc.dop1(ssilkaList[ssilkaList.Count - 1]);
                    }
                    else if (y[1] == -3)
                    {
                        dlc.dop2(ssilkaList[ssilkaList.Count - 1]);
                    }
                    else if(y[1] == -4)
                    {
                        dlc.dop3(array[y[0] - 2]);
                    }
                    Console.Clear();
                    ssilkaList.Clear();
                    x = 0;
                    Console.SetCursorPosition(20, 0);
                    Console.WriteLine("Выбор диска\n----------------------------------------------------------------------------------");
                    foreach (DriveInfo drive in drives)
                    {
                        Console.Write("\t" + drive.Name);
                        Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Гб свободно из " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                        x++;
                    }
                    y = arrow.strel(x);
                    array = papki.dir(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
                    ssilkaList.Add(Convert.ToString(drives[y[0] - 2]));
                }
                if (y[1] == -1)
                {
                    if (ssilkaList.Count == 1)
                    {
                        Console.Clear();
                        x= 0;
                        Console.SetCursorPosition(20, 0);
                        Console.WriteLine("Выбор диска\n----------------------------------------------------------------------------------");
                        foreach (DriveInfo drive in drives)
                        {
                            Console.Write("\t" + drive.Name);
                            Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Гб свободно из " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                            x++;
                        }
                        y = arrow.strel(x); /*короткие стрелки*/
                        array = papki.dir(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
                        ssilkaList.Add(Convert.ToString(drives[y[0] - 2]));
                    }
                    else
                    {
                        ssilkaList.RemoveAt(ssilkaList.Count - 1);                        
                        array = papki.dir(ssilkaList[ssilkaList.Count - 1], 0);                    
                    }
                   
                }
                /*else if (y[1] == -2)
                {
                    dlc.dop1(ssilkaList[ssilkaList.Count - 1]);
                    Console.Clear();
                    ssilkaList.Clear();
                    x = 0;
                    Console.SetCursorPosition(20, 0);
                    Console.WriteLine("Выбор диска\n----------------------------------------------------------------------------------");
                    foreach (DriveInfo drive in drives)
                    {
                        Console.Write("\t" + drive.Name);
                        Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Гб свободно из " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                        x++;
                    }
                    y = arrow.strel(x);
                    array = papki.dir(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
                    ssilkaList.Add(Convert.ToString(drives[y[0] - 2]));
                }
                else if (y[1] == -3)
                {
                    dlc.dop2(ssilkaList[ssilkaList.Count - 1]);
                    Console.Clear();
                    ssilkaList.Clear();
                    x = 0;
                    Console.SetCursorPosition(20, 0);
                    Console.WriteLine("Выбор диска\n----------------------------------------------------------------------------------");
                    foreach (DriveInfo drive in drives)
                    {
                        Console.Write("\t" + drive.Name);
                        Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Гб свободно из " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                        x++;
                    }
                    y = arrow.strel(x);
                    array = papki.dir(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
                    ssilkaList.Add(Convert.ToString(drives[y[0] - 2]));
                }
                else if (y[1]== -4)
                {
                    dlc.dop3(array[y[0] - 2]);
                    Console.Clear();
                    ssilkaList.Clear();
                    x = 0;
                    Console.SetCursorPosition(20, 0);
                    Console.WriteLine("Выбор диска\n----------------------------------------------------------------------------------");
                    foreach (DriveInfo drive in drives)
                    {
                        Console.Write("\t" + drive.Name);
                        Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Гб свободно из " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                        x++;
                    }
                    y = arrow.strel(x);
                    array = papki.dir(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
                    ssilkaList.Add(Convert.ToString(drives[y[0] - 2]));
                }*/
                else
                {
                    ssilkaList.Add(Convert.ToString(array[y[0] - 2]));
                    array = papki.dir(Convert.ToString(array[y[0] - 2]), y[0] - 2);                  
                }               
            }
        }
    }
}