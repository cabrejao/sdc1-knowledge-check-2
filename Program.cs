using sdc1knowledgecheck2;


static class Program
{
    private static void Main()
    {
        Console.WriteLine("How many trading card packages do you want to add? ");
        var numberOfCollectibles = int.Parse(Console.ReadLine());

        var collectiblesList = new List<Collectibles>();
        for (int i = 0; i < numberOfCollectibles; i++)
        {
        // In this loop, populate the object's properties using Console.ReadLine()
            var collectibles = new TradingCards();

            Console.WriteLine("What is the name of the trading card package?");
            collectibles.Name = Console.ReadLine();
            Console.WriteLine("Enter the price of each trading card package.");
            collectibles.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How many cards are in each package?");
            collectibles.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter description of trading card package. (I.E. 1st ed., lmtd ed.)");
            collectibles.Description = Console.ReadLine();
            Console.WriteLine("What brand is the trading card package?");
            collectibles.Brand = Console.ReadLine();
            Console.WriteLine("What package type are the trading cards in? (Sleeve, Deck, Box?)");
            collectibles.Package_Type = Console.ReadLine();
            
        //Return information after entry
            Console.WriteLine(collectibles.Name + " has been added successfully!");
            Console.WriteLine("Price per package is: $" + collectibles.Price);
            Console.WriteLine("There are " + collectibles.Quantity + " units of " + collectibles.Name);
            Console.WriteLine("Product description: " + collectibles.Description);
            Console.WriteLine("Product brand: " + collectibles.Brand);
            Console.WriteLine("Product type: " + collectibles.Package_Type);

            Console.ReadLine();

            collectiblesList.Add(collectibles);
        }
    }
}

// Print out the list of records using Console.WriteLine()