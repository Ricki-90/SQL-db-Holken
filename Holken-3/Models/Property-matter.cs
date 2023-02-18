namespace Holken_3.Models
{
    internal class Property_matter
    {
        public int Matter_Id { get; set; }
        public string Category { get; set; } = string.Empty;
        public string MatterExplained { get; set; } = string.Empty;
    }

    internal class Completed_property_matter
    {
        public int Matter_Id { get; set; }
        public string Information { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
