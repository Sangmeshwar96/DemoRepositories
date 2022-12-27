using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("HashTable Demo\n");
            Hashtable ht = new Hashtable();   ////Type 1 For HashTable
            ht.Add("Id", 100);
            ht.Add("Name", "Sangmeshwar");
            ht.Add("Age", 26);
            ht.Add("Cource", ".Net");
            ht.Add("Month", "November");


            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key +" : " +ht[key]);
            }

            ht.Remove("Age");
            Console.WriteLine("--------------------------------------\nAfter Removing Element From HashTable\n");

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            ht.Clear();
            Console.WriteLine("--------------------------------------\nAfter clearing All Elements From HashTable\n");

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);

                
            }
            Console.WriteLine("HashTable Is cleared");


            //Hashtable ht = new Hashtable()   ////Type 2 For HashTable
            //{
            //    {"Id",123 },
            //    {"Name", "Sangmeshwar" },
            //    {"Cource",".Net" },
            //    {"Month","November" }

            //};


            //Console.WriteLine(ht["Name"]);
            Console.ReadLine();

        }


    }
}