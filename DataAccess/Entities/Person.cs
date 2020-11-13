using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Person
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }

        //public string toString()
        //{
        //    string s = "Customer:" + firstName + lastName + "\nCustomer id:" + id + "\nCustomer phone number:" + phone;
        //    return s;
        //}
    }
}
