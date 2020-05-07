using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class Complaint
    {
        public int ComplaintId { get; set; }
        [DisplayName("Complaint Type")]
        [Required]
        public int ComplaintTypeId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        [DisplayName("Name")]
        [Required]
        public string ComplaineeName { get; set; }
        [Required]
        public string Address { get; set; }
        [DisplayName("Contact")]
        [Required]
        public string ContactDetails { get; set; }
        [DisplayName("Status")]
        public int StatusId { get; set; }
        [DisplayName("Resolved")]
        public bool IsResolved { get; set; }
        [DisplayName("Reported At")]
        public DateTime Timestamp { get; set; }
        public virtual ComplaintType ComplaintType { get; set; }
        public virtual ComplaintStatus ComplaintStatus { get; set; }
    }
}
