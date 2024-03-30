using BackendCrab.Core.DTOs.CompanyDTOs;
using BackendCrab.EntityLayer.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.Core.Services
{
    public interface ICompanyService : IGenericService<Company, CompanyDTO>
    {
    }
}
