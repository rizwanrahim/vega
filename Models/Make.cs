using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Project.Models
{
    public class Makes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

        public Makes() => Models = new Collection<Model>();
    }
}