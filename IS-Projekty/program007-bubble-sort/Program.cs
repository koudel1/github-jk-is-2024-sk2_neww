using System.Globalization;
using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;

string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Generátor pseudonáhodných čísel *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Jakub Kumšta ******************");
            Console.WriteLine("***********************************************\n\n");
            Console.WriteLine();

            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) {
               myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            
            Stopwatch myStopwatch= new Stopwatch();
            myStopwatch.Start();

            int numbercompare = 0;
            int numberrchange = 0;

            for(int i=0 ; i<n-1 ; i++){
                for(int j=0 ; j< n- i -1; j++){
                    numbercompare++;
                    if(myArray[j] < myArray[j+1]) {
                        int tmp = myArray[j];
                        myArray[j]= myArray[j+1];
                        myArray[j+1] = tmp;
                        numberrchange++;
                    }
                }
                }
                myStopwatch.Stop();

            Console.WriteLine("\n\nSeřazené pole: {0}; ");
             for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]);
    
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nčas potřebný na seřazení pole algoritmem Bubble sort: {0}", myStopwatch.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numbercompare);
            Console.WriteLine("\n\nPočet proměn: {0}",numberrchange);

            Console.ResetColor();
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }