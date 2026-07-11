using System;

namespace CH09
{
    public class CommercialBuilding : Building
    {
        public int OfficeUnits;
        public CommercialBuilding(string name, int floors, string address, int officeUnits) : base (name, floors, address)
        {
            this.OfficeUnits = officeUnits;
        }
        

        /* 

            The CommercialBuilding Constructor calls the parent master constructor by using "base" keyword, passing the necessary parameters to ensure that all
            Building level initialization is completed, before handling Commercial-specific logic.

            This guarantees that the base classes setup is never skipped or duplicated.

        */ 
    }   
}