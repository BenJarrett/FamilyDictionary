using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("oldest sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Sam" }, { "age", "29" } });
            myFamily.Add("oldest brother", new Dictionary<string, string>() { { "name", "Matt" }, { "age", "31" } });
            myFamily.Add("older sister", new Dictionary<string, string>() { { "name", "Kaley" }, { "age", "36" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Martha" }, { "age", "65" } });
            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Terry" }, { "age", "65" } });

            foreach (var item in myFamily)
            {
               
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]}");
            }

        }
    }
}
