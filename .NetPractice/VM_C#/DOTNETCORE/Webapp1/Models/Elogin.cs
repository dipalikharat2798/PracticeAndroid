﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp1.Models
{
    public class Elogin
    {
        [Required]
        public string  Username { get; set; }

        [Required]
        public string Passw0rd { get; set; }
    }
}
