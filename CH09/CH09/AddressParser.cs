using System;

namespace CH09
{
    public class AddressParser
    {
        public static (string Street, string City) Split(string fullAddress)
        {
            var parts = fullAddress.Split(',',2,StringSplitOptions.TrimEntries);
            return (parts[0], parts.Length > 1 ? parts[1] : string.Empty); 
        }
    }
}