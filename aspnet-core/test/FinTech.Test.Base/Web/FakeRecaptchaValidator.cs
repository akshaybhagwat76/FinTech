using System.Threading.Tasks;
using FinTech.Security.Recaptcha;

namespace FinTech.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
