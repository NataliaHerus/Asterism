using System.ComponentModel.DataAnnotations;

namespace AsterismWay.IdentityServer.Models.Identity
{
    public class PasswordResetModel
    {

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? ConfirmPassword { get; set; }
    }
}
