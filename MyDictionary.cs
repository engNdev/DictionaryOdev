using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    class MyDictionary<Key,Val>
    {
        
        Key[] Keys;
        Val[] Values;
        
        public MyDictionary()
        {
            
            Keys = new Key[0];
            Values = new Val[0];
        }
        public void Add(Key itemKey, Val itemVal)
        {
        Key[] tempKeys = Keys;
        Val[] tempVals = Values;

        Keys = new Key[Keys.Length + 1];
        Values = new Val[Values.Length + 1];
        for (int i = 0; i < tempKeys.Length; i++)
        {
            Keys[i] = tempKeys[i];

        }
        for (int i = 0; i < tempVals.Length; i++)
        {
            Values[i] = tempVals[i];
        }
        Keys[Keys.Length - 1] = itemKey;
        Values[Values.Length - 1] = itemVal;
           
        }
        public void Print()
        {
            for (int i = 0; i < Keys.Length; i++)
            {
                Console.WriteLine("Plaka: "+ Keys[i] + " Şehir: " + Values[i]);
            }
        }
    }
}
