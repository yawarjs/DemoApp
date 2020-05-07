using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Interfaces
{
    public interface IComplaintTypeRepository
    {
        IEnumerable<ComplaintType> ActiveComplaintTypes { get; }
    }
}
