﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Safety_Instructions.Data.Models
{
  public  class Symptoms
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String AnimationJson { get; set; }
    }
}