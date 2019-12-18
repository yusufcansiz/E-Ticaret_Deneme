﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Entity.Entity
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int CardId { get; set; }

        public virtual Card Card { get; set; }
    }
}
