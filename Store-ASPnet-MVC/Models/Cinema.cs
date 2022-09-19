using System.ComponentModel.DataAnnotations;

namespace Store_ASPnet_MVC.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Кинотеатр")]
        public string Logo { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
