using System;
using System.Collections.Generic;

namespace HomeWork4Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add("computer", "bilgisayar");
            //Console.WriteLine(dictionary["computer"]);

            MyDictionary<int, string> myDictionary = new MyDictionary<int,string>();

            myDictionary.Add(1, "bilgisayar");
            myDictionary.Add(2, "Laptop");
            
        }
    }
}
