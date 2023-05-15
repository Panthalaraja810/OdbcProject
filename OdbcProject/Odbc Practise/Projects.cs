using Newtonsoft.Json;
using RestSharpFrameWork.generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpFrameWork.PocoClassRmgYantra.EmployeeController
{
  
    public class Project
    {


        [JsonProperty("projectName")]
        public string projectName { get; set; }

        [JsonProperty("teamSize")]
        public int teamSize { get; set; }

        [JsonProperty("projectManager")]
        public string createdBy { get; set; }


        [JsonProperty("status")]
        public string status { get; set; }


        public Project ProjectBody(string projectName, string status)
        {

            CSharpUtilitys utilitys = new CSharpUtilitys();
            int num = utilitys.RandomInt();
            Project pro = new Project
            {
                createdBy = "waris",
                projectName = projectName + num,
                status = status.ToString(),
                teamSize = 0

            };
            return pro;
        }

        public Project ProjectBody(string projectName, string teamsize, string projectManager, string status)
        {

            Project pro = new Project
            {
                
                projectName = projectName,
                teamSize = int.Parse(teamsize),
                createdBy = projectManager,
                status = status

            };
            return pro;
        }
    }

    public interface IStatus
    {
        string created { get; set; }
        string completed { get; set; }
        string onGoging { get; set; }
    }
    public class Status : IStatus
    {
        public string created { get; set; }
        public string completed { get; set; }
        public string onGoging { get; set; }

        public Status()
        {
            created = "Created";
            completed = "Completed";
            onGoging = "OnGoing";
        }
    }



}
