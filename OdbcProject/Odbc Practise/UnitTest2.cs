using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
// RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlow.Internal.Json;
using System.Security.Policy;
using System.Net;
//using RPocoClassRmgYantra.EmployeeController;

namespace OdbcProject.Odbc_Practise
{
    [TestClass]

    public class UnitTest2
    {
        public string url = "http://localhost:8085/projects";

        [TestMethod]
        [TestCategory("GET")]
        public void GetEmployees()
        {
            RestClient client = new RestClient(url);

            var request = new RestRequest(Method.GET);
            var output = client.Execute(request);
            Console.WriteLine(output.Content);
        }

       /* [TestMethod]
        [TestCategory("POST")]
        public void PostEmployee()
        {
           RestClient client = new RestClient(url); 
            RestRequest request =new RestRequest(Method.POST);
            request.AddJsonBody(new Employee {
                email = "panthalaraja",
                designation = "AutomationTestEngineer",
                experience = 3.3,
                empName = "Raja",
                mobileNo = "1234567890",
                project = "HRA",
                role = "TestEng"
            });
                

            var output = client.Execute(request);   
            Console.WriteLine(output.Content);
            Console.WriteLine(output.StatusCode);

            Assert.AreEqual(HttpStatusCode.Created, output.StatusCode);

        }

        */



    }
}
