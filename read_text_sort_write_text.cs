// MrNetTek
// eddiejackson.net/blog
// 12/22/2019
// free for public use 
// free to claim as your own
 
using System;
using System.Collections.Generic; //used to setup dictionary
using System.Linq;                // used to perform sort
using System.IO;                  // used to read text file
 
namespace SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
 
            string textFile = @"c:\csharp\Sorting\list.txt";
 
            String[] lines = File.ReadAllLines(textFile);
            Dictionary<String, Int32> Ages = new Dictionary<String, Int32>();
 
            foreach (String Age in lines)
            {
                String[] split = Age.Split(' '); // delimiter to use from text file
 
                if (Ages.ContainsKey(split[0]))
                {
                    foreach (KeyValuePair<String, Int32> kvp in Ages)
                    {
                        if (kvp.Key == split[0])
                        {
                            Ages[split[0]] += Convert.ToInt32(split[1]);
                            break;
                        }
                    }
                }
                else
                {
                    if (split.Length > 1)
                        Ages.Add(split[0], Convert.ToInt32(split[1]));
                }
            }
 
            // SORT DESCENDING AGE
            var sorted1 = (from entry in Ages orderby entry.Value descending select entry);
            // Output
            Console.WriteLine("SORT1: Descending by Age");
            Console.WriteLine("NAME,AGE");
            foreach (KeyValuePair<String, Int32> kvp in sorted1)
                Console.WriteLine("{0},{1}", kvp.Key, kvp.Value);
 
            Console.WriteLine("\nPress any key to write SORT1 to file...\n");
            Console.ReadKey();
 
            // Write to file
            File.WriteAllLines(@"C:\csharp\Sorting\descendAge.txt", sorted1.Select(x => x.Key + "," + x.Value).ToArray());
 
 
            // SORT ASCENDING AGE
            var sorted2 = (from entry in Ages orderby entry.Value ascending select entry);
            // Output
            Console.WriteLine("\n\nSORT2: Ascending by Age");
            Console.WriteLine("NAME,AGE");
             foreach (KeyValuePair<String, Int32> kvp in sorted2)
                Console.WriteLine("{0},{1}", kvp.Key, kvp.Value);
 
            Console.WriteLine("\nPress any key to write SORT2 to file...\n");
            Console.ReadKey();
 
            // Write to file
            File.WriteAllLines(@"C:\csharp\Sorting\ascendAge.txt", sorted2.Select(x => x.Key + "," + x.Value).ToArray());
 
 
 
            // SORT DESCENDING NAME
            var sorted3 = (from entry in Ages orderby entry.Key descending select entry);
            // Output
            Console.WriteLine("\n\nSORT3: Descending by Name");
            Console.WriteLine("NAME,AGE");
             foreach (KeyValuePair<String, Int32> kvp in sorted3)
                Console.WriteLine("{0},{1}", kvp.Key, kvp.Value);
 
            Console.WriteLine("\nPress any key to write SORT3 to file...\n");
            Console.ReadKey();
 
            // Write to file
            File.WriteAllLines(@"C:\csharp\Sorting\descendName.txt", sorted3.Select(x => x.Key + "," + x.Value).ToArray());
 
 
            // SORT ASCENDING NAME
            var sorted4 = (from entry in Ages orderby entry.Key ascending select entry);
            // Output
            Console.WriteLine("\n\nSORT4: Ascending by Name");
            Console.WriteLine("NAME,AGE");
            foreach (KeyValuePair<String, Int32> kvp in sorted4)
                Console.WriteLine("{0},{1}", kvp.Key, kvp.Value);
 
            Console.WriteLine("\nPress any key to write SORT4 to file...\n");
            Console.ReadKey();
 
            // Write to file
            File.WriteAllLines(@"C:\csharp\Sorting\ascendName.txt", sorted4.Select(x => x.Key + "," + x.Value).ToArray());
 
 
 
            // Exit
            Console.WriteLine("\nWritten to file!\n");
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Environment.Exit(0);
 
        }
    }
}
