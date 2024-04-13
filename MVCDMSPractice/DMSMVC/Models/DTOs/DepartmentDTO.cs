﻿using DMSMVC.Models.Entities;

namespace DMSMVC.Models.DTOs
{
    public class DepartmentDTO
    {
        public string? Id { get; set; }
        public string? DepartmentName { get; set; } = default!;
        public string? Acronym { get; set; } = default!;
        public string? HeadOfDepartmentStaffNumber { get; set; }
        public ICollection<Staff> Staffs { get; set; } = new HashSet<Staff>();
        public ICollection<Document> Documents { get; set; } = new HashSet<Document>();
    }

    public class DepartmentRequestModel
    {
        public string? DepartmentName { get; set; }
        public string? Acronym { get; set; } = default!;
    }

    public class DepartmentUpdateModel
    {
        public string? DepartmentName { get; set; } = default!;
        public string? Acronym { get; set; } = default!;
        public string? StaffNumberOfPotentialHOD { get; set; }
    }
    
}
