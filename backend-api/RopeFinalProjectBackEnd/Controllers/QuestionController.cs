using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Repositories;

namespace RopeFinalProjectBackEnd.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class QuestionController : ControllerBase
   {
      private IRepository<Question> questionRepo;

      public QuestionController(IRepository<Question> otherRepo)
      {
         this.questionRepo = otherRepo;
      }

      public IEnumerable<Question> Get()
      {
         return questionRepo.GetAll();
      }

      // GET api/<QuestionController>/5
      [HttpGet("{id}")]
      public Question Get(int id)
      {
         return questionRepo.GetById(id);
      }

      // POST api/<QuestionController>
      [HttpPost]
      public IEnumerable<Question> Post([FromBody] Question value)
      {
         questionRepo.Create(value);
         return questionRepo.GetAll();
      }

      // PUT api/<QuestionController>/5
      [HttpPut("{id}")]
      public void Put(int id, [FromBody] string value)
      {
      }

      // DELETE api/<QuestionController>/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {
      }
   }
}
