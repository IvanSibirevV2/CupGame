using System;
using System.Collections.Generic;
using System.Linq;
using System.VConsole;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 0;
            CupGame.RndObj _RndObj = new CupGame.RndObj();
            while (i < 100)
            {
                _RndObj.Do().Get_Resalt().ToString().WriteLine();
                i++;
            }
            System.Console.ReadLine();
        }
    }
}
