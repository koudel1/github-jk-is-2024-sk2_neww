using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;

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

            Console.WriteLine();

             int max = myArray[0];
             int min = myArray[0];
             int posMax = 0;
             int posMin = 0;
             int maxcount = 1;
             int mincount = 1;
             string maxpozice = " ";
             string minpozice = " ";

             for(int i=1 ; i < n; i++){
                if(myArray[i] == max){
                    maxcount++;
                    maxpozice+= i+ "; ";
                }
                if(myArray[i] == min){
                    mincount++;
                    minpozice+= i+ "; ";
                }
                if(myArray[i] > max){
                    max = myArray[i];
                    posMax = i;
                }
                 if(myArray[i] < min){
                    min = myArray[i];
                    posMin = i;
                }
             }  
            Console.WriteLine("\n maximální číslo: {0}",max, "\n na pozici: {0}", posMax);
            Console.WriteLine("na pozici: {0}", posMax);
            Console.WriteLine("minimální číslo: {0}",min, "\n na pozici: {0}", posMin);
            Console.WriteLine("na pozici: {0}", posMin);
            Console.WriteLine("maximální hodnota je zde : {0}x", maxcount);
            Console.WriteLine("maximální hodnoty jsou na pozicích :" + maxpozice);
            Console.WriteLine("minimální hodnota je zde : {0}x", mincount);
            Console.WriteLine("maximální hodnoty jsou na pozicích:"+ minpozice);






            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }