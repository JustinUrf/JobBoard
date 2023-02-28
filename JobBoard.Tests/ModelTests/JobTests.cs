using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Test
{
  [TestClass]
  public class JobTests : IDisposable
  {
    public void Dispose()
    {
      Job.ClearAll();
    }

    [TestMethod]
    public void JobConstructor_CreatesInstanceOfJob_Job()
    {
      Job newJob = new Job("test", "filler", "filler");
      Assert.AreEqual(typeof(Job), newJob.GetType());
    }

    [TestMethod]
    public void JobConstructor_HasPropertiesOfJob_InputtedDescription()
    {
      Job newJob = new Job("Engineer", "Work long hours","AdaLovelace@hotmail.com");
      Assert.AreEqual("Engineer", newJob.JobTitle);
      Assert.AreEqual("Work long hours", newJob.JobDescription);
      Assert.AreEqual("AdaLovelace@hotmail.com", newJob.ContactInfo);
    }


    [TestMethod]
    public void GetAll_ReturnsEmptyList_JobList()
    {
      List<Job> newList = new List<Job> { };
      List<Job> result = Job.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}