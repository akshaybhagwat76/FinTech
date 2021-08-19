using System.ComponentModel.DataAnnotations;

namespace FinTech.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}