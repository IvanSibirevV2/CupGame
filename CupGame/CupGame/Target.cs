namespace CupGame
{
    public class Target
    {
        public System.Double p_Max = 0;
        public System.Double p_Min = 0;
        public System.Double p_GanValue = 0;
        public Target() { }
        public Target Set(
            Target _this = null
            , System.Nullable<System.Double> _Max = null
            , System.Nullable<System.Double> _Min = null
            , System.Nullable<System.Double> _GanValue = null
        )
        {
            if (_this != null) this.Set(_this: null, _Max: _this.p_Max, _Min: _this.p_Min, _GanValue: _GanValue);
            if (_Max != null) this.p_Max = _Max.Value;
            if (_Min != null) this.p_Min = _Min.Value;
            if (_GanValue != null) this.p_GanValue = _GanValue.Value;
            return this;
        }
        private System.Boolean p__LockOn = false;
        public Target Do()
        {
            this.p_Resalt = (this.p_Min <= this.p_GanValue) && (this.p_GanValue < this.p_Max);
            this.p__LockOn = true;
            return this;
        }
        private System.Boolean p_Resalt = false;
        public System.Boolean Get_Resalt()
        {
            if (!this.p__LockOn) this.Do();
            return this.p_Resalt;
        }
    }
}
