using Holken_3.Models;


namespace Holken_3.Servers
{
    internal class MenuService
    {
        public void CreateNewContact()
        {
            var renter = new Renter();

            Console.Write("Förnamn: ");
            renter.FirstName = Console.ReadLine() ?? "";


            Console.Write("Efternamn: ");
            renter.LastName = Console.ReadLine() ?? "";


            Console.Write("E-postadress: ");
            renter.Email = Console.ReadLine() ?? "";


            Console.Write("Telefonnummer: ");
            renter.PhoneNumber = Console.ReadLine() ?? "";


            Console.Write("Gatuadress: ");
            renter.Address.StreetName = Console.ReadLine() ?? "";


            Console.Write("Postnummer: ");
            renter.Address.PostalCode = Console.ReadLine() ?? "";


            Console.Write("Stad: ");
            renter.Address.City = Console.ReadLine() ?? "";


        }

        public void ListAllContact() 
        {

        }
        public void ListSpecificContact() 
        { 

        }
    }
}
