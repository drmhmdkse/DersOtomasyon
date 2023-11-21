using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Interval: IEntity // interval: derslerin saatleri
    {
        public int IntervalId { get; set; }
        public int IntervalOfday { get; set; }
        public ICollection<DersProgram> DersProgram { get; set; }
    }
}
