using System.ComponentModel.DataAnnotations;

namespace Store_ASPnet_MVC.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Фото режиссера")]
        public string PictureProfileURL { get; set; }
        [Display(Name = "Полное имя")]
        public string FullName { get; set; }
        [Display(Name = "Биография")]
        public string Biography { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
