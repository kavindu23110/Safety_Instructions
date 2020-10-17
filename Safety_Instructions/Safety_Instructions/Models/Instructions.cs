using System;
using System.Collections.Generic;
using System.Text;

namespace Safety_Instructions.Models
{
   public class Instructions:BaseModel
    {
        public string DiseaseId { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}
