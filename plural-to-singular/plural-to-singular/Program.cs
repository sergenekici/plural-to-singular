using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace plural_to_singular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : plural to singular");
            Console.WriteLine("2 : singular to plural");
            Console.Write("Please make your choice : ");

            string selection = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a word : "); 
            string text = Console.ReadLine();

            string result = null;

            switch (selection)
            {
                case "1" :
                    result = TranslationHelper.PluralToSingular(text);
                    break;
                case "2":
                    result = TranslationHelper.SingularToPlural(text);
                    break;

                default:
                    break;
            }

            Console.WriteLine("result : {0} ", result);

             
            Console.ReadKey();
        }
    }
}
