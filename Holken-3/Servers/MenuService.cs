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
            renter.PostalAddress.StreetName = Console.ReadLine() ?? "";


            Console.Write("Postnummer: ");
            renter.PostalAddress.PostalCode = Console.ReadLine() ?? "";


            Console.Write("Stad: ");
            renter.PostalAddress.City = Console.ReadLine() ?? "";


            //save Renter to database
            var database = new DatabaseService();
            database.SaveToDatabase(renter);

        }

        public void ListAllContact() 
        {

        }
        public void ListSpecificContact() 
        { 

        }
    }
}
