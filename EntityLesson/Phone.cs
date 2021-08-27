using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLesson
{
    public partial class Phone
    {
        public Phone()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
