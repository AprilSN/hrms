using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmsProject
{
    public class PaymentModel
    {
        public int Employee_ID { get; set; }
        public decimal Employee_Salary { get; set; } 
        public decimal Employee_Bonus { get; set; }
        public decimal Employee_Deduction { get; set; }
        public decimal Total_Payment { get; set; }
        public string Payment_Date { get; set; }
    }
}
