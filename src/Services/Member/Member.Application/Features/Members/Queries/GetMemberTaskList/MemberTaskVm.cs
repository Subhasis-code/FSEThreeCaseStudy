using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Queries.GetMemberTaskList
{
    public class MemberTaskVm
    {
        public string MemberName { get; set; }
        public int MemberId { get; set; }
        public string TaskName { get; set; }
        public string Deliverables { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndtDate { get; set; }
    }
}
