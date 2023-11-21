using DAL.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EntityFramework
{
    public class EfDersProgramDal : IDersProgramDal
    {
        AppDbContext _dbContext = new AppDbContext();
        public void AddProgram(DersProgram d)
        {
            _dbContext.DersPrograms.Add(d);
            _dbContext.SaveChanges();
        }

        public List<DersProgram> GetAll()
        {
            return _dbContext.DersPrograms.ToList();
        }
    }
}
