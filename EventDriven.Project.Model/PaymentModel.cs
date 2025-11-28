using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
        public class PaymentModel
    {
        private int Id { get; set; }
        private int StudentId { get; set; }
        private decimal AmountPaid { get; set; }
        private decimal Change { get; set; }
        private DateTime DatePaid { get; set; }
    }
}
