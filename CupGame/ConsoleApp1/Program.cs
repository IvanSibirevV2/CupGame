﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //new GameCup().Get_Resalt();
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