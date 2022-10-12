using System;
using System.Collections.Generic;
using System.Linq;

namespace CupGame
{

    public class RndObj
    {
        public List<DataConteiner> p_ListData = new List<DataConteiner>()
        {
            new DataConteiner().Set(_Obj:"Ехал",_Persents: 40)
            , new DataConteiner().Set(_Obj:"Грека",_Persents: 20)
            , new DataConteiner().Set(_Obj:"Через",_Persents: 10)
            , new DataConteiner().Set(_Obj:"Реку",_Persents: 30)
        }
        ;
        public RndObj() { }
        public RndObj Set(RndObj _this = null, List<DataConteiner> _ListData = null)
        {
            if (_this != null) this.Set(_this: null, _ListData: _this.p_ListData.Get__Copy());
            if (_ListData != null) this.p_ListData = _ListData;
            return this;
        }
        ////////////////////////////
        private System.Boolean p__isNorm = false;
        public RndObj Set_Norm()
        {//Первое, нормировать значения
            System.Double _SummForNorm = this.p_ListData.Select(a => a.p_Persents).Aggregate((x, y) => x + y);
            this.p_ListData.ForEach(a => { a.p_Persents = 100 * a.p_Persents / _SummForNorm; });
            this.p__isNorm = true;
            return this;
        }
        private System.Boolean p__isTarget = false;
        public RndObj Set_Target()
        {//Выставить интерваы
            System.Double _TargetIntervalMin = 0;
            foreach (var _DataConteiner in this.p_ListData)
            {
                _DataConteiner.p_Target.Set(_Min: _TargetIntervalMin, _Max: _TargetIntervalMin + _DataConteiner.p_Persents);
                _TargetIntervalMin = _DataConteiner.p_Target.p_Max;
            }
            this.p__isTarget = true;
            return this;
        }
        ////////////////////////////
        public RndObj Do()
        {
            if (!this.p__isNorm) this.Set_Norm();
            if (!this.p__isTarget) this.Set_Target();
            //Стрельнуть
            System.Double _GanValue = this.p__Random.NextDouble() * 100;
            this.p__Resalt = this.p_ListData
                .Select(a => { a.p_Target.Set(_GanValue: _GanValue).Do(); return a; })
                .Where(a => a.p_Target.Get_Resalt() == true).First()
                .p_Obj
            ;
            return this;
        }
        private System.Random p__Random = new Random();
        private System.Boolean p__LockUp = false;
        private System.Object p__Resalt = null;
        public System.Object Get_Resalt()
        {
            if (!this.p__LockUp) this.Do();
            return this.p__Resalt;
        }
    }
}
