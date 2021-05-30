using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Parcel
    {
        public int Type { get; set; }
        public int Destination { get; set; }

        public int PickUpCode { get; set; }

        public int Code { get; set; }
    }
}
