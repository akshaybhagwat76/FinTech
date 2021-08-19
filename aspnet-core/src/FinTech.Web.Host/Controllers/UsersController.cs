using Abp.AspNetCore.Mvc.Authorization;
using FinTech.Authorization;
using FinTech.Storage;
using Abp.BackgroundJobs;

namespace FinTech.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}