using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PersonModel
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private string street;
        private string city;
        private string province;
        private string postalCode;

        private PersonData personData;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone
        {
            get
            {
                return phone;
                //if (String.IsNullOrEmpty(phone)) return null;
                //return "(" + phone.Substring(0, 3) + ") " + phone.Substring(3, 3) + "-" + phone.Substring(6);
            }
            set => phone = value;
        }
        public string Email { get => email; set => email = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }


        public PersonModel()
        {
            personData = new PersonData();
        }


        public void GetPerson(string id)
        {           
            Person person = new Person();           

            person = personData.getPerson(Convert.ToInt32(id));
            Id = person.id;
            FirstName = person.firstName;
            LastName = person.lastName;
            Phone = person.phone;
            Email = person.email;
            City = person.city;
            Province = person.province;           
        }


        public DataTable ShowPersons()
        {
            DataTable table = new DataTable();
            table = personData.Show();

            return table;
        }


        public DataTable PersonList()
        {
            DataTable table = new DataTable();
            table = personData.PersonList();

            return table;
        }


        public void InsertPerson(string firstName,
                                 string lastName,
                                 string phone,
                                 string email,
                                 string street,
                                 string city,
                                 string province,
                                 string postalCode)
        {
            personData.Insert(firstName, lastName, phone, email, street, city, province, postalCode);
        }


        public void EditPerson(string id,
                               string firstName,
                               string lastName,
                               string phone,
                               string email,
                               string street,
                               string city,
                               string province,
                               string postalCode)
        {
            personData.Edit(Convert.ToInt32(id), firstName, lastName, phone, email, street, city, province, postalCode);
        }

    }
}
