using System;
using System.Collections.Generic;
using System.Linq;
using System.VConsole;

namespace CupGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new GameCup().Get_Resalt();
            System.Console.ReadLine();
        }
    }

    public class GameCup
    {
        public System.Int32 p_CupCount = 3;
        public List<System.Boolean> p_ListCup = new List<System.Boolean>() {false,false,false};
        public System.Int32 p_YourCup = 2;
        ////////////////////////////////////////////
        public GameCup Set(
            GameCup _this=null
            , System.Nullable<System.Int32> _CupCount = null
            , List<System.Boolean> _ListCup = null
            , System.Nullable<System.Int32> _YourCup = null
        )
        {
            if (_this != null) this
                .Set(_this: null)
                .Set(_CupCount: _CupCount)
                .Set(_ListCup: _ListCup)
                .Set(_YourCup: _YourCup)
            ;
            if (_CupCount != null) this.p_CupCount = _CupCount.Value;
            if (_ListCup != null) this.p_ListCup = _ListCup;
            if (_YourCup != null) this.p_YourCup = _YourCup.Value;
            return this;
        }
        ////////////////////////////////////////////
        public GameCup() { }
        public GameCup Set_NewListCup() 
        {
            this.p_ListCup = new List<bool>();
            for (int i=0;i<this.p_CupCount;i++) this.p_ListCup.Add(false);
            return this;
        }
        private System.Random p__Random = new Random();
        public GameCup Set_BallCup()
        {
            if (this.p_ListCup.Count != this.p_CupCount) this.Set_NewListCup();
            this.p_ListCup[this.p__Random.Next(0, this.p_CupCount)] = true;
            return this;
        }
        public GameCup WriteThis() 
        {

            this.p_ListCup.Select((a, i) => "Cup_" + i.ToString() + "=" + a.ToString() + ";")
                .ToList().ForEach(a => a.WriteLine());
            return this;
        }
        ///////////////////////////////////////////////
        public GameCup Do() 
        {
            this.Set_BallCup();
            "Write YourCup:".WriteLine();
            this.p_YourCup = this.p_YourCup.Get_ReadLine();
            return this;
        }
        private System.Boolean p__LockUp = false;
        public GameCup Get_Resalt()
        {
            if (!this.p__LockUp) this.Do();
            this.WriteThis();
            if ((this.p_YourCup < 0) || (this.p_YourCup >= this.p_ListCup.Count) || (!this.p_ListCup[this.p_YourCup])) 
            { "Fail".WriteLine(); return this; }
            if (this.p_ListCup[this.p_YourCup]) "Your is KRASAVCHEK !!!".WriteLine();
            
            return this;
        }
        ///////////////////////////////////////////////
    }
}
