using Prototype.ShallowClone;

using System;

namespace Prototype
{
    public static class Program
    {
        private static void Main()
        {
            GuitarMenu guitarMenu = new GuitarMenu();

            guitarMenu["Fender"] = new Guitar("Stratocaster", 6000, new GuitarInfo(6, "White"));
            guitarMenu["Cort"] = new Guitar("SFX ME-OP", 5000, new GuitarInfo(12, "Black"));

            Console.WriteLine("Original Copy");
            Console.WriteLine(guitarMenu["Cort"]);

            Guitar clone = guitarMenu["Cort"].Clone() as Guitar;
            Console.WriteLine("\nCloned Copy without changes.");
            Console.WriteLine(clone);

            Console.WriteLine("\nMake Changes to clone copy address");
            clone.Name = "None";
            clone.Price = 0;
            clone.GuitarInfo.Color = "None";
            clone.GuitarInfo.NumberOfString = 0;

            Console.WriteLine("\nOriginal Copy\nReference values have changed.");
            Console.WriteLine(guitarMenu["Cort"]);
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clone);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Original Copy");
            Console.WriteLine(guitarMenu["Fender"]);

            Guitar deepClone = guitarMenu["Fender"].DeepCopy() as Guitar;
            Console.WriteLine("\nDeep Cloned Copy without changes.");
            Console.WriteLine(deepClone);

            Console.WriteLine("\nMake Changes to deep clone copy address");
            deepClone.Name = "None";
            deepClone.Price = 0;
            deepClone.GuitarInfo.Color = "None";
            deepClone.GuitarInfo.NumberOfString = 0;

            Console.WriteLine("\nOriginal Copy\nEverything was kept the same.");
            Console.WriteLine(guitarMenu["Fender"]);
            Console.WriteLine("\nDeep Cloned Copy");
            Console.WriteLine(deepClone);
        }
    }
}