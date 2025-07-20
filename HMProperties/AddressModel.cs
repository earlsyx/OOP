using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMProperties
{
    public class AddressModel
    {
        //Create a class that has preiprties for street, address, city, state and zip code.
        //Add FullAddress Property that is read-only.
        public string Street { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public string FullAddress
        {
            get 
            {
                return $"{Street} {Address} {City} {ZipCode}"; 
            }
        }

    }
}
