using System;
using System.Collections.Generic;
using System.Data;
using gigabite.Models;
using Dapper;

namespace gigabite.Repositories
{
    public class JobsRepository
    {
      private readonly IDbConnection _db;
      public JobsRepository(IDbConnection db)
      {
        _db = db;
      }

      internal IEnumerable<Job> GetAll()
      {
        string sql = "SELECT * FROM jobs";
        return _db.Query<Job>(sql);
      }

      internal Job GetById(int id)
      {
        string sql = "SLECT * FROM jobs Where id =@id";
        return _db.QueryFirstOrDefault<Job>(sql, new { id });
      }

      internal Job Create(Job newJob)
      {
        string sql = @"
        INSERT INTO jobs
        (location, description, contact, hours)
        VALUES
        (@Location, @Description, @Contact, @Hours)
        SELECT LAST_INSERT_ID();";
        int id = _db.ExecuteScalar<int>(sql, newJob);
        newJob.Id = id;
        return newJob;
      }

      internal Job Edit(Job updated)
      {
        string sql = @"
        UPDATE jobs
        SET
          location = @Location,
          description = @Description,
          contact = @Contact,
          hours = @Hours
          WHERE id = @Id,";
          _db.Execute(sql, updated);
          return updated;
      }

      internal void Delete(int id)
      {
        string sql = "DELETE FROM jobs WHERE id = @id";
        _db.Execute(sql, new { id });
      }
    }
}