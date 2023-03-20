using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    private ApplicationDbContext _dbContext;
    public class AttendancesController : ApiController
    {
        _dbContext=new ApplicationDbContext();

    }
    [HttpPost]
    public IHttpActionResult Attend([FromBody] int courseId)
    {
        var attendance=new Attendance(

            )
    }
}
