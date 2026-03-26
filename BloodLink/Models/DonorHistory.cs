using System;
using System.Collections.Generic;
using System.Text;

namespace BloodLink.Models
{
    public class DonationHistory
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public DateTime DonationDate { get; set; }
        public string Hospital { get; set; }
        public string Notes { get; set; }
    }
}
