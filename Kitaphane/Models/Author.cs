﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kitaphane.Models
{
    public class Author
    {


        [Key]
        public string Name { get; set; }
    }
}
