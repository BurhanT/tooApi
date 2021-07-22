using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tooApi.Models;

namespace tooApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Table> Get()
        {
            using (var context= new TestDBContext())
            {
                //Create New User !DID NOT WORK!
                //Table user = new();
                //user.Name = "Tim";
                //user.Age = 12;
                //context.Tables.Add(user);

                //Get all Users from Table
                return context.Tables.ToList();

                //Get user by ID
                //return context.Tables.Where(auth => auth.Id == 1).ToList();



            }
        }
    }
}
