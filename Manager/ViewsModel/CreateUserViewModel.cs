using System.ComponentModel.DataAnnotations;

namespace Manager.ViewsModel
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage ="O nome não pode ser vazio")]
        [MinLength(3,ErrorMessage = "Digite um nome valido")]
        [MaxLength(80, ErrorMessage = "Digite um nome valido")]
        public string Name { get; set; }


        [Required(ErrorMessage = "O email não pode ser vazio")]
        [MinLength(10, ErrorMessage = "Digite um email valido")]
        [MaxLength(40, ErrorMessage = "Digite um email valido")]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha não pode ser vazia")]
        [MinLength(8, ErrorMessage = "Digite uma senha valida")]
        [MaxLength(20, ErrorMessage = "Digite uma senha valida")]
        public string Password { get; set; }
    }
}
