using System;
using System.Collections.Generic;
using System.Linq;
//using System.VConsole;
using CupGame;

namespace ConsoleApp2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
            int i = 0;
            CupGame.RndObj _RndObj = new CupGame.RndObj();
            while (i < 100)
            {
                System.Console.WriteLine(_RndObj.Do().Get_Resalt().ToString());
                i++;
            }            
            System.Console.ReadLine();
        }
    }
}