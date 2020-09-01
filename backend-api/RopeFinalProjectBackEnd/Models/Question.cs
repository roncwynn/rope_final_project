using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RopeFinalProjectBackEnd.Models
{
   public class Question
   {
      public int ID { get; set; }
      public string QuestionText { get; set; }
      public bool IsVisible { get; set; }

      public int ReleaseTaskID { get; set; }


   }
}
