namespace Holken_3.Models
{
    internal class Renter
    {
        public int Renter_Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Renter_Address PostalAddress { get; set; } = null!;
    }

    internal class Renter_Address 
    { 
        public string PhoneNumber { get; set; } = string.Empty;
        public string StreetName { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
