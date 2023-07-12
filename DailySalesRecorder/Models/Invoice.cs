using System.ComponentModel.DataAnnotations;

namespace DailySalesRecorder.Models
{
    public class Invoice
    {
        [Key] public int InvoiceID { get; set; } = 0;
        public InvoiceType InvoiceType { get; set; } = InvoiceType.SEED;
        public DateTime Date { get; set; } = DateTime.Now;
        public Farmer FarmerId { get; set; }
        public decimal Amount { get; set; } = decimal.Zero;
        public decimal CreditAmt { get; set; } = decimal.Zero;
        public decimal CashAmt { get; set; } = decimal.Zero;
        public decimal UPIAmt { get; set; } = decimal.Zero;
        public int CreatedBy { get; set; } = 0;
        public int UpdatedBy { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
