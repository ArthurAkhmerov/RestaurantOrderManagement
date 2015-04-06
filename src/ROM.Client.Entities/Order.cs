using System;
using Core.Common.Core;

namespace ROM.Business.Entities
{
    public class Order : ObjectBase
    {
        public int OrderId { get; set; }
        
        public DateTime TimeOrdered { get; set; }

        public DateTime TimeReady { get; set; }
        
        public DateTime TimeDelivered { get; set; }
        
        public string Status { get; set; }
        
        public decimal Total { get; set; }
    }
}
