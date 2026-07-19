using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Revision
{
    public class ClassA : RV
    {
        private bool hasAC;
        
        public bool HasAC
        {
            get { return this.hasAC;}
            set
            {
                this.hasAC = value;
            }
        }
        public ClassA(string EngineType, int FuelLevel, bool HasAC) : base (EngineType, FuelLevel)
        {
        }

        public ClassA(string EngineType, bool HasAC) : base (EngineType, 1)
        {
        }
        public ClassA(bool HasAC) : base ("Unnamed", 1)
        {
        }
        public ClassA() : base("Unnamed", 1)
        {
        }
    }
}