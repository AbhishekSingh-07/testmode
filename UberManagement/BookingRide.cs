using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberManagement
{
    class BookingRide
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string PickUpAdd { get; set; }
        public string DestinationAdd { get; set; }


        public override string ToString()
        {
            string bookingdata = "";
          
            bookingdata += Name.ToString() + "\n";
            bookingdata +=Email.ToString() + "\n";
            bookingdata += ContactNumber.ToString() + "\n";
            bookingdata += PickUpAdd.ToString() + "\n";
            bookingdata += DestinationAdd.ToString() + "\n";


            return bookingdata;
        }
    }
}
