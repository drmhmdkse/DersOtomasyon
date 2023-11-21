using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IClassManager
    {
        Class GetById(int classId);
        void Add(Class classInstance);
        
    }
}
