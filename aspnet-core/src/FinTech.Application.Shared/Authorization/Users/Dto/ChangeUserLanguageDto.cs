using System.ComponentModel.DataAnnotations;

namespace FinTech.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
