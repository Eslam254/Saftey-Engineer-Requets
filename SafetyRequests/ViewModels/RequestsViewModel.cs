using SafetyRequests.Models.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.ViewModels
{
    public class RequestsViewModel
    {
        public Guid Id { get; set; }
        public long newId { get; set; }

        [Required, StringLength(250)]
        public string EmployeeName { get; set; }
        [Required, StringLength(250)]
        public string PlannedActivity { get; set; }
        [Required, StringLength(250)]
        public string Equipments { get; set; }
        public DateTime ModifiedDate { get; set; }
        public RequestStatus Status { get; set; }
        [Display(Name = "Working Start Date")]

        public DateTime WorkingStartDate { get; set; }
        [Display(Name = "Working End Date")]

        public DateTime WorkingEndDate { get; set; }
        [Display(Name = "Department")]
        public Guid DepartmentId { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        [Display(Name = "Employee Roles")]
        public Guid EmployeeRoleId { get; set; }
        public IEnumerable<EmployeeRole> EmployeeRoles { get; set; }
    }
}
