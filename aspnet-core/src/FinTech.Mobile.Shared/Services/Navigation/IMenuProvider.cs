using System.Collections.Generic;
using MvvmHelpers;
using FinTech.Models.NavigationMenu;

namespace FinTech.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}