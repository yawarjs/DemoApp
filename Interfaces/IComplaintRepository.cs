using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Interfaces
{
    public interface IComplaintRepository
    {
        IEnumerable<Complaint> Complaints { get;}
        IEnumerable<Complaint> UnResolvedComplaints { get; }
        IEnumerable<Complaint> GetComplaintsByStatus(int StatusId);
        Complaint GetComplaint(int ComplaintId);
        bool AddComplaint(Complaint Complaint);
    }
}
