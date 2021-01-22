using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryList<string,int> FilmadYil = new DictionaryList<string,int>();
            FilmadYil.Add("İnek şaban",1978);
            FilmadYil.Add("Bekciler kralı",1979);
            FilmadYil.Add("Çarıklı Milyoner",1983);
            FilmadYil.Add("Lucy",2018);

            FilmadYil.GetAll();
            Console.WriteLine("Eleman sayisi: {0} ", +FilmadYil.Count);
            Console.ReadLine();
        }
    }
    class DictionaryList<T,V>
    {
        T[] key;
        V[] value;

        public DictionaryList()
        {
            key = new T[0];
            value = new V[0];
        }
        public void Add(T keys,V values)
        {
            T[] tempKey = key;
            V[] tempValue = value;
           
            key = new T[key.Length + 1];
            value = new V[value.Length + 1 ];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
                
            }

            key[key.Length - 1] = keys;
            value[value.Length - 1] = values;
        }

        public void GetAll()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.Write(key[i] + " - ");
                Console.WriteLine(value[i]);

            }

            Console.WriteLine("Listed!");
        }
        public int Count
        {
            get { return key.Length; }
            
        }
    }
}
