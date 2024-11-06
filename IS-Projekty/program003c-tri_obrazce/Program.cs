string again = "a";
while(again == "a") {
    {
      // pro zobrazené tohoto obrazce je lepší když jsou 
        Console.Write("Zadejte jak velké budou obrazce (výška): ");
        int vyska = int.Parse(Console.ReadLine());
        Console.Write("Zadejte jak velké budou obrazce (šířka): ");
        int sirka = int.Parse(Console.ReadLine());
   
        for (int i = 0; i < vyska; i++) 
        {
            for (int j = 0; j < sirka; j++)  
            {
                // Podmínky pro vykreslení hvězdičky
            if (j == 0 || j == sirka - 1 || j == i)

                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
         for (int i = 0; i < vyska; i++) 
        {
            for (int j = 0; j < sirka; j++)  
            {
                // Podmínky pro vykreslení hvězdičky
            if (j == 0 || j == sirka - 1 || j == i || j== sirka -1 -i )

                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        
    }
}