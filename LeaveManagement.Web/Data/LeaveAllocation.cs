using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
       
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public Guid LeaveTypeId { get; set; }

        public Guid EmployeeId { get; set; }


    }
}
