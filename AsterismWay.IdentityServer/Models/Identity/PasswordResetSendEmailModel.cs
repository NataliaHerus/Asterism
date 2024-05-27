using static AsterismWay.IdentityServer.Validators.IdentityValidation;
using System.ComponentModel.DataAnnotations;

namespace AsterismWay.IdentityServer.Models.Identity
{
    public class PasswordResetSendEmailModel
    {
        [Required]
        [Email]
        public string? Email { get; set; }
    }
}
