using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.CORE
{
    public class GeoCoding
    {
        public List<AddressComponent> address_components { get; set; }
        public List<string> types { get; set; }
        public Geometry geometry { get; set; }
        public string formatted_address { get; set; }
    }

    public class AddressComponent
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public List<string> types { get; set; }
    }

    public class Geometry { 
        public Coordinate location { get; set; }
    }

    public class Coordinate
    {
        public string lng { get; set; }
        public string lat { get; set; }
    }
}
