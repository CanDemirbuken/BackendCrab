using BackendCrab.Core.DTOs;
using BackendCrab.EntityLayer.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.Core.Services
{
    public interface IGenericService<Entity, Dto> where Entity : BaseEntity where Dto : class
    {
        Task<CustomResponseDTO<IEnumerable<Dto>>> GetAllAsync();
        Task<CustomResponseDTO<Dto>> GetByIdAsync(int id);
        Task<CustomResponseDTO<Dto>> AddAsync(Dto dto);
        Task<CustomResponseDTO<NoContentDTO>> UpdateAsync(Dto dto);
        Task<CustomResponseDTO<NoContentDTO>> RemoveAsync(int id);
    }
}
