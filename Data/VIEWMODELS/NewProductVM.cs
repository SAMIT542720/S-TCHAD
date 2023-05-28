using System.ComponentModel.DataAnnotations;

namespace S_TCHAD.Data.VIEWMODELS
{
    public class NewProductVM
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? PhotoURL1 { get; set; }
        public string? PhotoURL2 { get; set; }
        public string? PhotoURL3 { get; set; }
        public string? Description { get; set; }
        public string? Sex { get; set; }
    }
}
