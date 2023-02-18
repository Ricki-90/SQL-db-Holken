namespace Holken_3.Models
{
    internal class Property_manager_Contact_Person
    {
        public string PropertyName { get; set; } = string.Empty;
        public int OrganizationNumber { get; set; }
        public int Contact_Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}