﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocEcommerce_1.Entities
{
    public class UserCourse
    {
        public int IdUser { get; set; }
        public User User { get; set; } = default!;
        public int IdCourse { get; set; }
        public Course Course { get; set; } = default!;
        public bool IsArchived { get; set; }
    }
}
