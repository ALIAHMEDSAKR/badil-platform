using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.Admin.Queries.GetAdminDashboard
{
    public class AdminDashboardDto
    {
        public int TotalUsers { get; set; }
        public int TotalAdmins { get; set; }
    }
}
