using DemoApp.Interfaces;
using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.MockRepositories
{
    public class MockComplaintTypeRepository : IComplaintTypeRepository
    {
        public IEnumerable<ComplaintType> ActiveComplaintTypes
        {
            get
            {
                return new List<ComplaintType>()
                {
                    new ComplaintType{ComplaintTypeId =1 , IsActive = true, Title = "Service Related Issue"  },
                    new ComplaintType{ComplaintTypeId =2 , IsActive = true, Title = "New Service Request"  },
                    new ComplaintType{ComplaintTypeId =3 , IsActive = true, Title = "Service Dis-continue Request"  }
                };
            }
        }
    }
}
