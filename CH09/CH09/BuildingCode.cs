using System;

namespace CH09
{
    public class BuildingCode
    {
        public static readonly decimal PermitFeeBase;

        static BuildingCode()
        {
            PermitFeeBase = 500m;
        }
    }
}