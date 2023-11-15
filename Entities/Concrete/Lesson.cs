using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Name { get; set;}
        public int TotalHours { get; set; }
        public int Length { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
