using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Procedures
{
    public static class PersonProcedures
    {

        public static string ShowPersons = "SELECT " +
            "Id, " +
            "FirstName, " +
            "LastName, " +
            "Phone, " +
            "Email, " +
            "Street, " +
            "City, " +
            "Province, " +
            "PostalCode " +
            "FROM Persons;";


        public static string EditPerson = "UPDATE Persons SET " +
            "FirstName = @firstName, " +
            "LastName = @lastName, " +
            "Phone = @phone, " +
            "Email = @email, " +
            "street = @street, " +
            "City = @city, " +
            "Province = @province, " +
            "PostalCode = @postalCode " +
            "WHERE Id = @idPk;";


        public static string SelectPerson = "SELECT " +
            "id, " +
            "FirstName, " +
            "LastName, " +
            "Phone, " +
            "Email, " +
            "Street, " +
            "City, " +
            "Province, " +
            "PostalCode, " +
            "CONCAT (FirstName, ' ', LastName) AS Name " +
            "FROM Persons " +
            "WHERE id like @idPk;";


        public static string PersonList = "SELECT " +
            "id, " +
            "CONCAT(FirstName, ' ', LastName) AS Name, " +
            "Phone, " +
            "Email, " +
            "Street, " +
            "City, " +
            "Province, " +
            "PostalCode " +
            "FROM Persons;";


        public static string InsertPerson = "INSERT INTO Persons VALUES (" +
            "@firstName, " +
            "@lastName, " +
            "@phone, " +
            "@email, " +
            "@street, " +
            "@city, " +
            "@province, " +
            "@postalCode);";

    }
}
