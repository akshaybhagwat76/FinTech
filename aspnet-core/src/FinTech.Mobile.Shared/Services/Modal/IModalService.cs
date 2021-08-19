using System.Threading.Tasks;
using FinTech.Views;
using Xamarin.Forms;

namespace FinTech.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
