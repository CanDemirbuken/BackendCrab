using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.Core.DTOs.CompanyDTOs
{
    public class CompanyDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int FoundationYear { get; set; }
    }
}
