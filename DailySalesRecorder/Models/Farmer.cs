using System.ComponentModel.DataAnnotations;

namespace DailySalesRecorder.Models
{
    public class Farmer
    {
        public int FarmerId { get; set; } = 0;
        public string FarmerName { get; set; } = string.Empty;
        public string FarmerPlace { get; set; } = string.Empty;
        public ulong MobileNo { get; set; } = 0;
        public ulong Aadhaar { get; set; } = 0;
        public int CreatedBy { get; set; } = 0;
        public int UpdatedBy { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
