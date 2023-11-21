using Entities.Abstract;

namespace Entities.Concrete
{
    public  class Derslik : IEntity // TODO: sınıfın dersliği eklenebilir
    {
        public int DerslikId { get; set; } 
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public ICollection<DersProgram> DersProgram { get; set; }
    }
}
