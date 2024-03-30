using AutoMapper;
using BackendCrab.Core.DTOs.CompanyDTOs;
using BackendCrab.Core.Repositories;
using BackendCrab.Core.Services;
using BackendCrab.Core.UnitOfWorks;
using BackendCrab.EntityLayer.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.BusinessLayer.Service
{
    public class CompanyService : GenericService<Company, CompanyDTO>, ICompanyService
    {
        public CompanyService(IGenericRepository<Company> genericRepository, IUnitOfWork unitOfWork, IMapper mapper) : base(genericRepository, unitOfWork, mapper)
        {
        }
    }
}
