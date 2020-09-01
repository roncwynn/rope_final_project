using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Contexts;
using RopeFinalProjectBackEnd.Models;

namespace RopeFinalProjectBackEnd.Repositories
{
   public class QuestionRepository : Repository<Question>, IRepository<Question>
   {
      public QuestionRepository(ReleaseTasksAPIContext context) : base(context)
      {
      }

   }
}
