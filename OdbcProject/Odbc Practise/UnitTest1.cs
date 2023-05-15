using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
namespace OdbcProject.Odbc_Practise
{
    [TestClass]
    public class DataBase
    {
        OdbcCommand command; //should be imported from  System.Data.Odbc
        
        
        [TestMethod]
        [TestCategory("odbc connection to fetch data")]
        public void TestMethod1()
        {
            //string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost:3306;DataSource:database;Database=projects;User=root;Password=root;";

            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost:3306;Database=projects;User=root;Password=root;";

            OdbcConnection connection = new OdbcConnection(connectionString);
              connection.Open();


            Console.WriteLine(connection.ConnectionString);  //printing above connectionString we were passing
            Console.WriteLine(connection.ConnectionTimeout); //printing the timeout
            Console.WriteLine(connection.Database);         //printing the database (eg: we were currently created the database projects in our mysql)
            Console.WriteLine(connection.Driver);           //driver details
            Console.WriteLine(connection.ServerVersion);    //server version





            string query = "select * from project";

            command = new OdbcCommand(query, connection);
             
            var response =command.ExecuteReader();

            while(response.Read())
            {
                Console.WriteLine(response[0]+" " + response[1]+" "+response[2]+" " + response[3]+" " + response[4]+" " + response[5]);
            }

        }
    }
}
