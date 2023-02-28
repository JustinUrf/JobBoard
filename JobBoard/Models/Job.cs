using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {    
    public string JobTitle { get; set; }
    public string JobDescription { get; set; }
    public string ContactInfo { get; set; }
    
    private static List<Job> _instances = new List<Job> { };
    public Job(string jobtitle, string jobdescription, string contactinfo)
    {
      JobTitle = jobtitle;
      JobDescription = jobdescription;
      ContactInfo = contactinfo;
      _instances.Add(this);
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }

}