using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models
{
    public class cart
    {
        public int ID { get; set; }
        public string ApplicationID { get; set; }

        //nav properties 
        public ICollection<CartItems> CartItems { get; set; }
    }
}
