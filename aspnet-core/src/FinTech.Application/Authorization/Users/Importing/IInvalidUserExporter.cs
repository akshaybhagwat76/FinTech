using System.Collections.Generic;
using FinTech.Authorization.Users.Importing.Dto;
using FinTech.Dto;

namespace FinTech.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
