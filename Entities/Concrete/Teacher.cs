﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Teacher: IEntity
    {
        public int TeacherId { get; set; }
        public string FullName { get; set; }
        public string TeacherColorHex { get; set; }
        public ICollection<DersProgram> DersProgram { get; set; }
    }
}
