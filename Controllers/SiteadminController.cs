using System;
using System.Collections.Generic;
using System.Web.Http;

namespace QuestionApp.Controllers
{
    public class SiteadminController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CheckUserExists(User user)
        {
            return Ok(true);
        }

        [HttpGet]
        public IHttpActionResult GetAllModule()
        {
            var testModel = new List<ModuleModel>();
            for (int i = 0; i < 10; i++)
            {
                var test = new ModuleModel();
                test.Id = i + 1;
                test.Name = "Name " + i;
                test.CreatedDate = DateTime.Now.AddDays(i);
                test.Status = 2;
                testModel.Add(test);
            }
            return Ok(testModel);
        }
    }

    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }

    public class ModuleModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Status { get; set; }
    }
}
