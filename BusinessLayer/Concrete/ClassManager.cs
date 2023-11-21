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
    public class ClassManager : IClassManager
    {
        EfClassDal _classDal = new EfClassDal();
        public void Add(Class classInstance)
        {
            throw new NotImplementedException(); //TODO: Bakilacak
        }

        public Class GetById(int classId)
        {
            throw new NotImplementedException();
        }
    }
}
