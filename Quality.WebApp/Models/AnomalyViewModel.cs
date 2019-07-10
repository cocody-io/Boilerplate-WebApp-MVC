using System;
using System.Collections.Generic;

namespace Quality.WebApp
{
    public class AnomalyViewModel
    {
        public int AnomalyId { get; set; }
        public DateTime CreationDate { get; set; }
        public TicketNCViewModel TicketNC { get; set; }
    }
}