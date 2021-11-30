using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramController
{
    public class InvoiceModel
    {
        public int InvoiceID { get; set; }
        public int VendorCode { get; set; }
        public double InvoiceAmount { get; set; }
        public double AmountPayed { get; set; }
        public string Date { get; set; }
        public int UserID { get; set; }
        public string PayedFor { get; set; }
        public List<TransactionModel> Transactions { get; set; }
    }
}
