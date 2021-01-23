using System;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dict = new MyDictionary<int, string>();
            dict.Add(20, "Denizli");
            dict.Add(34, "İstanbul");
            dict.Add(48, "Muğla");
            dict.Print();

        }
    }
    
}
