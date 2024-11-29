using System;

namespace NamePrinting
{
    class Program
    {
        // Data - do not change it in code!
        static string[] names = {
            "Mickey Mouse", "Minnie Mouse", "Donald Duck", "Goofy", "Pluto", "Daisy Duck", "Simba", "Nala",
            "Timon", "Pumbaa", "Mufasa", "Ariel", "Flounder", "Sebastian", "Ursula", "Belle", "Beast", "Gaston",
            "Cinderella", "Prince Charming", "Aurora", "Maleficent", "Rapunzel", "Flynn Rider", "Elsa", "Anna",
            "Olaf", "Moana", "Maui", "Hercules"
        };

        // Print all array elements, *perLine* elements per one line
        // After all elements except last one should be ", " - also on the end of lines.
        // After last element should be ".".
        static void PrintGroups(string[] t, int perLine)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i]);
                if (i < t.Length - 1)
                {
                    if ((i + 1) % perLine == 0)
                        Console.WriteLine(",");
                    else
                        Console.Write(", ");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
        }

        // Print all array elements in *perLine* columns.
        // Each column must have given *width* (number of chars).
        // Columns should be separated by "| ".
        // If element is too long it should be trimmed.
        static void PrintColumns(string[] t, int perLine, int width)
        {
            for (int i = 0; i < t.Length; i++)
            {
                string formatted = t[i].Length > width ? t[i].Substring(0, width) : t[i].PadRight(width);
                Console.Write(formatted + (i % perLine == perLine - 1 ? "\n" : " | "));
            }
            if (t.Length % perLine != 0)
                Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Test how your functions work. 
            // You can temporarily comment some lines not needed for current testing.

            Console.WriteLine("\nPrintGroups(names, 3):\n");
            PrintGroups(names, 3);
            /*
            Mickey Mouse, Minnie Mouse, Donald Duck,
            Goofy, Pluto, Daisy Duck,
            Simba, Nala, Timon,
            Pumbaa, Mufasa, Ariel,
            Flounder, Sebastian, Ursula,
            Belle, Beast, Gaston,
            Cinderella, Prince Charming, Aurora,
            Maleficent, Rapunzel, Flynn Rider,
            Elsa, Anna, Olaf,
            Moana, Maui, Hercules.
            */

            Console.WriteLine("\nPrintGroups(names, 5):\n");
            PrintGroups(names, 5);
            /*
            Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto,
            Daisy Duck, Simba, Nala, Timon, Pumbaa,
            Mufasa, Ariel, Flounder, Sebastian, Ursula,
            Belle, Beast, Gaston, Cinderella, Prince Charming,
            Aurora, Maleficent, Rapunzel, Flynn Rider, Elsa,
            Anna, Olaf, Moana, Maui, Hercules.
            */

            Console.WriteLine("\nPrintGroups(names, 7):\n");
            PrintGroups(names, 7);
            /*
            Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto, Daisy Duck, Simba,
            Nala, Timon, Pumbaa, Mufasa, Ariel, Flounder, Sebastian,
            Ursula, Belle, Beast, Gaston, Cinderella, Prince Charming, Aurora,
            Maleficent, Rapunzel, Flynn Rider, Elsa, Anna, Olaf, Moana,
            Maui, Hercules.
            */

            Console.WriteLine("\nPrintGroups(names, 40):\n");
            PrintGroups(names, 40);
            /*
            Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto, Daisy Duck, Simba, Nala, Timon, Pumbaa, Mufasa, Ariel, Flounder,
            Sebastian, Ursula, Belle, Beast, Gaston, Cinderella, Prince Charming, Aurora, Maleficent, Rapunzel, Flynn Rider, Elsa, Anna,
            Olaf, Moana, Maui, Hercules.
            */

            Console.WriteLine("\n\nPrintColumns(names, 4, 17):\n");
            PrintColumns(names, 4, 17);
            /*
            Mickey Mouse     | Minnie Mouse     | Donald Duck      | Goofy
            Pluto            | Daisy Duck       | Simba            | Nala
            Timon            | Pumbaa           | Mufasa           | Ariel
            Flounder         | Sebastian        | Ursula           | Belle
            Beast            | Gaston           | Cinderella       | Prince Charming
            Aurora           | Maleficent       | Rapunzel         | Flynn Rider
            Elsa             | Anna             | Olaf             | Moana
            Maui             | Hercules         |
            */

            Console.WriteLine("\n\nPrintColumns(names, 5, 15):\n");
            PrintColumns(names, 5, 15);
            /*
            Mickey Mouse   | Minnie Mouse   | Donald Duck    | Goofy          | Pluto
            Daisy Duck     | Simba          | Nala           | Timon          | Pumbaa
            Mufasa         | Ariel          | Flounder       | Sebastian      | Ursula
            Belle          | Beast          | Gaston         | Cinderella     | Prince Charming
            Aurora         | Maleficent     | Rapunzel       | Flynn Rider    | Elsa
            Anna           | Olaf           | Moana          | Maui           | Hercules
            */

            Console.WriteLine("\n\nPrintColumns(names, 8, 10):\n");
            PrintColumns(names, 8, 10);
            /*
            Mickey Mou| Minnie Mou| Donald Duc| Goofy     | Pluto     | Daisy Duck| Simba     | Nala
            Timon     | Pumbaa    | Mufasa    | Ariel     | Flounder  | Sebastian | Ursula    | Belle
            Beast     | Gaston    | Cinderella| Prince Cha| Aurora    | Maleficent| Rapunzel  | Flynn Ride
            Elsa      | Anna      | Olaf      | Moana     | Maui      | Hercules  |
            */
        }
    }
}
