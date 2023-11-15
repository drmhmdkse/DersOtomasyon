using Entities.Abstract;

namespace Entities.Concrete
{
    public  class Derslik : IEntity
    {
        public int DerslikId { get; set; } 
        public string Name { get; set; }
        public string ShortCode { get; set; }

        public ICollection<Class> Classes { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
