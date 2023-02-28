using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
    public class JobsController : Controller
    {
      [HttpGet("/jobs")]
      public ActionResult Index()
      {
        List<Job> allJobs = JobBoard.GetAll();
        return View(allJobs);
      }
    }
}