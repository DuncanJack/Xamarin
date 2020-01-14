using System;
using System.Collections.Generic;

namespace DataBinding
{
    public static class Places
    {
        public static IEnumerable<Place> All
        {
            get
            {
                return new[]
                {
                    new Place{ Name="Place A", Population=100 },
                    new Place{ Name="Place B", Population=200 },
                    new Place{ Name="Place C", Population=300 }
                };
            }
        }
    }
}
