using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MultiDictionary<MyInt, MyString> dictionary = new MultiDictionary<MyInt, MyString>();
            MultiDictionary<MyInt2, MyString> dictionary2 = new MultiDictionary<MyInt2, MyString>();

            MyInt one = new MyInt(1);
            MyString oneString = new MyString("one"); 
            MyInt tow = new MyInt(2);
            MyString oneStringspenish = new MyString("uno");
            MyInt three = new MyInt(3);
            MyString threeString = new MyString("three");

            try
            {
                dictionary.Add(one, oneString);
                dictionary.CreateNewValue(tow);
                Console.WriteLine("Add and CreateNewValue with Attribute");
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message+ " dictionary");
            }

            MyInt2 one2 = new MyInt2(1);
            MyString oneString2 = new MyString("one");
            MyInt2 tow2 = new MyInt2(2);

            try
            {
                dictionary2.Add(one2, oneString2);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message + " Add dictionary2");
            }

            try
            {
                dictionary2.CreateNewValue(tow2);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message + " CreateNewValue dictionary2");
            }

            Console.WriteLine();

            if (dictionary.ContainsKey(one) && dictionary.ContainsKey(three, threeString))
            {
                Console.WriteLine("Contains works");
            }

            Console.WriteLine();

            Console.WriteLine("count= " + dictionary.Count +
                               " Keys= " + dictionary.Keys.Count +
                               " Values= " + dictionary.Values.Count);
        }
    }
}
