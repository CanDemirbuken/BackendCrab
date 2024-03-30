using AutoMapper;
using BackendCrab.Core.DTOs;
using BackendCrab.Core.DTOs.EmployeeDTOs;
using BackendCrab.Core.Repositories;
using BackendCrab.Core.Services;
using BackendCrab.Core.UnitOfWorks;
using BackendCrab.EntityLayer.Entitites;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.BusinessLayer.Service
{
    public class EmployeeService : GenericService<Employee, EmployeeDTO>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IGenericRepository<Employee> genericRepository, IUnitOfWork unitOfWork, IMapper mapper, IEmployeeRepository employeeRepository) : base(genericRepository, unitOfWork, mapper)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<CustomResponseDTO<EmployeeDTO>> AddAsync(EmployeeCreateDTO employeeCreateDTO)
        {
            var entity = _mapper.Map<Employee>(employeeCreateDTO);
            await _employeeRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();

            var newDto = _mapper.Map<EmployeeDTO>(entity);
            return CustomResponseDTO<EmployeeDTO>.Success(StatusCodes.Status200OK, newDto);
        }

        public async Task<CustomResponseDTO<List<EmployeeDTO>>> GetEmployeesWithCompanyAsync()
        {
            var entities = await _employeeRepository.GetEmployeesWithCompany();
            var dtos = _mapper.Map<List<EmployeeDTO>>(entities);

            return CustomResponseDTO<List<EmployeeDTO>>.Success(200, dtos);
        }

        public async Task<CustomResponseDTO<NoContentDTO>> UpdateAsync(EmployeeUpdateDTO employeeUpdateDTO)
        {
            var entity = _mapper.Map<Employee>(employeeUpdateDTO);
            _employeeRepository.Update(entity);
            await _unitOfWork.CommitAsync();

            return CustomResponseDTO<NoContentDTO>.Success(StatusCodes.Status204NoContent);
        }
    }
}
