using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("MakeId")]
        public Make Make { get; set; }
        public int MakeId { get; set; }
    }
}