using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharpFrameWork.generic;
using RestSharpFrameWork.PocoClassRmgYantra.EmployeeController;
using System;
using System.Net;
using System.Web.UI.WebControls;

namespace OdbcProject.Odbc_Practise
{
    [TestClass]
    public class UnitTest3
    {
        ExcelUtility excelUtility=new ExcelUtility();

       

        EndPoints endPoints = new EndPoints();

        [TestMethod]
        [TestCategory("GET Project")]
        public void Method1()
        {
            string url = "http://localhost:8084/projects";
            RestClient client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            var output = client.Execute(request);
            Console.WriteLine(output.Content);

            Assert.AreEqual(HttpStatusCode.OK, output.StatusCode);
        }

        [TestMethod]
        [TestCategory("GET ByName")]
        public void Method2()
        {
            string url = "http://localhost:8084/projects";
            RestClient client = new RestClient(url);
            var request = new RestRequest("HRA", Method.GET);
            var output = client.Execute(request);
            Console.WriteLine(output.Content);
        }

        [TestMethod]
        [TestCategory("GET ByID")]
        public void Method3()
        {
            string url = "http://localhost:8084/projects/TY_PROJ_206";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest("TY_PROJ_001", Method.GET);
            var output = client.Execute(request);
            Console.WriteLine(output.Content);

            //Validation
            Assert.AreEqual(HttpStatusCode.OK, output.StatusCode);
        }

        [TestMethod]
        [TestCategory("POST")]
        public void PostProject()
        {

              string url = "http://localhost:8084/addProject";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(new Project()
            {
                //  projectManager="Waris",
                createdBy= excelUtility.GetCellValue("POST", 0, 0),
              projectName = excelUtility.GetCellValue("POST", 0, 0),
                status = excelUtility.GetCellValue("POST", 0, 0),
                teamSize = 5

            });
            var output = client.Execute(request);
            Console.WriteLine(output.Content);
            Console.WriteLine();
            Console.WriteLine(output.StatusCode);

   
        }

        [TestMethod]
        [TestCategory("POST")]
        public void postPro()
        {
            string url = "http://localhost:8084/addProject";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(new Project()
            {
                createdBy = "waris",
                projectName = "NewApp",
                status = "created",
                teamSize = 3
            });
            var output = client.Execute(request);
            Console.WriteLine(output.Content);
        }

        [TestMethod]
        [TestCategory ("PUT")]
        public void Method4()
        {
         //   string url = "http://localhost:8084/projects/{projectId}";
            // Status url = "http://localhost:8084/projects/TY_PROJ_204";

            string url = "http://localhost:8084/projects/TY_PROJ_202";

            RestClient client = new RestClient(url);
            RestRequest request =new RestRequest(Method.PUT);
            request.AddJsonBody( new Project()
            {
                createdBy = "Waris",
                projectName = "HouseRentalApp",
                status = "On Going",
                teamSize = 8
            });

        }


        [TestMethod]
        [TestCategory("DELETE")]
        public void Delete()
        {
            string url = "http://localhost:8084/projects/TY_PROJ_204";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.PUT);
            var output = client.Execute(request);
            Console.WriteLine(output.Content);
            Console.WriteLine(output.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, output.StatusCode);
        }

    }
    
}
