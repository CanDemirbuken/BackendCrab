using AutoMapper;
using BackendCrab.Core.DTOs;
using BackendCrab.Core.Repositories;
using BackendCrab.Core.Services;
using BackendCrab.Core.UnitOfWorks;
using BackendCrab.EntityLayer.Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.BusinessLayer.Service
{
    public class GenericService<Entity, Dto> : IGenericService<Entity, Dto> where Entity : BaseEntity where Dto : class
    {
        private readonly IGenericRepository<Entity> _genericRepository;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> genericRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CustomResponseDTO<IEnumerable<Dto>>> GetAllAsync()
        {
            var entities = await _genericRepository.GetAll().ToListAsync();
            var dtos = _mapper.Map<IEnumerable<Dto>>(entities);

            return CustomResponseDTO<IEnumerable<Dto>>.Success(StatusCodes.Status200OK, dtos);
        }

        public async Task<CustomResponseDTO<Dto>> GetByIdAsync(int id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            var dto = _mapper.Map<Dto>(entity);

            return CustomResponseDTO<Dto>.Success(StatusCodes.Status200OK, dto);
        }

        public async Task<CustomResponseDTO<Dto>> AddAsync(Dto dto)
        {
            var entity = _mapper.Map<Entity>(dto);
            await _genericRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();

            var newDto = _mapper.Map<Dto>(entity);
            return CustomResponseDTO<Dto>.Success(StatusCodes.Status200OK, newDto);
        }

        public async Task<CustomResponseDTO<NoContentDTO>> RemoveAsync(int id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            _genericRepository.Delete(entity);
            await _unitOfWork.CommitAsync();

            return CustomResponseDTO<NoContentDTO>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<CustomResponseDTO<NoContentDTO>> UpdateAsync(Dto dto)
        {
            var entity = _mapper.Map<Entity>(dto);
            _genericRepository.Update(entity);
            await _unitOfWork.CommitAsync();

            return CustomResponseDTO<NoContentDTO>.Success(StatusCodes.Status204NoContent);
        }
    }
}
