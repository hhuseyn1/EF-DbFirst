﻿using System;
using System.Collections.Generic;

namespace EF_DbFirst.Models
{
    public partial class Department
    {
        public Department()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
