using Microsoft.VisualBasic;
using System;

namespace Ежедневник
{
    internal class Program
    {
        static DateOnly date = new DateOnly(2023, 9, 24);
        static int pos = 1;
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Zametki perv = new Zametki();
            perv.Name = "Награды.";
            perv.Description = "Забрать награды в честь окончания ивента.";
            Zametki vt = new Zametki();
            vt.Name = "Магазин.";
            vt.Description = "Не отпускай отца за хлебом, сам сходи.";
            Zametki tr = new Zametki();
            tr.Name = "Буллинг.";
            tr.Description = "Поиздевайся над друзьями в коопе.";
            Zametki chet = new Zametki();
            chet.Name = "Кот";
            chet.Description = "Нужно помыть кота.";
            Zametki pyat = new Zametki();
            pyat.Name = "Уборка.";
            pyat.Description = "Уберись в комнате.";
            do
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Выбрана дата " + date);
                if (date == new DateOnly(2023, 9, 24))
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("  1. " + perv.Name);
                    Console.WriteLine("  2. " + tr.Name);
                }
                else if (date == new DateOnly(2023, 9, 23))
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("  1. " + vt.Name);
                }
                else if (date == new DateOnly(2023, 9, 25))
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("  1. " + chet.Name);
                    Console.WriteLine("  2. " + pyat.Name);
                }
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                {
                    sterka();
                    IzmDat(key);
                }
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                {
                    Strelki(key);
                    break;
                }
            } while (key.Key != ConsoleKey.Enter);
              sterka();
              opisanie(perv, vt, tr, chet, pyat);
        static DateOnly IzmDat(System.ConsoleKeyInfo key)
        {
            date = key.Key == ConsoleKey.LeftArrow ? date.AddDays(-1) : date.AddDays(1);
            return date;
        }
        static int Strelki(System.ConsoleKeyInfo key)
        {
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == 0)
                        if (date == new DateOnly(2023, 9, 24) || date == new DateOnly(2023, 9, 25))
                            pos = 2;
                        else
                            pos = 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == 2 && date == new DateOnly(2023, 9, 23))
                        pos = 1;
                    else if (pos == 3 && date == new DateOnly(2023, 9, 24))
                        pos = 1;
                    else if (pos == 3 && date == new DateOnly(2023, 9, 25))
                        pos = 1;
                }
            } while (key.Key != ConsoleKey.Enter);
              return pos;
            }
        }
        static void sterka()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                        ");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("                        ");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("                        ");
        }
        static void opisanie(Zametki perv, Zametki vt, Zametki tr, Zametki chet, Zametki pyat)
        {
            sterka();
            if (date == new DateOnly(2023, 9, 24))
            {
                if (pos == 1)
                {
                    sterka();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(perv.Name);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Описание: " + perv.Description);
                    Console.WriteLine(date);
                }
                else if (pos == 2)
                {
                    sterka();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(tr.Name);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Описание: " + tr.Description);
                    Console.WriteLine(date);
                }
            }
            else if (date == new DateOnly(2023, 9, 23))
            {
                sterka();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(vt.Name);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Описание: " + vt.Description);
                Console.WriteLine(date);
            }
            else if (date == new DateOnly(2023, 9, 25))
            {
                if (pos == 1)
                {
                    sterka();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(chet.Name);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Описание: " + chet.Description);
                    Console.WriteLine(date);
                }
                else
                {
                    sterka();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(pyat.Name);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Описание: " + pyat.Description);
                    Console.WriteLine(date);
                }
            }
        }
    }
}