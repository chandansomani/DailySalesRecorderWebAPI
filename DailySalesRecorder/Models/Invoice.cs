namespace DailySalesRecorder.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public InvoiceType InvoiceType { get; set; }
        public DateTime Date { get; set; }
        public int FarmerId { get; set; }
        public decimal Amount { get; set; }
        public decimal CreditAmt { get; set; }
        public decimal CashAmt { get; set; }
        public decimal UPIAmt { get; set; }
        public  int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
