using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Class:IEntity
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public ICollection<DersProgram>  DersProgram { get; set; }

    }
}
