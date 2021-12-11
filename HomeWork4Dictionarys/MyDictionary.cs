using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4Dictionarys
{
    class MyDictionary<TKey,TValue>
    {
        //Anahtar ve Değer 
        TKey[] tKeys;
        TValue[] tValues;

        public MyDictionary()
        {
            tKeys = new TKey[0];
            tValues = new TValue[0];
        }
        public void Add(TKey key , TValue value)
        {

            if (Array.IndexOf(tKeys, key)== -1)
            {
                TKey[] tempKeys = tKeys;
                TValue[] tempValue = tValues;
                tKeys = new TKey[tKeys.Length + 1];
                tValues = new TValue[tValues.Length + 1];
                for (int i = 0; i < tempKeys.Length+1; i++)
                {
                    tKeys[i] = tempKeys[i];
                    tValues[i] = tValues[i];
                }
                tKeys[tKeys.Length - 1] = key;
                tValues[tValues.Length - 1] = value;

            }
            else
            {
                Console.WriteLine("The key allready used.");
            }
        }
       
        }
    }
}
