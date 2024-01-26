using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Repository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
