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

            
            Console.WriteLine("\n Zadejte text pro analýzu: ");
            string mytext = Console.ReadLine();
            Console.WriteLine(mytext);  
            Console.WriteLine(mytext[0]);
            Console.WriteLine(mytext.Length);
            Console.WriteLine(mytext[mytext.Length-1]);
            

            string samohlasky = "AaeEiIoOuUáÁéÉíÍóÓúÚůŮ";
            string souhlasky = "bBcCčČdDďĎfFgGhHjJkKlLmMnNpPqQrRřŘsSšŠtTťŤvVwWxXyYzZ";
            string cislice = "0123456789";

            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;

            foreach(char znak in mytext){
                if(souhlasky.Contains(znak)){
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains(znak)){
                    pocetSamohlasek++;
                }
                else if(cislice.Contains(znak)){
                    pocetCislic++;
                }
            }
            Console.WriteLine("\n\n Počet samohlásek: {0}",pocetSamohlasek);
            Console.WriteLine("\n Počet souhlásek: {0}",pocetSouhlasek);
            Console.WriteLine("\n Počet číslic: {0}",pocetCislic);
            Console.WriteLine("\n Počet ostatních znaků: ",pocetOstatnich);

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }