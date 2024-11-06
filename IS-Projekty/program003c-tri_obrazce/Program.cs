string again = "a";
while(again == "a") {
    {
      // pro zobrazené tohoto obrazce je lepší když jsou 
        Console.Write("Zadejte jak velké budou obrazce: ");
        int velikost = int.Parse(Console.ReadLine());
        
   
        for (int i = 0; i < velikost; i++) 
        {
            for (int j = 0; j < velikost; j++)  
            {
                // Podmínky pro vykreslení hvězdičky
            if (j == 0 || j == velikost - 1 || j == i)

                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
         for (int i = 0; i < velikost; i++) 
        {
            for (int j = 0; j < velikost; j++)  
            {
                // Podmínky pro vykreslení hvězdičky
            if (j == 0 || j == velikost - 1 || j == i || j== velikost -1 -i )

                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        
    }
}