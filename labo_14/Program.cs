
bool close = false;
List<string> Names = new List<string>();
int aantal = 0;

do
{
    Console.Clear();
    Console.WriteLine(" 1.Voeg een naam toe");
    Console.WriteLine(" 2. Toon alle namen");
    Console.WriteLine(" 3. Zoek een naam");
    Console.WriteLine(" 4. Verwijder een naam ");
    Console.WriteLine(" 5. Toon het aantal namen");
    Console.WriteLine(" 6. Stoppen");
    Console.Write(" Kies een optie: ");
    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Naam:" );
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("ongeldige naam");
                Console.ReadKey(true);
            }
            else
            {
                Names.Add(name);

            }
            break;
        case "2":
            /*foreach(string n in Names)
            {
            Console.WriteLine(n); 
            }*/
            Console.WriteLine(string.Join(Environment.NewLine, Names));
            Console.ReadKey(true);

            break;
        case "3":
            Console.Write("welke naam zoek je: ");
            name = Console.ReadLine();

            Names.Remove(name);

            int index = Names.IndexOf(name);
            
            if (index != -1)
            {
                Console.WriteLine($"{index} {name} niet gevonden");

            }
            else
            {
                Console.WriteLine($"{name} gevonden op positie {index+1}.");
            }


            break;
        case "4":
            Console.Write("welke naam wil je verwijderen: ");
            name = Console.ReadLine();



            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"{name} niet gevonden");

            }
            else
            {
                Console.WriteLine($"{name} wordt verwijderd.");
                Names.Remove(name);
            }

                break;
        case "5":
            Console.WriteLine($"Momenteel heeft bevat de lijst zoveel {Names.Count} namen");
            
            break;
        case "6":

            close = true;
            break;
    }

} while (close == false);




