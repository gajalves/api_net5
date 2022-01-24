using System.ComponentModel.DataAnnotations;

namespace api_net5.ViewModels
{
    public class AuthViewModel
    {
        [Required(ErrorMessage = "O Login não pode ser vazio.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A Senha não pode ser vazia.")]
        public string Password { get; set; }
    }
}
