using System;

namespace CupGame
{
    public class DataConteiner
    {
        public System.Object p_Obj = null;
        public System.Double p_Persents = 10;
        public Target p_Target = new Target();
        public DataConteiner() { }
        public DataConteiner Set(
            DataConteiner _this = null
            , System.Object _Obj = null
            , System.Nullable<System.Double> _Persents = null
            , Target _Target = null
            )
        {
            if (_this != null) this
                .Set(_this: null)
                .Set(_Obj: _this.p_Obj/*.Get__Copy()*/)
                .Set(_Persents: _this.p_Persents)
                .Set(_Target: _this.p_Target/*.Get__Copy()*/)
            ;
            if (_Obj != null) this.p_Obj = _Obj;
            if (_Persents != null) this.p_Persents = _Persents.Value;
            if (_Target != null) this.p_Target = _Target;
            return this;
        }
    }
}