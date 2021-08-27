using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLesson
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public int PhoneId { get; set; }

        public virtual Phone Phone { get; set; }
    }
}
