using DAL.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EntityFramework
{
    public class EfClassDal:IClassDal
    {
        AppDbContext _dbContext = new AppDbContext();

        public void Add(Class classInstance)
        {
            throw new NotImplementedException(); // TODO: bakilacak
        }

        public Class GetById(int classId)
        {
            return _dbContext.Classes.Find(classId);
        }
    }
}
