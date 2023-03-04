using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Models.DB
{
    public class Request : BaseEntity
    {
        public string EmployeeName { get; set; }
        public string PlannedActivity { get; set; }
        public string Equipments { get; set; }
        public DateTime WorkingStartDate { get; set; }
        public RequestStatus Status { get; set; }
        public DateTime WorkingEndDate { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        public Guid RoleId { get; set; }
        public EmployeeRole EmployeeRole { get; set; }
    }
    public enum RequestStatus
    {
        New,
        Approved,
        Rejected
    }
}
