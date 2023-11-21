using Entities.Abstract;


namespace Entities.Concrete
{
    public class Day:IEntity
    {
        public int DayId { get; set; }
        public string DayName { get; set; }
        public ICollection<DersProgram> DersProgram { get; set; }

    }

    
}
