using Holken_3.Servers;
var menu = new MenuService();

while(true)
{ 
    Console.Clear();
    Console.WriteLine("1. Skapa en ny kontakt");
    Console.WriteLine("2. Visa alla kontakter");
    Console.WriteLine("3. Visa en specifik kontakt");
    Console.Write("Välj ett av följande alternativ (1-3) ");

    switch (Console.ReadLine())
    {
        case "1":
            menu.CreateNewContact();
            break;

        case "2":
            menu.ListAllContact();
            break;

        case "3":
            menu.ListSpecificContact();
            break;
    }

    Console.WriteLine("\nTryck på valfri knapp för att försätta...")
    Console.ReadKey();

}