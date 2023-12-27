using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Facil.WebUI.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "O E-mail é obrigatório")]
    [EmailAddress(ErrorMessage = "Email com formato inválido")]
    [DisplayName("E-mail")]
    public string Email { get; set; }

    [Required(ErrorMessage = "A Senha é obrigatório")]
    [StringLength(20, ErrorMessage = "O {0} deve ser pelo menos {2} e no máximo " +
        "{1} characters long.", MinimumLength = 10)]
    [DataType(DataType.Password)]
    [DisplayName("Senha")]
    public string Password { get; set; }

    public string ReturnUrl { get; set; }
}