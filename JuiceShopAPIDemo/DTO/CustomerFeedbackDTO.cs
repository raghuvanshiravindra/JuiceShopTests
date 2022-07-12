using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceShopAPIDemo
{
    public class LeaveCustomerFeedbackDTO
    {
        public long Id { get; set; }
        public string comment { get; set; }
        public long rating { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public object UserId { get; set; }
    }
}
