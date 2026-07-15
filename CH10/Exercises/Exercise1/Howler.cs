using System;


namespace Exercise1
{
    public class Howler : Monkey
    {
        private int callVolume;

        public Howler(string Name, int callVolume) : base(Name)
        {
            this.CallVolume = callVolume;
        }
    
        public int CallVolume
        {
            get {return this.callVolume;}
            set
            {
                if(value < 0) throw new ArgumentOutOfRangeException("cant be less than the 0");
                this.callVolume = value;
            }
        }
    }
}