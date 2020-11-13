using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Procedures;

namespace DataAccess
{
    public class PersonData
    {

        private Connection connection; 

        SqlDataReader reader;
        DataTable table;       
        SqlCommand command; 

        Person person;  

        public PersonData()
        {
            connection = new Connection();
            table = new DataTable();
            command = new SqlCommand();
            person = new Person();
        }


        public DataTable Show()
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = PersonProcedures.ShowPersons;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CloseConnection();
            return table;
        }


        public Person getPerson(int id)
        {

            command.Connection = connection.OpenConnection();
            command.CommandText = "SelectCustomer";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idPk", id);

            reader = command.ExecuteReader();
            reader.Read();

            person.id = Convert.ToInt32(reader["id"]);
            person.firstName = reader["FirstName"].ToString();
            person.lastName = reader["LastName"].ToString();
            person.phone = reader["Phone"].ToString();
            person.email = reader["Email"].ToString();
            person.city = reader["City"].ToString();
            person.province = reader["Province"].ToString();
            command.Parameters.Clear();
            connection.CloseConnection();

            return person;
        }


        public DataTable PersonList()
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = PersonProcedures.PersonList;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();

            table.Load(reader);
            connection.CloseConnection();

            return table;
        }


        public void Insert(string firstNamne,
                           string lastName,
                           string phone,
                           string email,
                           string street,
                           string city,
                           string province,
                           string postalCode)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = PersonProcedures.InsertPerson;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@firstName", firstNamne);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@street", street);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@province", province);
            command.Parameters.AddWithValue("@postalCode", postalCode);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }


        public void Edit(int id,
                         string firstNamne,
                         string lastName,
                         string phone,
                         string email,
                         string street,
                         string city,
                         string province,
                         string postalCode)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = PersonProcedures.EditPerson;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@idPk", id);
            command.Parameters.AddWithValue("@firstName", firstNamne);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@street", street);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@province", province);
            command.Parameters.AddWithValue("@postalCode", postalCode);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }


        public void Remove(int id)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "RemovePerson";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id ", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

    }
}
