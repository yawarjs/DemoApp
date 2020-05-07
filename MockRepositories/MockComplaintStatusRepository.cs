using DemoApp.Interfaces;
using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.MockRepositories
{
    public class MockComplaintStatusRepository : IComplaintStatusRepository
    {
        public IEnumerable<ComplaintStatus> StatusList
        {
            get
            {
                return new List<ComplaintStatus>()
                {
                    new ComplaintStatus{ComplaintStatusId =1 , IsActive = true, Title = "Request In Queue"  },
                    new ComplaintStatus{ComplaintStatusId =2 , IsActive = true, Title = "Assigned to Representative"  },
                    new ComplaintStatus{ComplaintStatusId =3 , IsActive = true, Title = "In Progress"  },
                    new ComplaintStatus{ComplaintStatusId =4 , IsActive = true, Title = "Resolved"  },
                    new ComplaintStatus{ComplaintStatusId =5 , IsActive = true, Title = "Closed"  }
                };
            }
        }
    }
}
