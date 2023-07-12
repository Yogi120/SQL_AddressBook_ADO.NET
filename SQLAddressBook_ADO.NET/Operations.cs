using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQLAddressBook_ADO.NET
{
    public class Operations
    {
        string connection = $"Data source = LP-HYD-OX105797; Database = AddressBookDB; Integrated Security = true; TrustServerCertificate = True; User Id = sa; password = cfg@1234";
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        SqlConnection sqlConnection;
        public Operations()
        {
            sqlConnection = new SqlConnection(connection);
        }

        public void AddContact(Contact contact)
        {
            sqlConnection.Open();

            string query = $"INSERT INTO contacts VALUES('{contact.Name}', '{contact.Email}', '{contact.PhoneNumber}', '{contact.State}', '{contact.City}', '{contact.ZipCode}')";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine("Contact added successfully!");
            }
            else
            {
                Console.WriteLine("Failed to add contact!");
            }

            sqlConnection.Close();
        }

    }
}
