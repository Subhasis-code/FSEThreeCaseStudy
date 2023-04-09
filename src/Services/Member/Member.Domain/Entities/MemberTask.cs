using Member.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Domain.Entities
{
    public class MemberTask : EntityBase
    {
        public string MemberName { get; set; }
        public int MemberId { get; set; }
        public string TaskName { get; set; }
        public string Deliverables { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndtDate { get; set; }
    }
}
