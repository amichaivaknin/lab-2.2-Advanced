using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    [KeyAttribute()]
    internal struct MyInt
    {
        private int _myInt;

        public MyInt(int num)
        {
            _myInt = num;
        }
    }

    internal struct MyInt2
    {
        private int _myInt;

        public MyInt2(int num)
        {
            _myInt = num;
        }
    }

    internal class MyString
    {
        private string _myString;

        public MyString(string str)
        {
            _myString = str;
        }

        public MyString()
        {
            _myString = "";
        }
    }
}
