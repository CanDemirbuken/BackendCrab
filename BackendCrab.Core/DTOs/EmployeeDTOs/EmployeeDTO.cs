using BackendCrab.Core.DTOs.CompanyDTOs;
using BackendCrab.EntityLayer.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.Core.DTOs.EmployeeDTOs
{
    public class EmployeeDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public int CompanyId { get; set; }
        public CompanyDTO Company { get; set; }
    }
}
