using Entities.Abstract;

namespace Entities.Concrete
{
    public  class DerslikEntity : IEntity
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public int TotalHours { get; set; }
        public string ColorHexCode { get; set; }
    }
}
