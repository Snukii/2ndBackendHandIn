using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2ndHandIn
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Zipcode { get; set; }
        public string Password { get; set; }

        public Customer(string name, int age, int zipcode, string password)
        {
            Name = name;
            Age = age;
            Zipcode = zipcode;
            Password = password;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Zipcode: {Zipcode}";
        }


    }
}