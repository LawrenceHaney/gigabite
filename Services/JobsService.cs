using System.Collections.Generic;
using gigabite.Models;
using gigabite.Repositories;

namespace gigabite.Service
{
    public class JobsService
    {
      private readonly JobsRepository _repo;
      public JobsService(JobsRepository repo)
      {
        _repo = repo;
      }
      
      internal IEnumerable<Job> GetAll()
      {
        return _repo.GetAll();
      }

      internal Job GetById(int id)
      {
        var data = _repo.GetById(id);
        if(data == null)
        {
          throw new System.Exception("Invalid Id");
        }
        return data;
      }

      internal Job Create(Job newJob)
      {
        return _repo.Create(newJob);
      }

      internal Job Edit(Job updated)
      {
        var data = GetById(updated.Id);
        updated.Description = updated.Description != null ? updated.Description
         : data.Description;
         updated.Location = updated.Location != null ? updated.Location
         : data.Location;
         updated.Contact = updated.Contact != null ? updated.Contact
         : data.Contact;

         return _repo.Edit(updated);
      }

      internal string Delete(int id)
      {
        var data = GetById(id);
        _repo.Delete(id);
        return "Deleted";
      }
    }
}