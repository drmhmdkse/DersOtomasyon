using BusinessLayer.Abstract;
using DAL.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DpManager : IDpManager // DersProgram manager
    {
        EfDersProgramDal _DersProgramDal = new EfDersProgramDal();
        public void AddProgram(DersProgram program)
        {
            _DersProgramDal.AddProgram(program);
         
        }

        public List<DersProgram> GetAll()
        {
            return _DersProgramDal.GetAll();
        }
    }
}
