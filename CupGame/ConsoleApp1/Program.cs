using System;

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
                _RndObj.Do().Get_Resalt().ToString().WriteLine();
                i++;
            }
            System.Console.ReadLine();
        }
    }
}
