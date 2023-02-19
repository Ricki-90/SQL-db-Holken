using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holken_3.Models.Entities
{
    internal class Renter_AddressEntity
    {
        public int Id { get; set; }
        public string StreetName { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
