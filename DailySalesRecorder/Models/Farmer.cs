namespace DailySalesRecorder.Models
{
    public class Farmer
    {
        int FarmerId { get; set; }
        public string FarmerName { get; set; }
        public string FarmerPlace { get; set; }
        public ulong MobileNo { get; set; }
        public ulong Aadhaar { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}
