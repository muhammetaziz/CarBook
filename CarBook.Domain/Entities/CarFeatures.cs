using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarFeatures
    {
        public int CarFeaturesId { get; set; }

        public int CarId { get; set; }
        public int FeaturesId { get; set; }

        public Car Car { get; set; }
        public Features Features { get; set; }

        public bool Available { get; set; }
    }
}
