using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class DersProgram:IEntity
    {
        public int DersProgramId { get; set; }
        public int TotalLessonInDay { get; set; } //Todo: başka bir tablo oluşturulbilir
        public int TotalDay { get; set; }
        public int TotalHours { get; set; }
        public int Length { get; set; }

        #region composite keys
        public int ClassId { get; set; }
        public int LessonId { get; set; }
        public int DerslikId { get; set; }
        public int TeacherId { get; set; }
        public int DayId { get; set; }
        public int IntervalId { get; set; }
        public Class Class { get; set; }
        public Lesson Lesson { get; set; }
        public Derslik Derslik { get; set; }
        public Teacher Teacher { get; set; }
        public Day Day { get; set; }
        public Interval Interval { get; set; }
        #endregion

    }
}
