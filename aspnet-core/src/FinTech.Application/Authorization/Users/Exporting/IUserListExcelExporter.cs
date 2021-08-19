using System.Collections.Generic;
using FinTech.Authorization.Users.Dto;
using FinTech.Dto;

namespace FinTech.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}