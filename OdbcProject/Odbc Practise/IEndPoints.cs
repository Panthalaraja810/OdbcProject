using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestSharpFrameWork.generic
{ 

    public interface IEndPoints
    {
       
        string projectId { get; set; }

        string login { get; set; }

     
        string error { get; set; }

    
        string addProject { get; set; }

    
        string projects { get; set; }

 \
        string projectsId { get; set; }
    }

    public class EndPoints : IEndPoints
    {

     
        public string login { get; set; }
        public string error { get; set; }
        public string addProject { get; set; }
        public string projects { get; set; }
        public string projectsId { get; set; }
        public string projectId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public EndPoints()
        {
           
            login = "login/";
            error = "error/";
            addProject = "addProject/";
            projects = "projects/";
            projectsId = "projects/{endpoint}/";
        }
    }

}
