using System.Threading.Tasks;

namespace FinTech.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}