using Store_ASPnet_MVC.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Store_ASPnet_MVC.Models
{
    public class Actor: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Фото актера")]
        [Required(ErrorMessage ="Нужно фото актера")]
        public string PictureProfileURL { get; set; }

        [Display(Name = "Полное имя")]
        [Required(ErrorMessage = "Нужно полное имя актера")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Полное имя должно содержать от 3 до 30 символов")]
        public string FullName { get; set; }

        [Display(Name = "Биография")]
        [Required(ErrorMessage = "Нужна биография актера")]
        public string Biography { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
