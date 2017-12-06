using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace ConsoleLibrary
{

    public class ConsoleTools
    {
        private static int[,] Arr2FromFile(bool square)
        {
            while (true)
            {
                try
                {
                    Console.Write("имя файла: ");
                    Array2FileTools array2File = new Array2FileTools(Console.ReadLine());
                    int[,] arr2 = array2File.Read();
                    if(square && arr2.GetLength(0) != arr2.GetLength(1))
                    {
                        throw new Exception("двумерный массив не квадратный");
                    }
                    return arr2;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static int[,] Arr2FromConsole(bool square)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("введите двумерный массив");
                    StringBuilder sb = new StringBuilder();
                    string t = "";
                    do
                    {
                        t = Console.ReadLine();
                        sb.AppendLine(t);
                    } while (t != "");
                    int[,] arr2 = Array2Convert.StrToArr2(sb.ToString());
                    if (square && arr2.GetLength(0) != arr2.GetLength(1))
                    {
                        throw new Exception("двумерный массив не квадратный");
                    }
                    return arr2;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static int[,] InputArr2(bool square)
        {
            while (true)
            {
                Console.Write("Открыть двумерный массив из файла (y/n)? ");
                ConsoleKeyInfo Key = Console.ReadKey();
                Console.WriteLine();
                switch (Key.KeyChar)
                {
                    case 'Y':
                    case 'y':
                        return Arr2FromFile(square);
                    case 'N':
                    case 'n':
                        return Arr2FromConsole(square);
                }
            }
        }
        private static void Arr2ToFile(int[,] arr2)
        {
            while (true)
            {
                try
                {
                    Console.Write("имя файла: ");
                    Array2FileTools array2File = new Array2FileTools(Console.ReadLine());
                    array2File.Write(arr2);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static void Arr2ToConsole(int[,] arr2)
        {
            Console.WriteLine(Array2Convert.Arr2ToStr(arr2));
        }
        public static void OutputArr2(int[,] arr2)
        {
            while (true)
            {
                Console.Write("записать двумерный массив в файл (y/n)? ");
                ConsoleKeyInfo Key = Console.ReadKey();
                Console.WriteLine();
                switch (Key.KeyChar)
                {
                    case 'Y':
                    case 'y':
                        Arr2ToFile(arr2);
                        return;
                    case 'N':
                    case 'n':
                        Arr2ToConsole(arr2);
                        return;
                }
            }
        }
        private static void StrToFile(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write("имя файла: ");
                    Array2FileTools array2File = new Array2FileTools(Console.ReadLine());
                    array2File.Write(s);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void OutputStr(string s)
        {
            while (true)
            {
                Console.Write("записать результат в файл (y/n)? ");
                ConsoleKeyInfo Key = Console.ReadKey();
                Console.WriteLine();
                switch (Key.KeyChar)
                {
                    case 'Y':
                    case 'y':
                        StrToFile(s);
                        return;
                    case 'N':
                    case 'n':
                        Console.WriteLine(s);
                        return;
                }
            }
        }
    }
}
