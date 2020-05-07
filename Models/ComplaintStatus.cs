using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class ComplaintStatus
    {
        public int ComplaintStatusId { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public List<Complaint> Complaints { get; set; }
    }
}
