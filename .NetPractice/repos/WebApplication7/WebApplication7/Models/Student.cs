﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Student
    {
        [Key]
        public int  StudentId { get; set; }

        public string Name { get; set; }
    }
}
