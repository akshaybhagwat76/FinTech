using System.Collections.Generic;
using FinTech.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace FinTech.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
