using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Interfaces;
using DemoApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class ComplaintController : Controller
    {
        private readonly IComplaintRepository _complaintRepository;
        private readonly IComplaintStatusRepository _complaintStatusRepository;
        private readonly IComplaintTypeRepository _complaintTypeRepository;
        public ComplaintController(IComplaintRepository ComplaintRepository, IComplaintStatusRepository ComplaintStatusRepository, IComplaintTypeRepository ComplaintTypeRepository)
        {
            _complaintRepository = ComplaintRepository;
            _complaintTypeRepository = ComplaintTypeRepository;
            _complaintStatusRepository = ComplaintStatusRepository;
        }
        [Authorize]
        public IActionResult List()
        {
            if (TempData["Success"] != null)
                ViewBag.Success = TempData["Success"];
            if (TempData["Failure"] != null)
                ViewBag.Success = TempData["Failure"];
            var temp = _complaintRepository.UnResolvedComplaints;
            foreach (var item in temp)
            {
                item.ComplaintType = _complaintTypeRepository.ActiveComplaintTypes.Where(x => x.ComplaintTypeId == item.ComplaintTypeId).FirstOrDefault();
                item.ComplaintStatus= _complaintStatusRepository.StatusList.Where(x => x.ComplaintStatusId == item.StatusId).FirstOrDefault();
            }
            return View(_complaintRepository.UnResolvedComplaints);
        }
        [Authorize]
        public IActionResult Create()
        {
            ViewBag.ComplaintTypeList = _complaintTypeRepository.ActiveComplaintTypes.Select(x=> new { Id = x.ComplaintTypeId, Name=x.Title });
            ViewBag.ComplaintStatusList = _complaintStatusRepository.StatusList.Select(x => new { Id = x.ComplaintStatusId, Name = x.Title });
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult Create(Complaint Complaint)
        {
            try
            {
                Complaint.Timestamp = DateTime.Now;
                Complaint.IsResolved = false;
                Complaint.StatusId = 1;
                _complaintRepository.AddComplaint(Complaint);
                TempData["Success"] = "Complaint Added Successfully";
            }
            catch {
                TempData["Failure"] = "Some Error Occured";
            }
            return RedirectToAction(nameof(List));
        }
    }
}