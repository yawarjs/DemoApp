using DemoApp.Interfaces;
using DemoApp.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace DemoApp.MockRepositories
{
    public class MockComplaintRepository : IComplaintRepository
    {
        private static List<Complaint> complaintList = new List<Complaint>()
                {
                    new Complaint{
                        ComplaintId = 1,
                        ComplaintTypeId =1 ,
                        Details =" Our Service is disconnected since morning :( ",
                        Title = "Service Disconnected!!",
                        IsResolved= false,
                        StatusId = 1,
                        Address= "office # 1, ABC street, xyz area , karachi ",
                        ComplaineeName= "Health Office",
                        ContactDetails= "0345-1234567",
                        Timestamp= DateTime.Now.AddHours(-24)
                    },
                    new Complaint{
                        ComplaintId = 2,
                        ComplaintTypeId =2 ,
                        Details =" We need ABC Service",
                        Title = "Service Required!!",
                        IsResolved= false,
                        StatusId = 1,
                        Address= "office # 2, Blue street, Green area , karachi ",
                        ComplaineeName= "Tourism Office",
                        ContactDetails= "0345-9876543",
                        Timestamp= DateTime.Now
                    },
                    new Complaint{
                        ComplaintId = 3,
                        ComplaintTypeId =1 ,
                        Details =" Service speed is too slow since lockdown, please improve",
                        Title = "Service problem",
                        IsResolved= false,
                        StatusId = 3,
                        Address= "office # 10, Apple street, Mango area , karachi ",
                        ComplaineeName= "Ticketing Office",
                        ContactDetails= "0345-4564560",
                        Timestamp= DateTime.Now.AddHours(-6)
                    },
                    new Complaint{
                        ComplaintId = 4,
                        ComplaintTypeId =4 ,
                        Details =" We are shifting to other city, please disconnect service ASAP",
                        Title = "Disconnect now",
                        IsResolved= true,
                        StatusId = 5,
                        Address= "office # 20, SKY street, Star area , karachi ",
                        ComplaineeName= "Research Office",
                        ContactDetails= "0345-1001001",
                        Timestamp= DateTime.Now
                    }
                };
        public IEnumerable<Complaint> Complaints
        {
            get
            {
                return complaintList;
            }
        }
        public IEnumerable<Complaint> UnResolvedComplaints
        {
            get
            {
                return complaintList.Where(x => x.IsResolved == false).ToList();
            }
        }

        public bool AddComplaint(Complaint Complaint)
        {
            try
            {
                Complaint.ComplaintId =  complaintList.Max(x => x.ComplaintId) + 1;
                complaintList.Add(Complaint);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Complaint GetComplaint(int ComplaintId)
        {
            return complaintList.Where(x => x.ComplaintId == ComplaintId).FirstOrDefault();
        }

        public IEnumerable<Complaint> GetComplaintsByStatus(int StatusId)
        {
            return complaintList.Where(x => x.ComplaintId == StatusId).ToList();
        }
    }
}
